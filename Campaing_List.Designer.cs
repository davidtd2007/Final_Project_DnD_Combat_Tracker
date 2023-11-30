
namespace dnd
{
    partial class Campaing_Menu_List
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
            this.Title = new System.Windows.Forms.Label();
            this.Add_Campaing = new System.Windows.Forms.Button();
            this.Campaing_Lists = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Character_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Campaing_Lists)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(343, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(185, 45);
            this.Title.TabIndex = 12;
            this.Title.Text = "Campaigns";
            this.Title.UseCompatibleTextRendering = true;
            // 
            // Add_Campaing
            // 
            this.Add_Campaing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Campaing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_Campaing.Location = new System.Drawing.Point(317, 352);
            this.Add_Campaing.Name = "Add_Campaing";
            this.Add_Campaing.Size = new System.Drawing.Size(97, 53);
            this.Add_Campaing.TabIndex = 15;
            this.Add_Campaing.Text = "Add";
            this.Add_Campaing.UseVisualStyleBackColor = false;
            this.Add_Campaing.Click += new System.EventHandler(this.Add_Campaing_Click);
            // 
            // Campaing_Lists
            // 
            this.Campaing_Lists.AllowUserToAddRows = false;
            this.Campaing_Lists.AllowUserToResizeColumns = false;
            this.Campaing_Lists.AllowUserToResizeRows = false;
            this.Campaing_Lists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Campaing_Lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Campaing_Lists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.creature_name,
            this.Character_Number});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Campaing_Lists.DefaultCellStyle = dataGridViewCellStyle1;
            this.Campaing_Lists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Campaing_Lists.Location = new System.Drawing.Point(190, 75);
            this.Campaing_Lists.Name = "Campaing_Lists";
            this.Campaing_Lists.RowHeadersWidth = 51;
            this.Campaing_Lists.RowTemplate.Height = 24;
            this.Campaing_Lists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Campaing_Lists.Size = new System.Drawing.Size(485, 258);
            this.Campaing_Lists.TabIndex = 19;
            this.Campaing_Lists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Campaing_Lists_CellClick);
            this.Campaing_Lists.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Campaing_Lists_CellDoubleClick);
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
            // Character_Number
            // 
            this.Character_Number.HeaderText = "Number of Characters";
            this.Character_Number.MinimumWidth = 6;
            this.Character_Number.Name = "Character_Number";
            this.Character_Number.ReadOnly = true;
            this.Character_Number.Width = 160;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 76);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(12, 94);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 21;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 20;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Location = new System.Drawing.Point(431, 352);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 53);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Campaing_Menu_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Campaing_Lists);
            this.Controls.Add(this.Add_Campaing);
            this.Controls.Add(this.Title);
            this.Name = "Campaing_Menu_List";
            this.Text = "Campaing_Menu";
            this.Load += new System.EventHandler(this.Campaing_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Campaing_Lists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Add_Campaing;
        private System.Windows.Forms.DataGridView Campaing_Lists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character_Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button delete;
    }
}