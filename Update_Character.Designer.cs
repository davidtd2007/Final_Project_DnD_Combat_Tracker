
namespace dnd
{
    partial class Update_Character
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
            this.label6 = new System.Windows.Forms.Label();
            this.AC_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Specie_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IB_text = new System.Windows.Forms.TextBox();
            this.HP_text = new System.Windows.Forms.TextBox();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Class_List = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Class = new System.Windows.Forms.Button();
            this.dice = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Update Character";
            // 
            // AC_text
            // 
            this.AC_text.Location = new System.Drawing.Point(541, 281);
            this.AC_text.Name = "AC_text";
            this.AC_text.Size = new System.Drawing.Size(100, 22);
            this.AC_text.TabIndex = 23;
            this.AC_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AC_text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "AC";
            // 
            // Specie_text
            // 
            this.Specie_text.Location = new System.Drawing.Point(126, 257);
            this.Specie_text.Name = "Specie_text";
            this.Specie_text.Size = new System.Drawing.Size(336, 22);
            this.Specie_text.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Specie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "I.B";
            // 
            // IB_text
            // 
            this.IB_text.Location = new System.Drawing.Point(541, 154);
            this.IB_text.Name = "IB_text";
            this.IB_text.Size = new System.Drawing.Size(100, 22);
            this.IB_text.TabIndex = 17;
            this.IB_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.I_B_text_KeyPress);
            // 
            // HP_text
            // 
            this.HP_text.Location = new System.Drawing.Point(541, 214);
            this.HP_text.Name = "HP_text";
            this.HP_text.Size = new System.Drawing.Size(100, 22);
            this.HP_text.TabIndex = 16;
            this.HP_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HP_text_KeyPress);
            // 
            // name_Text
            // 
            this.name_Text.Location = new System.Drawing.Point(126, 171);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(336, 22);
            this.name_Text.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.Location = new System.Drawing.Point(299, 467);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(143, 56);
            this.update.TabIndex = 26;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Class_List
            // 
            this.Class_List.AllowUserToAddRows = false;
            this.Class_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Class_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Class_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Class_Name,
            this.Subclass,
            this.Class_Level});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Class_List.DefaultCellStyle = dataGridViewCellStyle1;
            this.Class_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Class_List.Location = new System.Drawing.Point(26, 309);
            this.Class_List.Name = "Class_List";
            this.Class_List.RowHeadersWidth = 51;
            this.Class_List.RowTemplate.Height = 24;
            this.Class_List.Size = new System.Drawing.Size(550, 139);
            this.Class_List.TabIndex = 27;
            this.Class_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Class_List_CellDoubleClick);
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
            // Class_Name
            // 
            this.Class_Name.HeaderText = "Class";
            this.Class_Name.MinimumWidth = 6;
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            this.Class_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Class_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Class_Name.Width = 125;
            // 
            // Subclass
            // 
            this.Subclass.HeaderText = "Subclass";
            this.Subclass.MinimumWidth = 6;
            this.Subclass.Name = "Subclass";
            this.Subclass.ReadOnly = true;
            this.Subclass.Width = 125;
            // 
            // Class_Level
            // 
            this.Class_Level.HeaderText = "Class Level";
            this.Class_Level.MinimumWidth = 6;
            this.Class_Level.Name = "Class_Level";
            this.Class_Level.ReadOnly = true;
            this.Class_Level.Width = 160;
            // 
            // Add_Class
            // 
            this.Add_Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Class.Location = new System.Drawing.Point(602, 360);
            this.Add_Class.Name = "Add_Class";
            this.Add_Class.Size = new System.Drawing.Size(134, 51);
            this.Add_Class.TabIndex = 28;
            this.Add_Class.Text = "Add new Class";
            this.Add_Class.UseVisualStyleBackColor = false;
            this.Add_Class.Click += new System.EventHandler(this.Add_Class_Click);
            // 
            // dice
            // 
            this.dice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dice.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dice.Location = new System.Drawing.Point(26, 194);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(77, 76);
            this.dice.TabIndex = 31;
            this.dice.UseVisualStyleBackColor = false;
            this.dice.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(26, 106);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 30;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(26, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 29;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Double Click in a class to  update it";
            // 
            // Update_Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(789, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add_Class);
            this.Controls.Add(this.Class_List);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AC_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Specie_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IB_text);
            this.Controls.Add(this.HP_text);
            this.Controls.Add(this.name_Text);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Update_Character";
            this.Text = "Update_Character";
            this.Load += new System.EventHandler(this.Update_Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AC_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Specie_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IB_text;
        private System.Windows.Forms.TextBox HP_text;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView Class_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Level;
        private System.Windows.Forms.Button Add_Class;
        private System.Windows.Forms.Button dice;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}