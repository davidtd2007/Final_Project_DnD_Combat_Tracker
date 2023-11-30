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
    public partial class Rule_Explanation : Form
    {
        public Rule_Explanation()
        {
            InitializeComponent();
        }

        private void Rule_Explanation_Load(object sender, EventArgs e)
        {
            switch (Rules_List.rule_type)
            {
                case "Condition":
                    DataSet conditions = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_CONDITON_NAME_AND_DESCRIPTION, Rules_List.rule_Id);
                    description.Text = conditions.Tables[0].Rows[0][1].ToString();
                    rule_name.Text = conditions.Tables[0].Rows[0][0].ToString();
                    break;
                case "New":
                    description.Text = "Welcome to this D&D combat tracker!!\n" +
                        "In this menu we will help you to better understand how this tracker workds\n Here are some things you shoudl now: \n" +
                        "Your first stop is to create your campaign, then introduce your characters and monsters and you are ready to create your encounter \n" +
                        "You can access this menu at any time with the '?' icon on each page \n" +
                        "You can access the dice roller at any time using the dice shaped button \n" +
                        "The conditions errased using the 'Delete' button won't come back... So think twice before doing it!"+
                        "To naviage throught the lists, please double click on them\n" +
                        "When creating a new charcter for a campaign the encounters wont be updated \n" +
                        "Click on a monster entry to display its statblock";
                    rule_name.Text = "WELCOME";
                    break;

                case "Rule":
                    DataSet rule = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_RULE_NAME_AND_DESCRIPTION, Rules_List.rule_Id);
                    description.Text = rule.Tables[0].Rows[0][1].ToString();
                    rule_name.Text = rule.Tables[0].Rows[0][0].ToString();
                    break;
            }
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules_List back = new Rules_List();
            back.ShowDialog();
            this.Close();
        }
    }
}
