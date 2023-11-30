
namespace dnd
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Campaing = new System.Windows.Forms.Button();
            this.Monsters = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.Encounters = new System.Windows.Forms.Button();
            this.Characters = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Campaing
            // 
            resources.ApplyResources(this.Campaing, "Campaing");
            this.Campaing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Campaing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Campaing.Name = "Campaing";
            this.Campaing.UseVisualStyleBackColor = false;
            this.Campaing.Click += new System.EventHandler(this.Campaing_Click);
            // 
            // Monsters
            // 
            resources.ApplyResources(this.Monsters, "Monsters");
            this.Monsters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Monsters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Monsters.Name = "Monsters";
            this.Monsters.UseVisualStyleBackColor = false;
            this.Monsters.Click += new System.EventHandler(this.Monsters_Click);
            // 
            // Rules
            // 
            resources.ApplyResources(this.Rules, "Rules");
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rules.Name = "Rules";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Encounters
            // 
            resources.ApplyResources(this.Encounters, "Encounters");
            this.Encounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Encounters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Encounters.Name = "Encounters";
            this.Encounters.UseVisualStyleBackColor = false;
            this.Encounters.Click += new System.EventHandler(this.button1_Click);
            // 
            // Characters
            // 
            resources.ApplyResources(this.Characters, "Characters");
            this.Characters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Characters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Characters.Name = "Characters";
            this.Characters.UseVisualStyleBackColor = false;
            this.Characters.Click += new System.EventHandler(this.Characters_Click);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Title.Name = "Title";
            this.Title.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Main_Menu
            // 
            this.AcceptButton = this.Characters;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.Encounters);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Monsters);
            this.Controls.Add(this.Campaing);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Main_Menu";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Campaing;
        private System.Windows.Forms.Button Monsters;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Button Encounters;
        private System.Windows.Forms.Button Characters;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
    }
}