using System;
using System.Data;
using System.Windows.Forms;

namespace dnd
{
    public partial class Campaing_Menu_List : Form
    {
        //save the campaing name we are working on
        public static int selected_Campaing_ID;
        int selected_row_index = 0;
        public Campaing_Menu_List()
        {
            InitializeComponent();
        }


        private void Campaing_Menu_Load(object sender, EventArgs e)
        {
            //display data from campaing to the list

            //get the name of the campaing and how many are there
            DataSet campaing_DataSet = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_CAMPAING);
            int campaing_Element_Number = campaing_DataSet.Tables[0].Rows.Count;
            if (campaing_Element_Number!= 0)
            {
                //Add the differnet elements to the list with the corresponding number of characters
                for (int i = 0; i < campaing_Element_Number; i++)
                {
                    int campaing_ID = Convert.ToInt32(campaing_DataSet.Tables[0].Rows[i][0]);
                    string campaing_name = campaing_DataSet.Tables[0].Rows[i][1].ToString();
                    DataSet Character_Id_By_Campaing = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, campaing_ID);
                    int number_of_characters = Character_Id_By_Campaing.Tables[0].Rows.Count;
                    //Add elements to the lists
                    Campaing_Lists.Rows.Add(campaing_ID, campaing_name, number_of_characters);
                }
            }
            else
            {
                Campaing_Lists.Rows.Add("-1", "No characters found");
                Campaing_Lists.Enabled = false;

            }
        }



        private void Add_Campaing_Click(object sender, EventArgs e)
        {
            //Change to the create campaing form
            this.Hide();
            Create_Campaing create_campaing = new Create_Campaing();
            create_campaing.ShowDialog();
            this.Close();
        }

     

        private void Campaing_Lists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selected_row_index != -1)
            {
                // save the selection and open the encounters created for that campaing. 
                this.Hide();
                Campaing_View next = new Campaing_View();
                next.ShowDialog();
                this.Close();
            }

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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu back = new Main_Menu();
            back.ShowDialog();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Pop up a message to warn the user, if the user clicks ok proceed
            if (MessageBox.Show(
              "Once is deleted you won't be able to recover it. Are you sure you want to preceed?",
               "Delete",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Errase all character's related information that correspond to the campaign
                DataSet character_ID_set = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, selected_Campaing_ID);

                for(int i = 0; i < character_ID_set.Tables[0].Rows.Count; i++)
                {
                    int character_ID = Convert.ToInt32(character_ID_set.Tables[0].Rows[i][0].ToString());
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_INI_COUNT_CHA, character_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_STATUS_USING_CHARACTER_ID, character_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CLASS_FROM_CHARACTER, character_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CHARCTER, character_ID);
                }

                //Errase all character's related information that correspond to the campaign
                DataSet encounter_ID_set = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET__ENCOUNTER_ID_FROM_CAMPAIGN_ID, selected_Campaing_ID);
             

                for (int i = 0; i < encounter_ID_set.Tables[0].Rows.Count; i++)
                {
                    int encounter_ID = Convert.ToInt32(character_ID_set.Tables[0].Rows[i][0].ToString());
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_MONSTER_LIST, encounter_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_INI_COUNT, encounter_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_STATUS_USING_ECNOUNTER_ID, encounter_ID);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_ENCOUNTER, encounter_ID);
                }
            
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CAMPAIGN, selected_Campaing_ID);
                if (Campaing_Lists.Rows.Count != 0)
                {
                    Campaing_Lists.Rows.RemoveAt(selected_row_index);
                }

            }

            if (Campaing_Lists.Rows.Count == 0)
            {
                Campaing_Lists.Rows.Add(-1, "No campaign found");
                Campaing_Lists.Enabled = false;
            }
        }

        private void Campaing_Lists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected_row_index = e.RowIndex;
                selected_Campaing_ID = Convert.ToInt32(Campaing_Lists.Rows[selected_row_index].Cells[Id.Index].Value.ToString());
            }
            
        }
    }

  
    
}
