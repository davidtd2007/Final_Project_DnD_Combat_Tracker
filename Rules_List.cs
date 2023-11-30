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
    public partial class Rules_List : Form
    {
        public static string rule_type;
        public static int rule_Id;

        public Rules_List()
        {
            InitializeComponent();
        }

        private void Rules_List_Load(object sender, EventArgs e)
        {
            rule_type = "Rule";
            Data.Rows.Clear();

            DataSet Rules = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_RULE_ID_AND_NAME);

            for (int i = 0; i < Rules.Tables[0].Rows.Count; i++)
            {
                Data.Rows.Add(Rules.Tables[0].Rows[i][0].ToString(), Rules.Tables[0].Rows[i][1].ToString());
            }
        }

        private void New_User_Click(object sender, EventArgs e)
        {
            rule_type = "New";
            this.Hide();
            this.Close();
            Rule_Explanation rule = new Rule_Explanation();
            rule.ShowDialog();

        }

        private void Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                rule_Id = Convert.ToInt32(Data.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());
                this.Hide();
                this.Close();
                Rule_Explanation next = new Rule_Explanation();
                next.ShowDialog();
            }
        }

        private void Conditions_Click(object sender, EventArgs e)
        {
            Data.Rows.Clear();
            rule_type = "Condition";
            DataSet conditions = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_CONDITON_ID_AND_NAME);

            for (int i = 0; i< conditions.Tables[0].Rows.Count;i++)
            {
                Data.Rows.Add(conditions.Tables[0].Rows[i][0].ToString(), conditions.Tables[0].Rows[i][1].ToString());
            }
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            rule_type = "Rule";
            Data.Rows.Clear();
           
            DataSet Rules = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_RULE_ID_AND_NAME);

            for (int i = 0; i < Rules.Tables[0].Rows.Count; i++)
            {
                Data.Rows.Add(Rules.Tables[0].Rows[i][0].ToString(), Rules.Tables[0].Rows[i][1].ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu back = new Main_Menu();
            back.ShowDialog();
            this.Close();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
