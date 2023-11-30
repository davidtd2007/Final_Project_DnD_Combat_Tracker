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
    public partial class Update_Character : Form
    {
        public static int class_Id_Selected;
        public Update_Character()
        {
            InitializeComponent();
        }


        private void Update_Character_Load(object sender, EventArgs e)
        {
            int character_Id = Character_List.selected_Character_Id;

            DataSet character_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_INFO_FROM_ID, character_Id);
            this.name_Text.Text = character_Info.Tables[0].Rows[0][5].ToString();

            //Get all the data necesary and place it into the different text boxes to be displayed
            Specie_text.Text = character_Info.Tables[0].Rows[0][1].ToString();
            IB_text.Text = character_Info.Tables[0].Rows[0][3].ToString();
            HP_text.Text = character_Info.Tables[0].Rows[0][6].ToString();
            AC_text.Text = character_Info.Tables[0].Rows[0][4].ToString();

            DataSet Class_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CHARACTER_CLASS_FROM_CHARACTER_ID, character_Id);

            int number_of_Classes = Class_Info.Tables[0].Rows.Count;
            

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
                Class_List.Rows.Add(class_ID, class_Name, subclass, class_level);
            }

            

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (name_Text.Text != "" && IB_text.Text != "" && AC_text.Text != "" && HP_text.Text != "" && Specie_text.Text != "")
            {
                string name = name_Text.Text;
                string specie = Specie_text.Text;
                int IB = Convert.ToInt32(IB_text.Text);
                int HP = Convert.ToInt32(HP_text.Text);
                int AC = Convert.ToInt32(AC_text.Text);
                DBConnection.getInstanceOfDBConnection().updatecharcter(Constants.UPDATE_CHARACTER_INFO, name, HP, AC, IB, specie, Character_List.selected_Character_Id);
                this.Hide();
               Character_View done = new Character_View();
                done.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name, HP,IB,AC and Specie)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void I_B_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HP_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AC_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

       

        private void Class_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (name_Text.Text != "" && IB_text.Text != "" && AC_text.Text != "" && HP_text.Text != "" && Specie_text.Text != "")
            {
                string name = name_Text.Text;
                string specie = Specie_text.Text;
                int IB = Convert.ToInt32(IB_text.Text);
                int HP = Convert.ToInt32(HP_text.Text);
                int AC = Convert.ToInt32(AC_text.Text);
                DBConnection.getInstanceOfDBConnection().updatecharcter(Constants.UPDATE_CHARACTER_INFO, name, HP, AC, IB, specie, Character_List.selected_Character_Id);
                class_Id_Selected = Convert.ToInt32(Class_List.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Hide();
                Class_Update update_class = new Class_Update();
                update_class.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name, HP,IB,AC and Specie)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Class_Click(object sender, EventArgs e)
        {

            if (name_Text.Text != "" && IB_text.Text != "" && AC_text.Text != "" && HP_text.Text != "" && Specie_text.Text != "")
            {
                string name = name_Text.Text;
                string specie = Specie_text.Text;
                int IB = Convert.ToInt32(IB_text.Text);
                int HP = Convert.ToInt32(HP_text.Text);
                int AC = Convert.ToInt32(AC_text.Text);
                DBConnection.getInstanceOfDBConnection().updatecharcter(Constants.UPDATE_CHARACTER_INFO, name, HP, AC, IB, specie, Character_List.selected_Character_Id); 
                this.Hide();
                Create_Class_From_Update create_Class = new Create_Class_From_Update();
                create_Class.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name, HP,IB,AC and Specie)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Character_View back = new Character_View();
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
    }
}
