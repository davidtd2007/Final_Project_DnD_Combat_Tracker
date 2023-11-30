using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dnd
{
    public partial class List_Mosnter : Form
    {
        public List_Mosnter()
        {
            InitializeComponent();
        }
        public static int selected_Monster_Id;
        private void Monster_List_Load(object sender, EventArgs e)
        {

            //Get all monsters

            DataSet monster_Info = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.GET_ALL_MONSTER_DATA);
            int number_Of_Monsters = monster_Info.Tables[0].Rows.Count;
            if (number_Of_Monsters != 0)
            {
                //Get all the character names from the list of Campaing_Characters and list them.
                for (int i = 0; i < number_Of_Monsters; i++)
                {
                    int monster_Id = Convert.ToInt32(monster_Info.Tables[0].Rows[i][0].ToString());
                    string name = monster_Info.Tables[0].Rows[i][1].ToString();
                    string CR = monster_Info.Tables[0].Rows[i][2].ToString();
                    //Add elements to the list
                    Monsters_List.Rows.Add(monster_Id, name, CR);

                }
            }
            else
            {
                Monsters_List.Rows.Add(-1,"No Monsters found");
                Monsters_List.Enabled = false;
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Monster add = new Create_Monster();
            add.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu back = new Main_Menu();
            back.ShowDialog();
            this.Close();

        }



        private void Monsters_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected_Monster_Id = Convert.ToInt32(Monsters_List.Rows[e.RowIndex].Cells[0].Value.ToString());

                this.Hide();
                Update_Monster update = new Update_Monster();
                update.ShowDialog();
                this.Close();
            }

           
        }

        private void Monsters_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                int selectet_row_index = e.RowIndex;



                

                DataSet image = DBConnection.getInstanceOfDBConnection().getDATAFromID(Constants.GET_MONSTER_STATBLOCK_FROM_ID, Convert.ToInt32(Monsters_List.Rows[selectet_row_index].Cells[0].Value.ToString()));
                MemoryStream ms = new MemoryStream((byte[])image.Tables[0].Rows[0][0]);
                ST.Image = new Bitmap(ms);


            }
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

