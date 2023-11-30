using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace dnd
{
    public partial class Create_Encounter : Form
    {
        
        private int number_Of_Characters;
        private string dificulty;
        private int total_XP = 0;
        private int easy_xp = 0;
        private int medium_xp = 0;
        private int hard_xp = 0;
        private int deadly_xp = 0;
        public Create_Encounter()
        {
            InitializeComponent();
        }

        private void Create_Encounter_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Get the monsters available and displays it's information in the datagrid
            DataSet Monsters = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_MONSTER_DATA);
            int number_of_monsters = Monsters.Tables[0].Rows.Count;
            if (number_of_monsters != 0)
            {
                for (int i = 0; i < number_of_monsters; i++)
                {
                    //Add elements to the list
                    available_Monsters.Rows.Add(Monsters.Tables[0].Rows[i][0], Monsters.Tables[0].Rows[i][1], Monsters.Tables[0].Rows[i][2]);

                }
            }
            else
            {
                available_Monsters.Rows.Add(-1, "No Monsters found");
                available_Monsters.Enabled = false;
            }

            //Array with the necesary XP for each character according to their level and difficulty of the encounter
            int[,] difficulty_by_Character ={ {25,50,75,100 } , { 50,100,150,200}, { 75,150,225,400 }, { 125,250,375,500}, {250,500,750,1100}, {300,600,900,1400 }, {350,750,1100,1700 }, {450,900,1400,2100}, {550,1100,1600,2400}, {600,1200,1900,2800},
                { 800,1600,2400,3600 }, {1000,2000,3000,4500 }, {1100,2200,3400,5100 }, {1250,2500,3800,5700}, {1400,2800,4300,6400}, { 1600,3200,4800,7200}, { 2000, 3900,5900,8800}, { 2100,4200,6300,9500}, { 2400, 4900,7300,10900}, {2800,5700,8500,12700}};
            int[] daily_Budget_By_Level = { 300, 600,1200,1700,3500,4000,5000,6000,7500,9000,10500,11500,13500,15000,18000,20000,25000,27000,30000,40000};

            //Get character information in order to calculate encountr difficulty
            int Campaing_Id = Campaing_For_Encounter.selected_Campaing_ID;
            DataSet character_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, Campaing_Id);
            number_Of_Characters = character_Info.Tables[0].Rows.Count;
            int daily_Budget = 0;
            float average_level = 0;
            for (int i = 0; i < number_Of_Characters; i++)
            {
                DataSet character_Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, Convert.ToInt32(character_Info.Tables[0].Rows[i][0].ToString()));
                int character_level = 0;
                for (int j = 0; j < character_Level_Info.Tables[0].Rows.Count; j++)
                {
                    character_level = character_level+Convert.ToInt32(character_Level_Info.Tables[0].Rows[j][0].ToString());
                }
                average_level = average_level+character_level;
                easy_xp = +difficulty_by_Character[character_level-1, 0];
                medium_xp = +difficulty_by_Character[character_level-1, 1];
                hard_xp = +difficulty_by_Character[character_level-1, 2];
                deadly_xp = +difficulty_by_Character[character_level-1, 3];
                daily_Budget = +daily_Budget_By_Level[character_level - 1];
            }

            average_level = average_level / number_Of_Characters;
            Easy.Text = "Easy: " + easy_xp;
            Medium.Text = "Medium " + medium_xp;
            Hard.Text = "Hard " + hard_xp;
            Deadly.Text = "Deadly " + deadly_xp;
            average_char_level.Text = "Average Character Level " + average_level;
            xp_of_encounter.Text = "Total XP: 0";
            ajusted_xp.Text = "Ajusted XP=0";
            difficulty_Text.Text = "Difuculty: Trivial";
            daily_budget.Text = "Daily Budget: " + daily_Budget;

        }



        private void Save_Click(object sender, EventArgs e)
        {
            //get the campaing id from the name selected in the campaing selectiom window
            int Campaing_Id = Campaing_For_Encounter.selected_Campaing_ID;

            if (name_text.Text != "" && chosen_Monsters.Rows.Count != 0)
            {

                //save the new encounter, the turn and round will be 1 since it's a new encounter
                DBConnection.getInstanceOfDBConnection().saveNewEncounter(Constants.SAVE_NEW_ENCOUNTER, name_text.Text, description_text.Text, 1, 1, Campaing_Id,dificulty);
                DataSet encounter_ids = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_ENCOUNTER_ID);
                int Encounter_ID = Convert.ToInt32(encounter_ids.Tables[0].Rows[encounter_ids.Tables[0].Rows.Count - 1][0].ToString());

                // Save all the monsters on the list
                for (int i = 0; i < chosen_Monsters.Rows.Count; i++)
                {


                    int Monster_ID = Convert.ToInt32(chosen_Monsters.Rows[i].Cells[Id.Index].Value.ToString());

                    DBConnection.getInstanceOfDBConnection().saveNewMonsterList(Constants.SAVE_NEW_MONSTER_LIST, Encounter_ID, Monster_ID);
                }

                //Go to the previous page when finished
                this.Hide();
                Encounter_List save = new Encounter_List();
                save.ShowDialog();
                this.Close();


            }
            else
            {
                //Show error window if the name is not in place
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name, Monsters for the encounter)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void available_Monsters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataSet image = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_STATBLOCK_FROM_ID, Convert.ToInt32(available_Monsters.Rows[e.RowIndex].Cells[0].Value.ToString()));
                MemoryStream ms = new MemoryStream((byte[])image.Tables[0].Rows[0][0]);
                ST.Image = new Bitmap(ms);
            }


        }

        private void available_Monsters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected_Row_ID = available_Monsters.Rows[e.RowIndex].Cells[Id.Index].Value.ToString();
            string selected_Row_Name = available_Monsters.Rows[e.RowIndex].Cells[creature_name.Index].Value.ToString();
            string selected_Row_CR = available_Monsters.Rows[e.RowIndex].Cells[monster_CR.Index].Value.ToString();

            chosen_Monsters.Rows.Add(selected_Row_ID,selected_Row_Name,selected_Row_CR);


            //Select the XP that needs adding in according to the CR of each creature
            string CR = chosen_Monsters.Rows[e.RowIndex].Cells[chosen_CR.Index].Value.ToString();
            switch (CR)
            {
                case "0":
                    total_XP = total_XP + 10;
                    break;

                case "1/8":
                    total_XP = total_XP + 25;
                    break;
                case "1/4":
                    total_XP = total_XP + 50;
                    break;
                case "1/2":
                    total_XP = total_XP + 100;
                    break;
                case "1":
                    total_XP = total_XP + 200;
                    break;
                case "2":
                    total_XP = total_XP + 450;
                    break;
                case "3":
                    total_XP = total_XP + 700;
                    break;
                case "4":
                    total_XP = total_XP + 1100;
                    break;
                case "5":
                    total_XP = total_XP + 1800;
                    break;
                case "6":
                    total_XP = total_XP + 2300;
                    break;
                case "7":
                    total_XP = total_XP + 2900;
                    break;
                case "8":
                    total_XP = total_XP + 3900;
                    break;
                case "9":
                    total_XP = total_XP + 5000;
                    break;
                case "10":
                    total_XP = total_XP + 5900;
                    break;
                case "11":
                    total_XP = total_XP + 7200;
                    break;
                case "12":
                    total_XP = total_XP + 8400;
                    break;
                case "13":
                    total_XP = total_XP + 10000;
                    break;
                case "14":
                    total_XP = total_XP + 11500;
                    break;
                case "15":
                    total_XP = total_XP + 13500;
                    break;
                case "16":
                    total_XP = total_XP + 15300;
                    break;
                case "17":
                    total_XP = total_XP + 18000;
                    break;
                case "18":
                    total_XP = total_XP + 20000;
                    break;
                case "19":
                    total_XP = total_XP + 22000;
                    break;
                case "20":
                    total_XP = total_XP + 25000;
                    break;
                case "21":
                    total_XP = total_XP + 33000;
                    break;
                case "22":
                    total_XP = total_XP + 41000;
                    break;
                case "23":
                    total_XP = total_XP + 50000;
                    break;
                case "24":
                    total_XP = total_XP + 62000;
                    break;
                case "25":
                    total_XP = total_XP + 75000;
                    break;
                case "26":
                    total_XP = total_XP + 90000;
                    break;
                case "27":
                    total_XP = total_XP + 105000;
                    break;
                case "28":
                    total_XP = total_XP + 120000;
                    break;
                case "29":
                    total_XP = total_XP + 135000;
                    break;
                case "30":
                    total_XP = total_XP + 155000;
                    break;

            }
            int number_Of_Monsters = chosen_Monsters.RowCount;
            float[] modifier_Options = { (float)0.5, 1, (float)1.5, 2, (float)2.5, 3, 4, 5 };
            int chosen_Multiplier = 0;

            //Check the multiplier selected related to the number of characters and monsters
            if (number_Of_Monsters == 1)
            {
                chosen_Multiplier = 1;
            }
            else if (number_Of_Monsters == 2)
            {
                chosen_Multiplier = 2;
            }
            else if (number_Of_Monsters >= 3 && number_Of_Monsters <= 6)
            {
                chosen_Multiplier = 3;
            }
            else if (number_Of_Monsters >= 7 && number_Of_Monsters <= 10)
            {
                chosen_Multiplier = 4;
            }
            else if (number_Of_Monsters >= 11 && number_Of_Monsters <= 14)
            {
                chosen_Multiplier = 5;
            }
            else if (number_Of_Monsters >= 15)
            {
                chosen_Multiplier = 6;
            }

            if (number_Of_Characters <= 3)
            {
                chosen_Multiplier = +1;
            }
            else if (number_Of_Characters >= 6)
            {
                chosen_Multiplier = -1;
            }

            float ajusted_Experience = total_XP * modifier_Options[chosen_Multiplier];
            xp_of_encounter.Text = "Total XP:" + total_XP;
            ajusted_xp.Text = "Ajusted XP= " + ajusted_Experience;

            if (ajusted_Experience < easy_xp)
            {
                dificulty = "Trivial";
                difficulty_Text.Text = "Difuculty: Trivial";
            }
            else if (ajusted_Experience >= easy_xp && ajusted_Experience < medium_xp)
            {
                dificulty = "Easy";
                difficulty_Text.Text = "Difuculty: Easy";
            }
            else if (ajusted_Experience >= medium_xp && ajusted_Experience < hard_xp)
            {
                dificulty = "Medium";
                difficulty_Text.Text = "Difuculty: Medium";
            }
            else if (ajusted_Experience >= hard_xp && ajusted_Experience < deadly_xp)
            {
                dificulty = "Hard";
                difficulty_Text.Text = "Difuculty: Hard";
            }
            else if (ajusted_Experience >= deadly_xp)
            {
                dificulty = "Deadly";
                difficulty_Text.Text = "Difuculty: Deadly";
            }
        }

        private void chosen_Monsters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataSet image = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_STATBLOCK_FROM_ID, Convert.ToInt32(chosen_Monsters.Rows[e.RowIndex].Cells[0].Value.ToString()));
                MemoryStream ms = new MemoryStream((byte[])image.Tables[0].Rows[0][0]);
                ST.Image = new Bitmap(ms);
            }

        }

        private void chosen_Monsters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                
                //Select the XP that needs adding in according to the CR of each creature
                string CR = chosen_Monsters.Rows[e.RowIndex].Cells[2].Value.ToString();
                switch (CR)
                {
                    case "0":
                        total_XP = total_XP-10;
                        break;

                    case "1/8":
                        total_XP = total_XP-25;
                        break;
                    case "1/4":
                        total_XP = total_XP - 50;
                        break;
                    case "1/2":
                        total_XP = total_XP - 100;
                        break;
                    case "1":
                        total_XP = total_XP - 200;
                        break;
                    case "2":
                        total_XP = total_XP - 450;
                        break;
                    case "3":
                        total_XP = total_XP - 700;
                        break;
                    case "4":
                        total_XP = total_XP - 1100;
                        break;
                    case "5":
                        total_XP = total_XP - 1800;
                        break;
                    case "6":
                        total_XP = total_XP - 2300;
                        break;
                    case "7":
                        total_XP = total_XP - 2900;
                        break;
                    case "8":
                        total_XP = total_XP - 3900;
                        break;
                    case "9":
                        total_XP = total_XP - 5000;
                        break;
                    case "10":
                        total_XP = total_XP - 5900;
                        break;
                    case "11":
                        total_XP = total_XP - 7200;
                        break;
                    case "12":
                        total_XP = total_XP - 8400;
                        break;
                    case "13":
                        total_XP = total_XP - 10000;
                        break;
                    case "14":
                        total_XP = total_XP - 11500;
                        break;
                    case "15":
                        total_XP = total_XP - 13500;
                        break;
                    case "16":
                        total_XP = total_XP - 15300;
                        break;
                    case "17":
                        total_XP = total_XP - 18000;
                        break;
                    case "18":
                        total_XP = total_XP - 20000;
                        break;
                    case "19":
                        total_XP = total_XP - 22000;
                        break;
                    case "20":
                        total_XP = total_XP - 25000;
                        break;
                    case "21":
                        total_XP = total_XP - 33000;
                        break;
                    case "22":
                        total_XP = total_XP - 41000;
                        break;
                    case "23":
                        total_XP = total_XP - 50000;
                        break;
                    case "24":
                        total_XP = total_XP - 62000;
                        break;
                    case "25":
                        total_XP = total_XP - 75000;
                        break;
                    case "26":
                        total_XP = total_XP - 90000;
                        break;
                    case "27":
                        total_XP = total_XP - 105000;
                        break;
                    case "28":
                        total_XP = total_XP - 120000;
                        break;
                    case "29":
                        total_XP = total_XP - 135000;
                        break;
                    case "30":
                        total_XP = total_XP - 155000;
                        break;

                }
                int number_Of_Monsters = chosen_Monsters.RowCount;
                float[] modifier_Options = { (float)0.5, 1, (float)1.5, 2, (float)2.5, 3, 4, 5 };
                int chosen_Multiplier = 0;

                //Check the multiplier selected related to the number of characters and monsters
                if (number_Of_Monsters == 1)
                {
                    chosen_Multiplier = 1;
                }
                else if (number_Of_Monsters == 2)
                {
                    chosen_Multiplier = 2;
                }
                else if (number_Of_Monsters >= 3 && number_Of_Monsters <= 6)
                {
                    chosen_Multiplier = 3;
                }
                else if (number_Of_Monsters >= 7 && number_Of_Monsters <= 10)
                {
                    chosen_Multiplier = 4;
                }
                else if (number_Of_Monsters >= 11 && number_Of_Monsters <= 14)
                {
                    chosen_Multiplier = 5;
                }
                else if (number_Of_Monsters >= 15)
                {
                    chosen_Multiplier = 6;
                }

                if (number_Of_Characters <= 3)
                {
                    chosen_Multiplier = +1;
                }
                else if (number_Of_Characters >= 6)
                {
                    chosen_Multiplier = -1;
                }

                float ajusted_Experience = total_XP * modifier_Options[chosen_Multiplier];
                xp_of_encounter.Text = "Total XP:" + total_XP;
                ajusted_xp.Text = "Ajusted XP= " + ajusted_Experience;

                if (ajusted_Experience < easy_xp)
                {
                    dificulty = "Trivial";
                    difficulty_Text.Text = "Difuculty: Trivial";
                }
                else if (ajusted_Experience >= easy_xp && ajusted_Experience < medium_xp)
                {
                    dificulty = "Easy";
                    difficulty_Text.Text = "Difuculty: Easy";
                }
                else if (ajusted_Experience >= medium_xp && ajusted_Experience < hard_xp)
                {
                    dificulty = "Medium";
                    difficulty_Text.Text = "Difuculty: Medium";
                }
                else if (ajusted_Experience >= hard_xp && ajusted_Experience < deadly_xp)
                {
                    dificulty = "Hard";
                    difficulty_Text.Text = "Difuculty: Hard";
                }
                else if (ajusted_Experience >= deadly_xp)
                {
                    dificulty = "Deadly";
                    difficulty_Text.Text = "Difuculty: Deadly";
                }
            }

            chosen_Monsters.Rows.RemoveAt(e.RowIndex);
        }

        
       


        private void Help_Click(object sender, EventArgs e)
        {
            Rules_List rule = new Rules_List();
            rule.ShowDialog();
        }

        private void dice_Click(object sender, EventArgs e)
        {
            Dice_Roll dice = new Dice_Roll();
            dice.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encounter_List back = new Encounter_List();
            back.ShowDialog();
            this.Close();
        }
    }
}

