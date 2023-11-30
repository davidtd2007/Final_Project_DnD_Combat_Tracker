using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd
{


    public partial class Encounter_Per_Se : Form
    {
        int selectet_row_index;
        int turn;
        public static int round;

        //Save the creature and the encounter id selected for the creation of a new condition
        public static int Encounter_Id = Encounter_List.selected_Encounter_ID;
        public static int selected_Creature_Id;
        public static int number_of_creatures;
        public static string select_Creature_Type;
        public static string select_Creature_Name;

        public Encounter_Per_Se()
        {
            InitializeComponent();
        }

        private void Encounter_Load(object sender, EventArgs e)
        {
            Encounter_Id=Encounter_List.selected_Encounter_ID;
            Modifier.Text = "0";
            CreateIniCount();
            LoadIniCount();
            //Dipslay the HP information of the first element of the gried view
            DataGridViewRow Current_Row = Data.Rows[0];
            selectet_row_index = 0;
            curren_HP_text.Text = Current_Row.Cells[Current_HP.Index].Value.ToString();
            maximum_HP_text.Text = Current_Row.Cells[Maximun_HP.Index].Value.ToString();


            //Change the first row's color. This color will be the indicating the user who's turn it is
            for (int j = 0; j < Current_Row.Cells.Count; j++)
            {
                Current_Row.Cells[j].Style.BackColor = Color.Pink;
            }

            //Se the turn and round that the combat currently is in
            DataSet Encounter_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_ENCOUNTER_INFO_FROM_ID, Encounter_Id);
            Title.Text = Encounter_Info.Tables[0].Rows[0][4].ToString();
            turn = Convert.ToInt32(Encounter_Info.Tables[0].Rows[0][1].ToString());
            round = Convert.ToInt32(Encounter_Info.Tables[0].Rows[0][2].ToString());

            Turn_label.Text = turn.ToString();
            Round_label.Text = round.ToString();

            LoadStatus();

        }

        //If a cell is selected show the HP information in the HP section
        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                selectet_row_index = e.RowIndex;
                curren_HP_text.Text = Data.Rows[selectet_row_index].Cells[Current_HP.Index].Value.ToString();
                maximum_HP_text.Text = Data.Rows[selectet_row_index].Cells[Maximun_HP.Index].Value.ToString();

                if (Data.Rows[selectet_row_index].Cells[6].Value.ToString() == "Monster")
                {
                    

                    DataSet image = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_STATBLOCK_FROM_ID, Convert.ToInt32(Data.Rows[selectet_row_index].Cells[0].Value.ToString()));
                    MemoryStream ms = new MemoryStream((byte[])image.Tables[0].Rows[0][0]);
                    ST.Image = new Bitmap(ms);
                }

            }


        }

        private void Heal_Click(object sender, EventArgs e)
        {
            if (Modifier.Text == "")
            {
                Modifier.Text = "0";
            }
            
            int HP = Convert.ToInt32(curren_HP_text.Text) + Convert.ToInt32(Modifier.Text);

            if (HP > Convert.ToInt32(maximum_HP_text.Text))
            {
                HP = Convert.ToInt32(maximum_HP_text.Text);
            }
            curren_HP_text.Text = HP.ToString();
            Data.Rows[selectet_row_index].Cells[Current_HP.Index].Value = HP.ToString();
            Data.UpdateCellValue(Current_HP.Index, selectet_row_index);

        }

        private void Damage_Click(object sender, EventArgs e)
        {
            if (Modifier.Text == "")
            {
                Modifier.Text = "0";
            }
          
            int HP = Convert.ToInt32(curren_HP_text.Text) - Convert.ToInt32(Modifier.Text);

            if (HP < 0)
            {
                HP = 0;
            }
            curren_HP_text.Text = HP.ToString();
            Data.Rows[selectet_row_index].Cells[Current_HP.Index].Value = HP.ToString();
            Data.UpdateCellValue(Current_HP.Index, selectet_row_index);
        }

        private void Modifier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (round != 0 && turn != 1)
            {
                for (int j = 0; j < Data.Rows[turn - 1].Cells.Count; j++)
                {
                    Data.Rows[turn - 1].Cells[j].Style.BackColor = Color.FromArgb(255, 255, 192);
                }
                turn--;
                if (turn < 1)
                {
                    turn = 1;
                    round--;
                }

                for (int j = 0; j < Data.Rows[turn - 1].Cells.Count; j++)
                {
                    Data.Rows[turn - 1].Cells[j].Style.BackColor = Color.Pink;
                }



                Turn_label.Text = turn.ToString();
                Round_label.Text = round.ToString();
            }

            for (int i = 0; i < Status.Rows.Count; i++)
            {
                switch (Status.Rows[i].Cells[4].Value.ToString())
                {
                    case "Turns":
                        Status.Rows[i].Cells[duration_time.Index].Value = Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) + 1;
                        break;
                    case "Rounds":
                        if (turn == 1)
                        {
                            Status.Rows[i].Cells[duration_time.Index].Value = Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) + 1;
                        }
                        break;
                }


            }
            CheckStatus();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < Data.Rows[turn - 1].Cells.Count; j++)
            {
                Data.Rows[turn - 1].Cells[j].Style.BackColor = Color.FromArgb(255, 255, 192);
            }

            turn++;

            // If the turn gets to end end if the list, change the round and re-start the turn
            if (turn > Data.Rows.Count)
            {
                turn = 1;
                round++;
            }

            for (int j = 0; j < Data.Rows[turn - 1].Cells.Count; j++)
            {
                Data.Rows[turn - 1].Cells[j].Style.BackColor = Color.Pink;
            }


            Turn_label.Text = turn.ToString();
            Round_label.Text = round.ToString();
            for (int i = 0; i < Status.Rows.Count; i++)
            {
                switch (Status.Rows[i].Cells[Duration_Type.Index].Value.ToString())
                {
                    case "Turns":
                        Status.Rows[i].Cells[duration_time.Index].Value = Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) - 1;
                        break;
                    case "Rounds":
                        if (turn == 1)
                        {
                            Status.Rows[i].Cells[duration_time.Index].Value = Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) - 1;
                        }
                        break;
                }


            }


            CheckStatus();

        }

        private void Add_Condition_Click(object sender, EventArgs e)
        {
            saveStatus();
            DataGridViewRow SelectedRow = Data.Rows[selectet_row_index];
            selected_Creature_Id = Convert.ToInt32(SelectedRow.Cells[Id.Index].Value.ToString());
            select_Creature_Type = SelectedRow.Cells[Creature_Type.Index].Value.ToString();
            select_Creature_Name= SelectedRow.Cells[creature_name.Index].Value.ToString();
            number_of_creatures = Data.Rows.Count;
            Condition_Creation condition = new Condition_Creation();
            //Add to the event handling the method Condition_Creation_FormClosing so when the form Condition_creation closes, the Conditions grid is updated
            condition.FormClosing += new FormClosingEventHandler(Condition_Creation_FormClosing);
            condition.ShowDialog();


        }

        private void Condition_Creation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Status.Rows.Clear();
            LoadStatus();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (Status.CurrentCell.RowIndex >= 0)
            {
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_STATUS, Convert.ToInt32(Status.Rows[Status.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                Status.Rows.RemoveAt(Status.CurrentCell.RowIndex);
            }

        }

        //This method checks if the condition should be visible or not
        private void CheckStatus()
        {
            for (int i = 0; i < Status.Rows.Count; i++)
            {
                if (Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) < 0)
                {
                    Status.Rows[i].Visible = false;
                }

                if (Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) >= 0)
                {
                    Status.Rows[i].Visible = true;
                }

                if (Status.Rows[i].Cells[4].Value.ToString() == "Until Dismissed")
                {
                    Status.Rows[i].Visible = true;
                }

                if (Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString()) == 1 && Status.Rows[i].Cells[Duration_Type.Index].Value.ToString() == "Rounds")
                {
                    Status.Rows[i].Cells[duration_time.Index].Value = Data.Rows.Count;
                    Status.Rows[i].Cells[Duration_Type.Index].Value = "Turns";
                }
            }

        }

        private void LoadStatus()
        {
            DataSet Status_list = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_STATUS_FROM_ENCOUNTER_ID, Encounter_Id);

            for (int i = 0; i < Status_list.Tables[0].Rows.Count; i++)
            {
                int id = Convert.ToInt32(Status_list.Tables[0].Rows[i][0].ToString());
                string condition = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CONDITON_NAME_FROM_ID, Convert.ToInt32(Status_list.Tables[0].Rows[i][3].ToString())).Tables[0].Rows[0][0].ToString();
                string Duration = Status_list.Tables[0].Rows[i][2].ToString();
                string Duration_Type = Status_list.Tables[0].Rows[i][1].ToString();
                string Turn_Of_Round = Status_list.Tables[0].Rows[i][7].ToString();
                string Round_To_Hide = Status_list.Tables[0].Rows[i][8].ToString();
                string name;

                if (Status_list.Tables[0].Rows[i][4].ToString()!="")
                {
                    name = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_NAME_FROM_ID, Convert.ToInt32(Status_list.Tables[0].Rows[i][4].ToString())).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    name = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_NAME_FROM_ID, Convert.ToInt32(Status_list.Tables[0].Rows[i][6].ToString())).Tables[0].Rows[0][0].ToString();
                }


                Status.Rows.Add(id, name, condition, Duration, Duration_Type, Turn_Of_Round, Round_To_Hide);
            }
            CheckStatus();
        }

        private void CreateIniCount()
        {
            //If the initiative count already exist don't create another
            if (DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_INITIAITVE_ID_FROM_ENCOUNTER, Encounter_Id).Tables[0].Rows.Count == 0)
            {

                int Campaing_ID = Campaing_For_Encounter.selected_Campaing_ID;
                DataSet Characters_Information = DBConnection.getInstanceOfDBConnection().getDATAFromCampaingID(Constants.GET_CHARACTER_INFO_FROM_CAMPAING_ID, Campaing_ID);
                DiceRoller roll = new DiceRoller();
                //Add all the characters to the initiative count
                for (int i = 0; i < Characters_Information.Tables[0].Rows.Count; i++)
                {

                    int initiative = roll.Roll(21) + Convert.ToInt32(Characters_Information.Tables[0].Rows[i][3]);
                    int HP = Convert.ToInt32(Characters_Information.Tables[0].Rows[i][6].ToString());
                    int id = Convert.ToInt32(Characters_Information.Tables[0].Rows[i][0].ToString());
                    DBConnection.getInstanceOfDBConnection().saveNewInitiativeCountCharacter(Constants.SAVE_NEW_INIT_CHARACTER, Encounter_Id, id, initiative, HP);
                }

                //Add all the mosnter in the mosnter list of this encounter to the initiaitve count
                DataSet Monster_List_Information = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_ID_FROM_ENCOUNTER, Encounter_Id);
                for (int i = 0; i < Monster_List_Information.Tables[0].Rows.Count; i++)
                {
                    DataSet Monster_Information = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_INFO_FROM_ID, Convert.ToInt32(Monster_List_Information.Tables[0].Rows[i][0]));
                    int initiative = roll.Roll(21) + Convert.ToInt32(Monster_Information.Tables[0].Rows[0][3].ToString());
                    int HP = Convert.ToInt32(Monster_Information.Tables[0].Rows[0][6].ToString());
                    DBConnection.getInstanceOfDBConnection().saveNewInitiativeCountMonster(Constants.SAVE_NEW_INIT_MONSTER, Encounter_Id, Convert.ToInt32(Monster_List_Information.Tables[0].Rows[i][0]), initiative, HP);
                }

            }

        }
        private void LoadIniCount()
        {
            //Get the Intiatives of all Characters and monsters 
            DataSet Initiatives = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_INITIAITVE_ID_FROM_ENCOUNTER, Encounter_Id);
            List<int> Positions = new List<int>();

            for (int i = 0; i < Initiatives.Tables[0].Rows.Count; i++)
            {
                Positions.Add(Convert.ToInt32(Initiatives.Tables[0].Rows[i][0].ToString()));
            }

            //Sort the initiatives
            Positions = Sort.SortList(Positions, 0, Positions.Count - 1);

            Positions = Positions.Distinct().ToList();

            //Add them to the table, some are monsters and some are characters
            for (int i = 0; i < Positions.Count; i++)
            {

                DataSet Monster_Info_From_Initiative_Count = DBConnection.getInstanceOfDBConnection().getDATAFromInitiativeAndEncounter_ID(Constants.GET_MONSTER_INFO_FROM_INTITIATIVE, Positions[i], Encounter_Id);
                DataSet Character_Info_From_Initiative_Count = DBConnection.getInstanceOfDBConnection().getDATAFromInitiativeAndEncounter_ID(Constants.GET_CHARACTER_INFO_FROM_INTITIATIVE, Positions[i], Encounter_Id);


                if (Monster_Info_From_Initiative_Count.Tables[0].Rows[0][0].ToString() != "")
                {


                    for (int j = 0; j < Monster_Info_From_Initiative_Count.Tables[0].Rows.Count; j++)
                    {
                        DataSet Monster_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_INFO_FROM_ID, Convert.ToInt32(Monster_Info_From_Initiative_Count.Tables[0].Rows[j][0].ToString()));
                        int Creature_id = Convert.ToInt32(Monster_Info.Tables[0].Rows[0][0].ToString());
                        string name = Monster_Info.Tables[0].Rows[0][4].ToString();
                        int HP = Convert.ToInt32(Monster_Info.Tables[0].Rows[0][6].ToString());
                        int AC = Convert.ToInt32(Monster_Info.Tables[0].Rows[0][5].ToString());
                        int current_HP = Convert.ToInt32(Monster_Info_From_Initiative_Count.Tables[0].Rows[j][1].ToString());
                        int List_Id = Convert.ToInt32(Monster_Info_From_Initiative_Count.Tables[0].Rows[j][2].ToString());
                        Data.Rows.Add(Creature_id, name, Positions[i].ToString(), AC, current_HP, HP, "Monster", List_Id);

                    }
                }
                else
                {
                    for (int j = 0; j < Character_Info_From_Initiative_Count.Tables[0].Rows.Count; j++)
                    {
                        DataSet Character_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_INFO_FROM_ID, Convert.ToInt32(Character_Info_From_Initiative_Count.Tables[0].Rows[j][0].ToString()));
                        int Character_id = Convert.ToInt32(Character_Info.Tables[0].Rows[0][0].ToString());
                        string name = Character_Info.Tables[0].Rows[0][5].ToString();
                        int HP = Convert.ToInt32(Character_Info.Tables[0].Rows[0][6].ToString());
                        int AC = Convert.ToInt32(Character_Info.Tables[0].Rows[0][4].ToString());
                        int current_HP = Convert.ToInt32(Character_Info_From_Initiative_Count.Tables[0].Rows[j][1].ToString());
                        int List_Id = Convert.ToInt32(Character_Info_From_Initiative_Count.Tables[0].Rows[j][2].ToString());
                        Data.Rows.Add(Character_id, name, Positions[i].ToString(), AC, current_HP, HP, "Character", List_Id);
                    }
                }
            }
        }

        private void saveStatus()
        {
            for (int i = 0; i < Status.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Status.Rows[i].Cells[Id.Index].Value.ToString());
                int duration = Convert.ToInt32(Status.Rows[i].Cells[duration_time.Index].Value.ToString());
                string duration_Type = Status.Rows[i].Cells[Duration_Type.Index].Value.ToString();

                DBConnection.getInstanceOfDBConnection().updateCondition(Constants.UPDATE_CONDITION, duration_Type, duration, id);

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Save the changes that occur in the combat
            for (int i = 0; i < Data.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Data.Rows[i].Cells[List_ID.Index].Value.ToString());
                int Current_HP = Convert.ToInt32(Data.Rows[i].Cells[4].Value.ToString());
                DBConnection.getInstanceOfDBConnection().updateIni_Count(Constants.UPDATE_INI_COUNT, Current_HP, id);
            }
            // save the current turn and round

            DBConnection.getInstanceOfDBConnection().update_Encounter(Constants.UPDATE_ENCOUNTER, turn, round, Encounter_Id);
            //Save the status
            saveStatus();

            this.Hide();
            Encounter_List back = new Encounter_List();
            this.Close();
            back.ShowDialog();
            
        }

        private void dice_Click(object sender, EventArgs e)
        {
            Dice_Roll dice = new Dice_Roll();
            dice.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Rules_List rule = new Rules_List();
            rule.ShowDialog();
        }
    }
}

