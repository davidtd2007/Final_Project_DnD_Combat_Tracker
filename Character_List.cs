using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd
{
    public partial class Character_List : Form
    {

        public static int selected_Character_Id;
        private static int selected_row_index;
        public Character_List()
        {
            InitializeComponent();
        }

        private void Character_List_Load(object sender, EventArgs e)
        {
            int campaing_ID = Characters_By_Campaing.selected_campaing_Id;
            string campaing_Name = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CAMPAING_NAME_BY_ID, campaing_ID).Tables[0].Rows[0][0].ToString();
            //Name on the title
            Title.Text = campaing_Name + "'s Characters";


            //Get the characters from that campaing
            DataSet Character_Id_By_Campaing = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, campaing_ID);
            int number_of_characters = Character_Id_By_Campaing.Tables[0].Rows.Count;
            if (number_of_characters != 0)
            {
                //Get all the character names from the list of Campaing_Characters and list them.
                for (int i = 0; i < number_of_characters; i++)
                {
                    int character_Id = Convert.ToInt32(Character_Id_By_Campaing.Tables[0].Rows[i][0].ToString());
                    string character_Name = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_NAME_FROM_ID, character_Id).Tables[0].Rows[0][0].ToString();
                    int character_Level = 0;

                    DataSet character_Levels = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, character_Id);
                    for (int j = 0; j < character_Levels.Tables[0].Rows.Count; j++)
                    {
                        character_Level = character_Level + Convert.ToInt32(character_Levels.Tables[0].Rows[j][0].ToString());
                    }

                    Character_Lists.Rows.Add(character_Id, character_Name, character_Level);

                }

            }
            else
            {
                Character_Lists.Rows.Add("-1", "No Characters Found");
                Character_Lists.Enabled = false;
            }
        }



        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Character Character_creaion = new Create_Character();
            Character_creaion.ShowDialog();
            this.Close();
        }





        private void Campaing_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected_Character_Id = Convert.ToInt32(Character_Lists.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                //display the information of the charcter selected
                this.Hide();
                Character_View next = new Character_View();
                next.ShowDialog();
                this.Close();
            }

        }

        private void dice_Click(object sender, EventArgs e)
        {
            Dice_Roll dice = new Dice_Roll();
            dice.ShowDialog();
        }

        private void rules_Click(object sender, EventArgs e)
        {
            Rules_List rule = new Rules_List();
            rule.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Characters_By_Campaing back = new Characters_By_Campaing();
            back.ShowDialog();
            this.Close();
        }

        private void Character_Lists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected_Character_Id = Convert.ToInt32(Character_Lists.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                selected_row_index = e.RowIndex;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Character_Lists.Rows.Count > 1)
            {
                //Pop up a message to warn the user, if the user clicks ok proceed
                if (MessageBox.Show(
                  "Once is deleted you won't be able to recover it. Are you sure you want to preceed?",
                   "Delete",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_INI_COUNT_CHA, selected_Character_Id);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_STATUS_USING_CHARACTER_ID, selected_Character_Id);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CLASS_FROM_CHARACTER, selected_Character_Id);
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CHARCTER, selected_Character_Id);

                    if (Character_Lists.Rows.Count != 0)
                    {
                        Character_Lists.Rows.RemoveAt(selected_row_index);
                    }

                }

                if (Character_Lists.Rows.Count == 0)
                {

                    Character_Lists.Rows.Add(-1, "No encounters found");
                    Character_Lists.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("A campaign needs at least a charcter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
