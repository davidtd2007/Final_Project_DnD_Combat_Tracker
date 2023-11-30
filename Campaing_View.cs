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
    public partial class Campaing_View : Form
    {
        public Campaing_View()
        {
            InitializeComponent();
        }



        private void Campaing_View_Load(object sender, EventArgs e)
        {
            int campaing_ID = Campaing_Menu_List.selected_Campaing_ID;
            DataSet campaing_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CAMPAING_INFO_FROM_ID, campaing_ID);
            string name = campaing_Info.Tables[0].Rows[0][1].ToString();

            //Write the name of the campaing and the description in the label and the textbox
            Campaing_Name.Text = name;
            //Get campaing description
            Campaing_Description.Text = campaing_Info.Tables[0].Rows[0][2].ToString();



            //Get the characters from that campaing
            DataSet campaing_Characters = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_NAME_AND_ID_FROM_CAMPAING_ID, campaing_ID);
            int number_of_characters = campaing_Characters.Tables[0].Rows.Count;

            //Get all the character names from the list of Campaing_Characters and list them.
            if (number_of_characters != 0)
            {
                for (int i = 0; i < number_of_characters; i++)
                {
                    int character_Id =Convert.ToInt32(campaing_Characters.Tables[0].Rows[i][0].ToString());
                    string character_Name = campaing_Characters.Tables[0].Rows[i][1].ToString();
                    DataSet Class_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_CLASS_FROM_CHARACTER_ID, character_Id);
                    int number_of_Classes = Class_Info.Tables[0].Rows.Count;
                    int character_Level = 0;

                    //add all the classes and subclasses to the list
                    for (int j = 0; j < number_of_Classes; j++)
                    {
                        int class_level = Convert.ToInt32(Class_Info.Tables[0].Rows[j][2].ToString());
                        character_Level = character_Level+class_level;
                    }
                    Characters_Lists.Rows.Add(character_Id,character_Name,character_Level);
                }
            }
            else
            {
                Characters_Lists.Rows.Add("-1", "No characters found");
                Characters_Lists.Enabled = false;
              
            }

        }


        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Campaing update = new Update_Campaing();
            update.ShowDialog();
            this.Close();
        }


  

        private void Characters_Lists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Character_List.selected_Character_Id = Convert.ToInt32(Characters_Lists.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                Characters_By_Campaing.selected_campaing_Id = Campaing_Menu_List.selected_Campaing_ID; 
                this.Hide();
                Character_View view = new Character_View();
                view.ShowDialog();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //Back buttom
            this.Hide();
            Campaing_Menu_List main = new Campaing_Menu_List();
            main.ShowDialog();
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
