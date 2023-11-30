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
    public partial class Create_Character : Form
    {
        private static int I_B;
        private static int AC;
        private static int HP;
        private static string specie;
        private static string name;
        private static bool save_character = false;
        public Create_Character()
        {
            InitializeComponent();
        }


        public static int selected_Character_Id = -1;
        private void next_Click(object sender, EventArgs e)
        {

            //Check the fields are covered

            if (Name_Text.Text != "" && I_B_text.Text.ToString() != "" && AC_text.Text.ToString() != "" && HP_text.Text.ToString() != "" && Specie_text.Text.ToString() != "")
            {
                name = this.Name_Text.Text;
                specie = this.Specie_text.Text;
                I_B = Convert.ToInt32(this.I_B_text.Text);
                HP = Convert.ToInt32(this.HP_text.Text);
                AC = Convert.ToInt32(this.AC_text.Text);
                save_character = true;
                this.Hide();
                Create_Character_Class next = new Create_Character_Class();
                next.ShowDialog();
            }
            else
            {
                //Show error window if the name is not in place
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue(Name, Specie, IB, AC and HP)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Allow only int values in the field
      
        private void I_B_text_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }



        }



        //Allow only int values in the field
        private void HP_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        //Allow only int values in the field
        private void AC_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void Create_Character_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (save_character)
            {


                //save the character
                int campaing_Id = Characters_By_Campaing.selected_campaing_Id;
                DBConnection.getInstanceOfDBConnection().saveNewCharacter(Constants.SAVE_NEW_CHARACTER, name, AC, I_B, HP, specie, campaing_Id);

                DataSet characters = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_ID_FROM_CAMPAING_ID, campaing_Id);
                int last_Character = characters.Tables[0].Rows.Count - 1;
                //save the id of the character for the class creation
                selected_Character_Id = Convert.ToInt32(characters.Tables[0].Rows[last_Character][0].ToString());
                save_character = false;



            }

        }

        private void Create_Character_Load(object sender, EventArgs e)
        {
            selected_Character_Id = -1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Character_List back = new Character_List();
            back.ShowDialog();
            this.Close();
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
    }
}
