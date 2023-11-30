
namespace dnd
{
    partial class Create_Encounter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.description_text = new System.Windows.Forms.RichTextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.available_Monsters = new System.Windows.Forms.DataGridView();
            this.chosen_Monsters = new System.Windows.Forms.DataGridView();
            this.ST = new System.Windows.Forms.PictureBox();
            this.Easy = new System.Windows.Forms.Label();
            this.xp_of_encounter = new System.Windows.Forms.Label();
            this.ajusted_xp = new System.Windows.Forms.Label();
            this.difficulty_Text = new System.Windows.Forms.Label();
            this.Medium = new System.Windows.Forms.Label();
            this.Hard = new System.Windows.Forms.Label();
            this.Deadly = new System.Windows.Forms.Label();
            this.daily_budget = new System.Windows.Forms.Label();
            this.average_char_level = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monster_CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosen_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosen_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosen_CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.available_Monsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosen_Monsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save.Location = new System.Drawing.Point(370, 950);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(104, 58);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Encounter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(450, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(425, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encounter Name";
            // 
            // description_text
            // 
            this.description_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.description_text.Location = new System.Drawing.Point(229, 157);
            this.description_text.Name = "description_text";
            this.description_text.Size = new System.Drawing.Size(521, 194);
            this.description_text.TabIndex = 7;
            this.description_text.Text = "";
            // 
            // name_text
            // 
            this.name_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.name_text.Location = new System.Drawing.Point(352, 102);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(301, 22);
            this.name_text.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(147, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monsters Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(527, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monsters in encounter";
            // 
            // available_Monsters
            // 
            this.available_Monsters.AllowUserToAddRows = false;
            this.available_Monsters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.available_Monsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available_Monsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.creature_name,
            this.monster_CR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.available_Monsters.DefaultCellStyle = dataGridViewCellStyle1;
            this.available_Monsters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.available_Monsters.Location = new System.Drawing.Point(41, 445);
            this.available_Monsters.Name = "available_Monsters";
            this.available_Monsters.RowHeadersWidth = 51;
            this.available_Monsters.RowTemplate.Height = 24;
            this.available_Monsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.available_Monsters.Size = new System.Drawing.Size(378, 206);
            this.available_Monsters.TabIndex = 12;
            this.available_Monsters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_Monsters_CellClick);
            this.available_Monsters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_Monsters_CellDoubleClick);
            // 
            // chosen_Monsters
            // 
            this.chosen_Monsters.AllowUserToAddRows = false;
            this.chosen_Monsters.AllowUserToDeleteRows = false;
            this.chosen_Monsters.AllowUserToOrderColumns = true;
            this.chosen_Monsters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chosen_Monsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosen_Monsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chosen_Id,
            this.chosen_name,
            this.chosen_CR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chosen_Monsters.DefaultCellStyle = dataGridViewCellStyle2;
            this.chosen_Monsters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chosen_Monsters.Location = new System.Drawing.Point(441, 445);
            this.chosen_Monsters.Name = "chosen_Monsters";
            this.chosen_Monsters.RowHeadersWidth = 51;
            this.chosen_Monsters.RowTemplate.Height = 24;
            this.chosen_Monsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chosen_Monsters.Size = new System.Drawing.Size(378, 206);
            this.chosen_Monsters.TabIndex = 13;
            this.chosen_Monsters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chosen_Monsters_CellClick);
            this.chosen_Monsters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chosen_Monsters_CellDoubleClick);
            // 
            // ST
            // 
            this.ST.Location = new System.Drawing.Point(885, 129);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(994, 1000);
            this.ST.TabIndex = 15;
            this.ST.TabStop = false;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Easy.Location = new System.Drawing.Point(513, 767);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(46, 17);
            this.Easy.TabIndex = 16;
            this.Easy.Text = "label6";
            // 
            // xp_of_encounter
            // 
            this.xp_of_encounter.AutoSize = true;
            this.xp_of_encounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xp_of_encounter.Location = new System.Drawing.Point(261, 805);
            this.xp_of_encounter.Name = "xp_of_encounter";
            this.xp_of_encounter.Size = new System.Drawing.Size(46, 17);
            this.xp_of_encounter.TabIndex = 17;
            this.xp_of_encounter.Text = "label7";
            // 
            // ajusted_xp
            // 
            this.ajusted_xp.AutoSize = true;
            this.ajusted_xp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ajusted_xp.Location = new System.Drawing.Point(261, 856);
            this.ajusted_xp.Name = "ajusted_xp";
            this.ajusted_xp.Size = new System.Drawing.Size(46, 17);
            this.ajusted_xp.TabIndex = 18;
            this.ajusted_xp.Text = "label8";
            // 
            // difficulty_Text
            // 
            this.difficulty_Text.AutoSize = true;
            this.difficulty_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.difficulty_Text.Location = new System.Drawing.Point(261, 898);
            this.difficulty_Text.Name = "difficulty_Text";
            this.difficulty_Text.Size = new System.Drawing.Size(46, 17);
            this.difficulty_Text.TabIndex = 19;
            this.difficulty_Text.Text = "label9";
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Medium.Location = new System.Drawing.Point(513, 805);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(54, 17);
            this.Medium.TabIndex = 20;
            this.Medium.Text = "label10";
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hard.Location = new System.Drawing.Point(513, 838);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(54, 17);
            this.Hard.TabIndex = 21;
            this.Hard.Text = "label11";
            // 
            // Deadly
            // 
            this.Deadly.AutoSize = true;
            this.Deadly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deadly.Location = new System.Drawing.Point(513, 870);
            this.Deadly.Name = "Deadly";
            this.Deadly.Size = new System.Drawing.Size(54, 17);
            this.Deadly.TabIndex = 22;
            this.Deadly.Text = "label12";
            // 
            // daily_budget
            // 
            this.daily_budget.AutoSize = true;
            this.daily_budget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daily_budget.Location = new System.Drawing.Point(513, 898);
            this.daily_budget.Name = "daily_budget";
            this.daily_budget.Size = new System.Drawing.Size(54, 17);
            this.daily_budget.TabIndex = 23;
            this.daily_budget.Text = "label13";
            // 
            // average_char_level
            // 
            this.average_char_level.AutoSize = true;
            this.average_char_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.average_char_level.Location = new System.Drawing.Point(386, 719);
            this.average_char_level.Name = "average_char_level";
            this.average_char_level.Size = new System.Drawing.Size(54, 17);
            this.average_char_level.TabIndex = 24;
            this.average_char_level.Text = "label13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(149, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(592, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Double Click in a monster to add it to the list or Double click on a selected mon" +
    "ster to erase it";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(21, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 76);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(21, 91);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 28;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(21, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 76);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.back_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // creature_name
            // 
            this.creature_name.HeaderText = "Name";
            this.creature_name.MinimumWidth = 6;
            this.creature_name.Name = "creature_name";
            this.creature_name.ReadOnly = true;
            this.creature_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creature_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.creature_name.Width = 125;
            // 
            // monster_CR
            // 
            this.monster_CR.HeaderText = "CR";
            this.monster_CR.MinimumWidth = 6;
            this.monster_CR.Name = "monster_CR";
            this.monster_CR.ReadOnly = true;
            this.monster_CR.Width = 125;
            // 
            // chosen_Id
            // 
            this.chosen_Id.HeaderText = "Id";
            this.chosen_Id.MinimumWidth = 6;
            this.chosen_Id.Name = "chosen_Id";
            this.chosen_Id.ReadOnly = true;
            this.chosen_Id.Visible = false;
            this.chosen_Id.Width = 125;
            // 
            // chosen_name
            // 
            this.chosen_name.HeaderText = "Name";
            this.chosen_name.MinimumWidth = 6;
            this.chosen_name.Name = "chosen_name";
            this.chosen_name.ReadOnly = true;
            this.chosen_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chosen_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chosen_name.Width = 125;
            // 
            // chosen_CR
            // 
            this.chosen_CR.HeaderText = "CR";
            this.chosen_CR.MinimumWidth = 6;
            this.chosen_CR.Name = "chosen_CR";
            this.chosen_CR.ReadOnly = true;
            this.chosen_CR.Width = 125;
            // 
            // Create_Encounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2070, 1184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.average_char_level);
            this.Controls.Add(this.daily_budget);
            this.Controls.Add(this.Deadly);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.difficulty_Text);
            this.Controls.Add(this.ajusted_xp);
            this.Controls.Add(this.xp_of_encounter);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.chosen_Monsters);
            this.Controls.Add(this.available_Monsters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Create_Encounter";
            this.Text = "Create_Encounter";
            this.Load += new System.EventHandler(this.Create_Encounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.available_Monsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosen_Monsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox description_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView available_Monsters;
        private System.Windows.Forms.DataGridView chosen_Monsters;
        private System.Windows.Forms.PictureBox ST;
        private System.Windows.Forms.Label Easy;
        private System.Windows.Forms.Label xp_of_encounter;
        private System.Windows.Forms.Label ajusted_xp;
        private System.Windows.Forms.Label difficulty_Text;
        private System.Windows.Forms.Label Medium;
        private System.Windows.Forms.Label Hard;
        private System.Windows.Forms.Label Deadly;
        private System.Windows.Forms.Label daily_budget;
        private System.Windows.Forms.Label average_char_level;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn monster_CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosen_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosen_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosen_CR;
    }
}