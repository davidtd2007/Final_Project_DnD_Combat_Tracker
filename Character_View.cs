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
    public partial class Character_View : Form
    {

        int selected_row_ID = 0;
        int selected_class_ID;
        public Character_View()
        {
            InitializeComponent();
        }

        private void Character_View_Load(object sender, EventArgs e)
        {
            int id = Character_List.selected_Character_Id;


            DataSet character_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_INFO_FROM_ID, id);
            //Get all the data necesary and place it into the different text boxes to be displayed

            title.Text = character_Info.Tables[0].Rows[0][5].ToString();
            Specie.Text = character_Info.Tables[0].Rows[0][1].ToString();
            IB.Text = character_Info.Tables[0].Rows[0][3].ToString();
            HP.Text = character_Info.Tables[0].Rows[0][6].ToString();
            AC.Text = character_Info.Tables[0].Rows[0][4].ToString();

            DataSet Class_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_CLASS_FROM_CHARACTER_ID, id);


            int number_of_Classes = Class_Info.Tables[0].Rows.Count;
            int character_Level = 0;

            //add all the classes and subclasses to the list
            for (int i = 0; i < number_of_Classes; i++)
            {
                int class_ID = Convert.ToInt32(Class_Info.Tables[0].Rows[i][0].ToString());
                string class_Name = Class_Info.Tables[0].Rows[i][1].ToString();

                //A character may not have a subclass
                string subclass;
                if (Class_Info.Tables[0].Rows[i][4].ToString() != "")
                {
                    subclass = Class_Info.Tables[0].Rows[i][4].ToString();
                }
                else
                {
                    subclass = "None";
                }

                int class_level = Convert.ToInt32(Class_Info.Tables[0].Rows[i][2].ToString());
                character_Level = character_Level + class_level;
                Class_List.Rows.Add(class_ID, class_Name, subclass, class_level);
            }

            character_level.Text = character_Level.ToString();
            selected_class_ID = Convert.ToInt32(Class_List.Rows[0].Cells[Id.Index].Value.ToString());
        }




        //Update button
        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Character update = new Update_Character();
            update.ShowDialog();
            this.Close();

        }

        private void dice_Click(object sender, EventArgs e)
        {
            Dice_Roll dice = new Dice_Roll();
            dice.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Character_List back = new Character_List();
            back.ShowDialog();
            this.Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Rules_List rule = new Rules_List();
            rule.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Class_List.Rows.Count > 1)
            {
                //Pop up a message to warn the user, if the user clicks ok proceed
                if (MessageBox.Show(
                  "Once is deleted you won't be able to recover it. Are you sure you want to preceed?",
                   "Delete",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int newcharacter_level = Convert.ToInt32(character_level.Text) - Convert.ToInt32(Class_List.Rows[selected_row_ID].Cells[Class_Level.Index].Value.ToString());
                    character_level.Text = newcharacter_level.ToString();
                    DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.DELETE_CLASS, selected_class_ID);
                
                    if (Class_List.Rows.Count != 0)
                    {
                        Class_List.Rows.RemoveAt(selected_row_ID);
                    }

                }


            }
            else
            {
                MessageBox.Show("A character needs at least one class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Class_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row_ID = e.RowIndex;
            selected_class_ID = Convert.ToInt32(Class_List.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
        }
    }
}
