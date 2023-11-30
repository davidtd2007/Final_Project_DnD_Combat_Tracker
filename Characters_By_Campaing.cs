using System;
using System.Data;
using System.Windows.Forms;

namespace dnd
{
    public partial class Characters_By_Campaing : Form
    {
        //Save the name of the campaing who's characters we are working on
        public static int selected_campaing_Id;
        public Characters_By_Campaing()
        {
            InitializeComponent();
        }

        private void Characters_By_Campaing_Load(object sender, EventArgs e)
        {
            //display data from campaing to the list

            //get the name of the campaing and how many are there
            DataSet campaing_DataSet = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_CAMPAING);
            int number_Of_Campaing = campaing_DataSet.Tables[0].Rows.Count;

            if (number_Of_Campaing != 0)
            {
                //Add the different campaings to the list with the corresponding number of characters
                for (int i = 0; i < number_Of_Campaing; i++)
                {
                    int campaing_ID = Convert.ToInt32(campaing_DataSet.Tables[0].Rows[i][0].ToString());
                    string campaing_Name = campaing_DataSet.Tables[0].Rows[i][1].ToString();

                    DataSet Campaing_NumberOfCharacters = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, campaing_ID);
                    int number_of_characters = Campaing_NumberOfCharacters.Tables[0].Rows.Count;
                    //Add elements to the datagrid
                    Campaing_List.Rows.Add(campaing_ID, campaing_Name, number_of_characters);
                }
            }
            else
            {
                Campaing_List.Rows.Add(-1,"No campaings found");
                Campaing_List.Enabled = false;

            }
            
        }




       

        private void Campaing_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //save the name of the campaing we are working on
                selected_campaing_Id = Convert.ToInt32(Campaing_List.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                //change from the menu to the Campaing View
                this.Hide();
                Character_List character_List = new Character_List();
                character_List.ShowDialog();
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu go_Back = new Main_Menu();
            go_Back.ShowDialog();
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
