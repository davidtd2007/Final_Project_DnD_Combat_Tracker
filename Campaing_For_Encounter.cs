using System;
using System.Data;
using System.Windows.Forms;

namespace dnd
{
    public partial class Campaing_For_Encounter : Form
    {
        
        public static int selected_Campaing_ID;
        
        public Campaing_For_Encounter()
        {

            InitializeComponent();
           
    }

        private void Campaing_For_Encounter_Load(object sender, EventArgs e)
        {
            
            //display data from campaing to the list

            //get the name of the campaing and how many are there
            DataSet campaing_DataSet = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_CAMPAING);
            int campaing_Element_Number = campaing_DataSet.Tables[0].Rows.Count;

            //Add the differnet elements to the list with the corresponding number of characters
            for (int i = 0; i < campaing_Element_Number; i++)
            {
                int campaing_ID = Convert.ToInt32(campaing_DataSet.Tables[0].Rows[i][0]);
                string campaing_name = campaing_DataSet.Tables[0].Rows[i][1].ToString();
                DataSet Character_Id_By_Campaing = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, campaing_ID);
                int number_of_characters = Character_Id_By_Campaing.Tables[0].Rows.Count;
                float average_level =0;

                for (int j = 0; j < number_of_characters; j++)
                {
                    int character_Level = 0;
                    int character_id = Convert.ToInt32(Character_Id_By_Campaing.Tables[0].Rows[j][0].ToString());
                    DataSet character_Levels = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, character_id);
                    for (int z=0;z<character_Levels.Tables[0].Rows.Count;z++)
                    {
                        character_Level =character_Level+ Convert.ToInt32(character_Levels.Tables[0].Rows[z][0].ToString());
                    }

                    average_level = average_level+ character_Level;
                }

                average_level = average_level / number_of_characters;
                //Add elements to the lists
                Campaing_Lists.Rows.Add(campaing_ID,campaing_name,number_of_characters,average_level);
            }
            
        }


        private void Campaing_Lists_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                if (Convert.ToInt32(Campaing_Lists.Rows[e.RowIndex].Cells[Character_Number.Index].Value.ToString()) != 0)
                {
                    // save the selection and open the encounters created for that campaing. 
                    selected_Campaing_ID = Convert.ToInt32(Campaing_Lists.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                    this.Hide();
                    Encounter_List next = new Encounter_List();
                    next.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There are no characters in this Campaign! Create some and come back", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.ShowDialog();
            this.Close();
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
    }
    

}
    

