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
    public partial class Create_Character_Class : Form
    {
        public Create_Character_Class()
        {
            InitializeComponent();
        }

        //Done buttom
        private void Done_Click(object sender, EventArgs e)
        {
            //All characters must have a subclass from level 3 on 
            if (Convert.ToInt32(Level.Text) >= 3 && Subclass.Text == "")
            {
                //Show error if there is infrmation missing
                MessageBox.Show("All charcters must have a subclass from level 3 on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                if (Class.Text != "" && Level.Text != "")
                {
                    //get the current total level of the character
                    int character_level = Convert.ToInt32(Level.Text); ;
                    if (Create_Character.selected_Character_Id != -1)
                    {


                        DataSet Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, Create_Character.selected_Character_Id);
                        int number_of_classes = Level_Info.Tables[0].Rows.Count;


                        //get the total level number
                        for (int i = 0; i < number_of_classes; i++)
                        {

                            character_level = character_level + Convert.ToInt32(Level_Info.Tables[0].Rows[i][0]);
                        }
                    }
                    //Only create the class if the character has a level lower than 20 since it's the maximun level
                    if (character_level <= 20)
                    {
                        if (Create_Character.selected_Character_Id == -1)
                        {
                            for (int i = 0; i < Application.OpenForms.Count; i++)
                            {
                                if (Application.OpenForms[i].Name == "Create_Character")
                                {
                                    Application.OpenForms[i].Close();

                                }
                            }
                        }
                        //save to db and return to the character list
                        DBConnection.getInstanceOfDBConnection().saveNewClass(Constants.SAVE_NEW_CLASS, Class.Text, Convert.ToInt32(Level.Text), Create_Character.selected_Character_Id, Subclass.Text);


                        //Go back to the Character View
                        this.Hide();
                        Character_List back = new Character_List();
                        back.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        //Show error message if the level is too hight
                        MessageBox.Show("The level of the character is too hight, the levels of all classes combined must be 20 or less", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    //Show error if there is infrmation missing
                    MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Class name and Level)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }




        }

        // Level textbox
        //Allow only integers
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Add_Class_Click(object sender, EventArgs e)
        {
           
            //All characters must have a subclass from level 3 on 
            if (Convert.ToInt32(Level.Text) >= 3 && Subclass.Text == "")
            {
                //Show error if there is infrmation missing
                MessageBox.Show("All charcters must have a subclass from level 3 on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Class.Text != "" && Level.Text != "")
                {  //get the current total level of the character
                    int character_level = 0;

                    DataSet Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, Create_Character.selected_Character_Id);
                    int number_of_classes = Level_Info.Tables[0].Rows.Count;
                    //add the level of the new class to the current total of the character
                    character_level = character_level + Convert.ToInt32(Level.Text);

                    //get the total level number
                    for (int i = 0; i < number_of_classes; i++)
                    {
                        character_level = character_level + Convert.ToInt32(Level_Info.Tables[0].Rows[i][0]);
                    }

                    //Only create the class if the character has a level lower than 20 since it's the maximun level
                    if (character_level < 20)
                    {
                        if (Create_Character.selected_Character_Id == -1)
                        {
                            for (int i = 0; i < Application.OpenForms.Count; i++)
                            {
                                if (Application.OpenForms[i].Name == "Create_Character")
                                {
                                    Application.OpenForms[i].Close();
                                }
                            }
                        }

                        //save to db and return to the character list
                        DBConnection.getInstanceOfDBConnection().saveNewClass(Constants.SAVE_NEW_CLASS, Class.Text, Convert.ToInt32(Level.Text),
                        Create_Character.selected_Character_Id, Subclass.Text);

                        //Open a new form for multiclassing
                        this.Hide();
                        Create_Character_Class back = new Create_Character_Class();
                        back.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        //Show error message if the level is too hight
                        MessageBox.Show("The level of the character is too hight, the levels of all classes combined must be 20 or less", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    //Show error if there is infrmation missing
                    MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Class name and Level)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Character back = new Create_Character();
            back.ShowDialog();
            this.Close();
        }
    }
}
