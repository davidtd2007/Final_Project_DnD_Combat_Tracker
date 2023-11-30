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
    public partial class Dice_Roll : Form
    {
        public Dice_Roll()
        {
            InitializeComponent();
        }

        private void Dice_Roll_Load(object sender, EventArgs e)
        {
            dice_Type_Text.DataSource = new String[] {"D3","D4","D6","D8","D10","D100","D12","D20" };
            dice_Type_Text.DisplayMember = "D20";
            dice_Number_Text.Text = "1";
            modifier_Text.Text = "0";
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            int dice_Number= Convert.ToInt32(dice_Number_Text.Text);
            int dice_Type=0;
            int modifier = Convert.ToInt32(modifier_Text.Text);
            int result=modifier;

            //Set the type of dice that will be used in the roll
            switch (dice_Type_Text.Text)
            {
                case "D3":
                    dice_Type = 4;
                    break;
                case "D4":
                    dice_Type = 5;
                    break;
                case "D6":
                    dice_Type = 7;
                    break;
                case "D8":
                    dice_Type = 9;
                    break;
                case "D10":
                    dice_Type = 11;
                    break;
                case "D100":
                    dice_Type = 101;
                    break;
                case "D12":
                    dice_Type = 13;
                    break;
                case "D20":
                    dice_Type = 21;
                    break;
            }

            DiceRoller roll = new DiceRoller();
            //Advante or disadvantage can only be aplied to 1D20
            if (dice_Type_Text.Text == "D20" && dice_Number == 1)
            {
                int temp_result;
                if (Advantage.Checked)
                {
                    int result1 = roll.Roll(dice_Type);
                    int result2 = roll.Roll(dice_Type);
                    if (result1 > result2)
                    {
                        temp_result = result1;
                    }
                    else
                    {
                        temp_result = result2;
                    }

                }
                else if (Disadvantage.Checked)
                {
                    int result1 = roll.Roll(dice_Type);
                    int result2 = roll.Roll(dice_Type);
                    if (result1 > result2)
                    {
                        temp_result = result2;
                    }
                    else
                    {
                        temp_result = result1;
                    }
                }
                else
                {
                    temp_result = roll.Roll(dice_Type);
                }
                result += temp_result;

            }
            else
            {
                for (int i = 0; i < dice_Number; i++)
                {
                    result += roll.Roll(dice_Type);
                }
            }
            
            result_text.Text = result.ToString();
        }

        private void Advantage_CheckedChanged(object sender, EventArgs e)
        {
            if (Advantage.Checked)
            {
                dice_Type_Text.SelectedIndex = 7;
                dice_Number_Text.Text = "1";
                Disadvantage.Checked = false;
            }
        }

        private void Disadvantage_CheckedChanged(object sender, EventArgs e)
        {
            if (Disadvantage.Checked)
            {
                dice_Type_Text.SelectedIndex = 7;
                dice_Number_Text.Text = "1";
                Advantage.Checked = false;
            }
        }

        private void dice_Number_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void modifier_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

      

        private void dice_Type_Text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dice_Type_Text.Text != "D20"||dice_Number_Text.Text!="1")
            {
                Advantage.Checked = false;
                Disadvantage.Checked = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
