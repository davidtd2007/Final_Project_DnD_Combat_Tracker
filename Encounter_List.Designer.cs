
namespace dnd
{
    partial class Encounter_List
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
            this.Add = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.encounter_lis = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.encounter_lis)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add.Location = new System.Drawing.Point(264, 362);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 51);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add Encounters";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(95, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(69, 29);
            this.Title.TabIndex = 8;
            this.Title.Text = "Labe";
            // 
            // encounter_lis
            // 
            this.encounter_lis.AllowUserToAddRows = false;
            this.encounter_lis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.encounter_lis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encounter_lis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.creature_name,
            this.Difficulty});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.encounter_lis.DefaultCellStyle = dataGridViewCellStyle1;
            this.encounter_lis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encounter_lis.Location = new System.Drawing.Point(208, 114);
            this.encounter_lis.Name = "encounter_lis";
            this.encounter_lis.RowHeadersWidth = 51;
            this.encounter_lis.RowTemplate.Height = 24;
            this.encounter_lis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.encounter_lis.Size = new System.Drawing.Size(378, 206);
            this.encounter_lis.TabIndex = 11;
            this.encounter_lis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.encounter_lis_CellClick);
            this.encounter_lis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.encounter_lis_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(100, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 76);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(12, 362);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 14;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(12, 23);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 13;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.Location = new System.Drawing.Point(403, 362);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 51);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete encounter";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.MinimumWidth = 6;
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Width = 125;
            // 
            // Encounter_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.encounter_lis);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Encounter_List";
            this.Text = "Encounter_List";
            this.Load += new System.EventHandler(this.Encounter_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.encounter_lis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView encounter_lis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
    }
}