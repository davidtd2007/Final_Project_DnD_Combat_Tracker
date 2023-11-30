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
    public partial class Class_Update : Form
    {
        public Class_Update()
        {
            InitializeComponent();
        }

        private void Class_Update_Load(object sender, EventArgs e)
        {
       
            int class_Id =Update_Character.class_Id_Selected;
            DataSet class_info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CLASS_INFO_FROM_ID,class_Id);
          
            Class.Text = class_info.Tables[0].Rows[0][1].ToString();
            Subclass.Text= class_info.Tables[0].Rows[0][4].ToString();
            Level.Text= class_info.Tables[0].Rows[0][2].ToString(); ;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Class.Text != "" && Level.Text != "")
            {

                int character_level = Convert.ToInt32(Level.Text); ;
                if (Create_Character.selected_Character_Id != -1)
                {
                    DataSet Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL_AND_ID, Character_List.selected_Character_Id);
                    int number_of_classes = Level_Info.Tables[0].Rows.Count;


                    //get the total level number
                    for (int i = 0; i < number_of_classes; i++)
                    {
                        if (Convert.ToInt32(Level_Info.Tables[0].Rows[i][0]) != Update_Character.class_Id_Selected) {
                            character_level = character_level + Convert.ToInt32(Level_Info.Tables[0].Rows[i][1]);
                        }
                        
                    }
                }
                //Only create the class if the character has a level lower than 20 since it's the maximun level
                if (character_level <= 20)
                {
                    
                    int class_ID = Update_Character.class_Id_Selected;

                    DBConnection.getInstanceOfDBConnection().updateclass(Constants.UPDATE_CLASS_INFO, Class.Text, Subclass.Text, Convert.ToInt32(Level.Text), class_ID);
                    this.Hide();
                    Update_Character done = new Update_Character();
                    done.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The level of the character is too hight, the levels of all classes combined must be 20 or less", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Class name and Level)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dice_Click(object sender, EventArgs e)
        {
            Dice_Roll dice = new Dice_Roll();
            dice.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Character back = new Update_Character();
            back.ShowDialog();
            this.Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {

            Rules_List rule = new Rules_List();
            rule.ShowDialog();
        }
    }
}
