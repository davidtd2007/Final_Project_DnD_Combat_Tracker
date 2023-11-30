
namespace dnd
{
    partial class Character_View
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
            this.title = new System.Windows.Forms.Label();
            this.Specie = new System.Windows.Forms.TextBox();
            this.IB = new System.Windows.Forms.TextBox();
            this.HP = new System.Windows.Forms.TextBox();
            this.AC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.character_level = new System.Windows.Forms.TextBox();
            this.Class_List = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(93, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Label";
            // 
            // Specie
            // 
            this.Specie.Location = new System.Drawing.Point(96, 98);
            this.Specie.Name = "Specie";
            this.Specie.ReadOnly = true;
            this.Specie.Size = new System.Drawing.Size(240, 22);
            this.Specie.TabIndex = 2;
            // 
            // IB
            // 
            this.IB.Location = new System.Drawing.Point(469, 98);
            this.IB.Name = "IB";
            this.IB.ReadOnly = true;
            this.IB.Size = new System.Drawing.Size(135, 22);
            this.IB.TabIndex = 3;
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(645, 98);
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Size = new System.Drawing.Size(121, 22);
            this.HP.TabIndex = 4;
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(96, 166);
            this.AC.Name = "AC";
            this.AC.ReadOnly = true;
            this.AC.Size = new System.Drawing.Size(124, 22);
            this.AC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Specie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "I.B.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "AC";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(336, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Classes Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Character Level";
            // 
            // character_level
            // 
            this.character_level.Location = new System.Drawing.Point(632, 327);
            this.character_level.Name = "character_level";
            this.character_level.ReadOnly = true;
            this.character_level.Size = new System.Drawing.Size(124, 22);
            this.character_level.TabIndex = 15;
            // 
            // Class_List
            // 
            this.Class_List.AllowUserToAddRows = false;
            this.Class_List.AllowUserToDeleteRows = false;
            this.Class_List.AllowUserToOrderColumns = true;
            this.Class_List.AllowUserToResizeColumns = false;
            this.Class_List.AllowUserToResizeRows = false;
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
            this.Class_List.Location = new System.Drawing.Point(27, 304);
            this.Class_List.Name = "Class_List";
            this.Class_List.RowHeadersWidth = 51;
            this.Class_List.RowTemplate.Height = 24;
            this.Class_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Class_List.Size = new System.Drawing.Size(577, 119);
            this.Class_List.TabIndex = 17;
            this.Class_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Class_List_CellClick);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(10, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 76);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(10, 98);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 19;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(10, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 18;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.Location = new System.Drawing.Point(632, 355);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 48);
            this.delete.TabIndex = 21;
            this.delete.Text = "Delete Class";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Character_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Class_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.character_level);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.IB);
            this.Controls.Add(this.Specie);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Character_View";
            this.Text = "Character_View";
            this.Load += new System.EventHandler(this.Character_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Class_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox Specie;
        private System.Windows.Forms.TextBox IB;
        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.TextBox AC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox character_level;
        private System.Windows.Forms.DataGridView Class_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Level;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button delete;
    }
}