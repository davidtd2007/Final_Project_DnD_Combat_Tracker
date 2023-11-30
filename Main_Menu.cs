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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        

        

        //Campaing Buttom
        private void Campaing_Click(object sender, EventArgs e)
        {
            //change from the menu to the Campaing manager menu
            this.Hide();
            Campaing_Menu_List campaing = new Campaing_Menu_List();
            campaing.ShowDialog();
            this.Close();


        }


        private void Monsters_Click(object sender, EventArgs e)
        {
            //change to the monster menu form 
            this.Hide();
            List_Mosnter monster_List = new List_Mosnter();
            monster_List.ShowDialog();
            this.Close();
        }

        private void Characters_Click(object sender, EventArgs e)
        {
            this.Hide();
            Characters_By_Campaing character_view = new Characters_By_Campaing();
            character_view.ShowDialog();
            this.Close();
        }

        //Encounter buttom
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Campaing_For_Encounter encounter = new Campaing_For_Encounter();
            encounter.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Condition_Creation c = new Condition_Creation();
            c.ShowDialog();
        }

        //Dice roller 
        private void button1_Click_2(object sender, EventArgs e)
        {
            Dice_Roll Dice = new Dice_Roll();
            Dice.ShowDialog();

        }

        private void Rules_Click(object sender, EventArgs e)
        {
          
            Rules_List rules = new Rules_List();
            rules.ShowDialog();
           
        }
    }
}
