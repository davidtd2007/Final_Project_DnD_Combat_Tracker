namespace dnd
{
    partial class List_Mosnter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Monsters_List = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ST = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Monsters_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add.Location = new System.Drawing.Point(552, 354);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 59);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add Monster";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(102, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(156, 39);
            this.Title.TabIndex = 4;
            this.Title.Text = "Monsters";
            // 
            // Monsters_List
            // 
            this.Monsters_List.AllowUserToAddRows = false;
            this.Monsters_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Monsters_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Monsters_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.creature_name,
            this.CR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Monsters_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monsters_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Monsters_List.Location = new System.Drawing.Point(380, 79);
            this.Monsters_List.Name = "Monsters_List";
            this.Monsters_List.RowHeadersWidth = 51;
            this.Monsters_List.RowTemplate.Height = 24;
            this.Monsters_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Monsters_List.Size = new System.Drawing.Size(427, 258);
            this.Monsters_List.TabIndex = 11;
            this.Monsters_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Monsters_List_CellClick);
            this.Monsters_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Monsters_List_CellDoubleClick);
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
            // CR
            // 
            this.CR.HeaderText = "CR";
            this.CR.MinimumWidth = 6;
            this.CR.Name = "CR";
            this.CR.ReadOnly = true;
            this.CR.Width = 160;
            // 
            // ST
            // 
            this.ST.Location = new System.Drawing.Point(21, 444);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(1015, 800);
            this.ST.TabIndex = 27;
            this.ST.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(107, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 76);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(24, 345);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 29;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 76);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Click on a monster to display its statblock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "or double click to update it";
            // 
            // List_Mosnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1062, 1325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.Monsters_List);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "List_Mosnter";
            this.Text = "Mosnter_List";
            this.Load += new System.EventHandler(this.Monster_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Monsters_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView Monsters_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.PictureBox ST;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
