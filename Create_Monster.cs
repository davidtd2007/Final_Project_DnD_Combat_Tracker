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
    public partial class Create_Monster : Form
    {

        private Image statblock;
        public Create_Monster()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
           
            //Check the information has actually being written

            if (Name_Text.Text != "" && I_B_text.Text != ""&& AC_text.Text != "" && I_B_text.Text != "" && statblock !=null)
            {
                string name = Name_Text.Text;
                int I_B = Convert.ToInt32(I_B_text.Text);
                int HP = Convert.ToInt32(HP_text.Text);
                int AC = Convert.ToInt32(AC_text.Text);
                string CR = CR_text.SelectedItem.ToString();

                DBConnection.getInstanceOfDBConnection().saveNewMonster(Constants.SAVE_NEW_MONSTER, name, AC, I_B, HP, CR,statblock);
                        this.Hide();
                        List_Mosnter next = new List_Mosnter();
                        next.ShowDialog();
                        this.Close();
     

            }
            else
            {
                //Show error window if the name is not in place
                MessageBox.Show("There is some information missing, please fill all compulsory the fields to continue (Name, AC, IB, Statblock and HP)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // Only allow integerts in the corresponding fields
        private void CR_text_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

        }

        private void AC_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                    )
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

        //The initiative bonus also allows negative values
        private void I_B_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void Create_Monster_Load(object sender, EventArgs e)
        {
            //Create a dropdown list with  the possible values of the CR

            CR_text.DataSource = new String[] { "0","1/8","1/4","1/2","1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30" };
            
        }

        private void Upload_Click(object sender, EventArgs e)
        {
           
            //Allow the user to  upload the statblock
            try
            {
                OpenFileDialog image = new OpenFileDialog();
                
                image.Filter = "jpg files(*.jpg)|*.jpg| PGN files(*.png)|*.png| All Files(*.*)|*.*)";

                if (image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image img = Image.FromFile(image.FileName);
                    if (img.Width<1000&& img.Height<1000 )
                    {
                        this.statblock = img;
                        path.Text= image.FileName;
                        
                    }
                    else
                    {
                        MessageBox.Show("The image size is bigger than 1000x1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }


            }catch (Exception)
            {
                MessageBox.Show("An error Ocurred, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Mosnter back = new List_Mosnter();
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
