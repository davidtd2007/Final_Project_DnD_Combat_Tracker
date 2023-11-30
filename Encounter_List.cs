using System;
using System.Data;
using System.Windows.Forms;

namespace dnd
{
    public partial class Encounter_List : Form
    {
        public static int selected_Encounter_ID;
        public static int selected_row_index = 0;
        
        public Encounter_List()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Encounter create = new Create_Encounter();
            create.ShowDialog();
            this.Close();


        }

        private void Encounter_List_Load(object sender, EventArgs e)
        {
            int campaing_Id = Campaing_For_Encounter.selected_Campaing_ID;

            string campaing_Name = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CAMPAING_NAME_BY_ID, campaing_Id).Tables[0].Rows[0][0].ToString();

            Title.Text = "Ecounters for " + campaing_Name;


            DataSet Encounters = DBConnection.getInstanceOfDBConnection().getDATAFromCampaingID(Constants.GET_ENCOUNTER_NAME__AND_DIFFICULTY_AND_ID_FROM_CAMPAING_ID, campaing_Id);

            int number_of_encounters = Encounters.Tables[0].Rows.Count;
            if (number_of_encounters != 0)
            {
                //Get all the character names from the list of Campaing_Characters and list them.
                for (int i = 0; i < number_of_encounters; i++)
                {
                    //Add elements to the list
                    encounter_lis.Rows.Add(Encounters.Tables[0].Rows[i][0], Encounters.Tables[0].Rows[i][1], Encounters.Tables[0].Rows[i][2]);

                }
            }
            else
            {
                encounter_lis.Rows.Add(-1, "No Encounters found");
                encounter_lis.Enabled = false;
            }


        }

        private void encounter_lis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the user double clicks in a blank space of the list avoid a crushing
            if (e.RowIndex != -1)
            {

                //Save the encounter we are runing and change the view
                
                this.Hide();
                Encounter_Per_Se en = new Encounter_Per_Se();
                this.Close();
                en.ShowDialog();

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Campaing_For_Encounter back = new Campaing_For_Encounter();
            back.ShowDialog();
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

        private void delete_Click(object sender, EventArgs e)
        {
            //Pop up a message to warn the user, if the user clicks ok proceed
            if(MessageBox.Show(
              "Once is deleted you won't be able to recover it. Are you sure you want to preceed?",
               "Delete",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning)== DialogResult.OK)
            {
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_MONSTER_LIST,selected_Encounter_ID);
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_INI_COUNT, selected_Encounter_ID);
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_STATUS_USING_ECNOUNTER_ID, selected_Encounter_ID);
                DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_ENCOUNTER, selected_Encounter_ID);
                if (encounter_lis.Rows.Count != 0)
                {
                    encounter_lis.Rows.RemoveAt(selected_row_index);
                }
                
            }

            if (encounter_lis.Rows.Count == 0)
            {
                encounter_lis.Rows.Add(-1, "No encounters found");
                encounter_lis.Enabled = false;
            }
            
        }

        private void encounter_lis_CellClick(object sender, DataGridViewCellEventArgs e)
        {// save the encounter ID to delete or to start the encounter
            if (e.RowIndex !=-1)
            {
                selected_Encounter_ID = Convert.ToInt32(encounter_lis.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                selected_row_index = e.RowIndex;
            }
           
        }
    }
}
