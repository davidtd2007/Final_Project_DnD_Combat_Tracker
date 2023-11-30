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
    public partial class Condition_Creation : Form
    {

        
        public Condition_Creation()
        {
            InitializeComponent();
        }

        private void Condition_Creation_Load(object sender, EventArgs e)
        {
            //Create the interface for the conddition creation
            DataSet Condition_Collection = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_CONDITON_NAMES);
            List<String> Condition_List = new List<string>();

            for (int i =0; i< Condition_Collection.Tables[0].Rows.Count; i++)
            {
                Condition_List.Add(Condition_Collection.Tables[0].Rows[i][0].ToString());
            }
            Conditions.DataSource = Condition_List;

            Duration_Type.DataSource = new String[] {"Minutes","Rounds", "Turns","Until the start of its next turn", "Until the end of its next turn","Until Dismissed" };

            Creature.Text = "Creature affected: " + Encounter_Per_Se.select_Creature_Name;
        }

        private void Duration_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // These time types don't use a numeber for timing them so the box is disable
            if(Duration_Type.SelectedItem.ToString() == "Until the start of its next turn" || Duration_Type.SelectedItem.ToString() == "Until the end of its next turn"||Duration_Type.SelectedItem.ToString() == "Until Dismissed")
            {
                Duration.Text = "";
                Duration.Enabled = false;
            }
            else
            {
                Duration.Enabled = true;
            }
            
        }

        private void Duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

        private void Save_Click(object sender, EventArgs e)
        {
            if (Duration.Text != "" || Duration_Type.SelectedItem.ToString() == "Until the start of its next turn"  || Duration_Type.SelectedItem.ToString() == "Until the end of its next turn" || Duration_Type.SelectedItem.ToString() == "Until Dismissed")
            {
                this.Hide();
                int condition_id = Convert.ToInt32(DBConnection.getInstanceOfDBConnection().getDATAfromName(Constants.GET_CONDITON_ID_FROM_NAME, Conditions.SelectedItem.ToString()).Tables[0].Rows[0][0].ToString());
                
                if (Duration_Type.SelectedItem.ToString() == "Until the start of its next turn" || Duration_Type.SelectedItem.ToString() == "Until the end of its next turn" || Duration_Type.SelectedItem.ToString() == "Until Dismissed")
                {
                    Duration.Text = "0";

                }
                //Each round is 6 seconds, whitch means that 1 minute is 10 rounds
                if (Duration_Type.SelectedItem.ToString() == "Minutes")
                {
                    Duration.Text = (Convert.ToInt32(Duration.Text) * 10).ToString();
                    Duration_Type.SelectedIndex = 1;

                }

                if (Duration_Type.SelectedItem.ToString() == "Until the start of its next turn")
                {
                    Duration.Text = Encounter_Per_Se.number_of_creatures.ToString();
                    Duration_Type.SelectedIndex = 2;

                }

                if (Duration_Type.SelectedItem.ToString() == "Until the end of its next turn")
                {
                    Duration.Text = (Encounter_Per_Se.number_of_creatures+1).ToString();
                    Duration_Type.SelectedIndex=2;
                }

                //Select the character_id or monster_Id depending of the type of creature we are talking about and save the condition.

                if (Encounter_Per_Se.select_Creature_Type== "Character")
                {
                    int character_id = Encounter_Per_Se.selected_Creature_Id;
                    DBConnection.getInstanceOfDBConnection().saveNewConditionCharacter(Constants.SAVE_NEW_CONDITION_CHARACTER, Encounter_List.selected_Encounter_ID, character_id, condition_id, Duration_Type.SelectedItem.ToString(), Convert.ToInt32(Duration.Text));
                }
                else
                {
                    int monster_id = Encounter_Per_Se.selected_Creature_Id; 
                    DBConnection.getInstanceOfDBConnection().saveNewConditionMonster(Constants.SAVE_NEW_CONDITION_MONSTER, Encounter_List.selected_Encounter_ID, monster_id, condition_id, Duration_Type.SelectedItem.ToString(), Convert.ToInt32(Duration.Text));
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("There is some information missing, please fill all the compulsory fields to continue (Duration)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }
    }
}

