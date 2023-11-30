using System;
using System.Data;
using System.Windows.Forms;

namespace dnd
{
    public partial class Create_Class_From_Update : Form
    {
        public Create_Class_From_Update()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        { //All characters must have a subclass from level 3 on 
            if (Convert.ToInt32(Level.Text) >= 3 && Subclass.Text == "")
            {
                //Show error if there is infrmation missing
                MessageBox.Show("All charcters must have a subclass from level 3 on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //All characters must have a subclass from level 3 on 
                if (Convert.ToInt32(Level.Text) >= 3)
                {


                    if (Class.Text != "" && Level.Text != "")
                    {  //get the current total level of the character
                        int character_level = 0;

                        DataSet Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, Character_List.selected_Character_Id);
                        int number_of_classes = Level_Info.Tables[0].Rows.Count;

                        //add the level of the new class to the current total of the character
                        character_level = character_level + Convert.ToInt32(Level.Text);

                        //get the total level number
                        for (int i = 0; i < number_of_classes; i++)
                        {

                            character_level = character_level + Convert.ToInt32(Level_Info.Tables[0].Rows[i][0]);
                        }

                        //Only create the class if the character has a level lower than 20 since it's the maximun level
                        if (character_level <= 20)
                        {

                            //save to db and return to the character list
                            DBConnection.getInstanceOfDBConnection().saveNewClass(Constants.SAVE_NEW_CLASS, Class.Text, Convert.ToInt32(Level.Text), Character_List.selected_Character_Id, Subclass.Text);


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
                else
                {
                    //Show error if there is infrmation missing
                    MessageBox.Show("All charcters must have a subclass from level 3 on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                //All characters must have a subclass from level 3 on 
                if (Convert.ToInt32(Level.Text) >= 3)
                {


                    if (Class.Text != "" && Level.Text != "")
                    {  //get the current total level of the character
                        int character_level = 0;

                        DataSet Level_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_LEVEL, Character_List.selected_Character_Id);
                        int number_of_classes = Level_Info.Tables[0].Rows.Count;

                        //add the level of the new class to the current total of the character
                        character_level = character_level + Convert.ToInt32(Level.Text);

                        //get the total level number
                        for (int i = 0; i < number_of_classes; i++)
                        {

                            character_level = character_level + Convert.ToInt32(Level_Info.Tables[0].Rows[i][0]);
                        }

                        //Only create the class if the character has a level lower than 20 since it's the maximun level
                        if (character_level <= 20)
                        {

                            //save to db and return to the character list
                            DBConnection.getInstanceOfDBConnection().saveNewClass(Constants.SAVE_NEW_CLASS, Class.Text, Convert.ToInt32(Level.Text), Character_List.selected_Character_Id, Subclass.Text);


                            //Go back to the Character View
                            //Open a new form for multiclassing
                            this.Hide();
                            Create_Character_Class other = new Create_Character_Class();
                            other.ShowDialog();
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
                else
                {
                    //Show error if there is infrmation missing
                    MessageBox.Show("All charcters must have a subclass from level 3 on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       
        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Character back = new Update_Character();
            back.ShowDialog();
            this.Close();
        }
    }
}
