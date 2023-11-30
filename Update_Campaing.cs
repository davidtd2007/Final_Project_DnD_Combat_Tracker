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
    public partial class Update_Campaing : Form
    {
        public Update_Campaing()
        {
            InitializeComponent();
        }

        private void Update_Campaing_Load(object sender, EventArgs e)
        {
           int campaing_Id = Campaing_Menu_List.selected_Campaing_ID;
            DataSet campaing_Info= DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CAMPAING_INFO_FROM_ID, campaing_Id);
            //Write the name of the campaing and the description in the label and the textbox
            this.name.Text = campaing_Info.Tables[0].Rows[0][1].ToString();
            //Get campaing description
            Description.Text = campaing_Info.Tables[0].Rows[0][2].ToString();
        }

      

       

        private void Update_Click(object sender, EventArgs e)
        {
            int id = Campaing_Menu_List.selected_Campaing_ID;
            string name = this.name.Text;
            string description = Description.Text;

            //Check the name has actually being written

            if (name != "")
            {
                    //update the campaing and close the form
                   DBConnection.getInstanceOfDBConnection().updatecampaing(Constants.UPDATE_CAMPAING_INFO, name, description,id);

                    this.Hide();
                    Campaing_View view = new Campaing_View();
                    view.ShowDialog();
                    this.Close();
             

            }
            else
            {
                //Show error window if the name is not in place
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Name)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Campaing_View view = new Campaing_View();
            view.ShowDialog();
            this.Close();
        }
    }
}
