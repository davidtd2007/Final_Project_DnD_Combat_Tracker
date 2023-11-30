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
    public partial class Create_Campaing : Form
    {
        public Create_Campaing()
        {
            InitializeComponent();
        }

        //save buttom
        private void button1_Click(object sender, EventArgs e)
        {

            string name = name_text.Text;
            string description = description_text.Text;

            //Check the name has actually being written

            if (name != "")
            {

                //save the campaing and close the form
                DBConnection.getInstanceOfDBConnection().saveNewCampaing(Constants.SAVE_NEW_CAMPAING, name, description);

                this.Hide();
                Campaing_Menu_List campaing_Menu_List = new Campaing_Menu_List();
                campaing_Menu_List.ShowDialog();
                this.Close();

            }
            else
            {
                //Show error window if the name is not in place
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Campaing_Menu_List campaing_Menu_List = new Campaing_Menu_List();
            campaing_Menu_List.ShowDialog();
            this.Close();
        }

        private void dice_Click_1(object sender, EventArgs e)
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
