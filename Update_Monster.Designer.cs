
namespace dnd
{
    partial class Update_Monster
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
            this.CR_text = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AC_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.I_B_text = new System.Windows.Forms.TextBox();
            this.HP_text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dice = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CR_text
            // 
            this.CR_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CR_text.FormattingEnabled = true;
            this.CR_text.Location = new System.Drawing.Point(659, 145);
            this.CR_text.Name = "CR_text";
            this.CR_text.Size = new System.Drawing.Size(104, 24);
            this.CR_text.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 39);
            this.label6.TabIndex = 38;
            this.label6.Text = "Monster Creation";
            // 
            // AC_text
            // 
            this.AC_text.Location = new System.Drawing.Point(663, 205);
            this.AC_text.Name = "AC_text";
            this.AC_text.Size = new System.Drawing.Size(100, 22);
            this.AC_text.TabIndex = 37;
            this.AC_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AC_text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "AC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "CR";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.Location = new System.Drawing.Point(344, 353);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(135, 75);
            this.update.TabIndex = 34;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.next_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "I.B";
            // 
            // I_B_text
            // 
            this.I_B_text.Location = new System.Drawing.Point(517, 205);
            this.I_B_text.Name = "I_B_text";
            this.I_B_text.Size = new System.Drawing.Size(100, 22);
            this.I_B_text.TabIndex = 31;
            this.I_B_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.I_B_text_KeyPress);
            // 
            // HP_text
            // 
            this.HP_text.Location = new System.Drawing.Point(517, 145);
            this.HP_text.Name = "HP_text";
            this.HP_text.Size = new System.Drawing.Size(100, 22);
            this.HP_text.TabIndex = 30;
            this.HP_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HP_text_KeyPress);
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(107, 162);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(336, 22);
            this.Name_Text.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(503, 281);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(120, 17);
            this.path.TabIndex = 45;
            this.path.Text = "Image not seleted";
            // 
            // Upload
            // 
            this.Upload.AutoSize = true;
            this.Upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Upload.Location = new System.Drawing.Point(323, 253);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(156, 73);
            this.Upload.TabIndex = 44;
            this.Upload.Text = "Upload Statblock";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Max size: 1000x1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Accepted Formats: JPG and PNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Load a statblock";
            // 
            // dice
            // 
            this.dice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dice.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dice.Location = new System.Drawing.Point(24, 185);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(77, 76);
            this.dice.TabIndex = 48;
            this.dice.UseVisualStyleBackColor = false;
            this.dice.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(21, 105);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 47;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(22, 23);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 46;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Update_Monster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.path);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CR_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AC_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.I_B_text);
            this.Controls.Add(this.HP_text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Update_Monster";
            this.Text = "Update_Monster";
            this.Load += new System.EventHandler(this.Update_Monster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CR_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AC_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox I_B_text;
        private System.Windows.Forms.TextBox HP_text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button dice;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
    }
}