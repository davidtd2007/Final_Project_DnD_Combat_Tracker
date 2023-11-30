using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dnd
{

    public partial class Update_Monster : Form
    {

        private Image statblock;
        private string image_path = "";
        public Update_Monster()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {

            string name = Name_Text.Text;
            int I_B = Convert.ToInt32(I_B_text.Text);
            int HP = Convert.ToInt32(HP_text.Text);
            int AC = Convert.ToInt32(AC_text.Text);
            string CR = CR_text.SelectedItem.ToString();



            //Check the information has actually being written
            if (name != "" && I_B.ToString() != "" && AC.ToString() != "" && HP.ToString() != "")
            {


                int id = List_Mosnter.selected_Monster_Id;
                DBConnection.getInstanceOfDBConnection().updatemonster(Constants.UPDATE_MONSTER, name, AC, I_B, HP, CR, id, statblock);
                this.Hide();
                List_Mosnter next = new List_Mosnter();
                next.ShowDialog();
                this.Close();


            }
            else
            {
                //Show error window if there is any of the compulsory information missing
                MessageBox.Show("There is information missing, please fill all the compulsory fields(name,IB,AC and HP)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Update_Monster_Load(object sender, EventArgs e)
        {
            //Create a dropdown list with  the possible values of the CR
            CR_text.DataSource = new String[] { "0", "1/8", "1/4", "1/2", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };
            
            //Display all the current information
            int monster_Id = List_Mosnter.selected_Monster_Id;
            DataSet monster_Info = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_INFO_FROM_ID, monster_Id);
            Name_Text.Text = monster_Info.Tables[0].Rows[0][4].ToString();
            string CR= monster_Info.Tables[0].Rows[0][1].ToString();
            int CR_index=0;
            
            switch (CR)
            {
                case "0":
                    CR_index = 0;
                    break;

                case "1/8":
                    CR_index = 1;
                    break;
                case "1/4":
                    CR_index = 2;
                    break;
                case "1/2":
                    CR_index = 3;
                    break;
                case "1":
                    CR_index = 4;
                    break;
                case "2":
                    CR_index = 5;
                    break;
                case "3":
                    CR_index = 6;
                    break;

                case "4":
                    CR_index = 7;
                    break;
                case "5":
                    CR_index = 8;
                    break;
                case "6":
                    CR_index = 9;
                    break;
                case "7":
                    CR_index = 10;
                    break;
                case "8":
                    CR_index = 11;
                    break;
                case "9":
                    CR_index = 12;
                    break;
                case "10":
                    CR_index = 13;
                    break;
                case "11":
                    CR_index = 14;
                    break;
                case "12":
                    CR_index = 15;
                    break;
                case "13":
                    CR_index = 16;
                    break;
                case "14":
                    CR_index = 17;
                    break;
                case "15":
                    CR_index =18;
                    break;
                case "16":
                    CR_index = 19;
                    break;
                case "17":
                    CR_index = 20;
                    break;
                case "18":
                    CR_index = 21;
                    break;
                case "19":
                    CR_index = 22;
                    break;
                case "20":
                    CR_index = 23;
                    break;
                case "21":
                    CR_index = 24;
                    break;
                case "22":
                    CR_index = 25;
                    break;
                case "23":
                    CR_index = 26;
                    break;
                case "24":
                    CR_index = 27;
                    break;
                case "25":
                    CR_index = 28;
                    break;
                case "26":
                    CR_index = 29;
                    break;
                case "27":
                    CR_index = 30;
                    break;
                case "28":
                    CR_index = 31;
                    break;
                case "29":
                    CR_index = 32;
                    break;
                case "30":
                    CR_index = 33;
                    break;

            }
            CR_text.SelectedIndex = CR_index;
            AC_text.Text = monster_Info.Tables[0].Rows[0][5].ToString();
            HP_text.Text = monster_Info.Tables[0].Rows[0][6].ToString();
            I_B_text.Text = monster_Info.Tables[0].Rows[0][3].ToString();
            MemoryStream ms = new MemoryStream((byte[])monster_Info.Tables[0].Rows[0][2]);
            statblock= new Bitmap(ms);
            path.Text = image_path;

        }



        private void I_B_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '-'))
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

        private void HP_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog image = new OpenFileDialog();

                image.Filter = "jpg files(*.jpg)|*.jpg| PGN files(*.png)|*.png| All Files(*.*)|*.*)";

                if (image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(image.FileName);
                    if (img.Width < 1000 && img.Height < 1000)
                    {
                        this.statblock = img;
                        path.Text = image.FileName;

                    }
                    else
                    {
                        MessageBox.Show("The image size is bigger than 1000x1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("An error Ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
