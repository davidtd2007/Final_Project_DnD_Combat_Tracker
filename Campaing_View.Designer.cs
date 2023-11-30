
namespace dnd
{
    partial class Campaing_View
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
            this.Campaing_Name = new System.Windows.Forms.Label();
            this.Campaing_Description = new System.Windows.Forms.RichTextBox();
            this.Update_Campaing = new System.Windows.Forms.Button();
            this.Characters_Lists = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Character_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Characters_Lists)).BeginInit();
            this.SuspendLayout();
            // 
            // Campaing_Name
            // 
            this.Campaing_Name.AutoSize = true;
            this.Campaing_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campaing_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Campaing_Name.Location = new System.Drawing.Point(95, 12);
            this.Campaing_Name.Name = "Campaing_Name";
            this.Campaing_Name.Size = new System.Drawing.Size(109, 39);
            this.Campaing_Name.TabIndex = 0;
            this.Campaing_Name.Text = "label1";
            // 
            // Campaing_Description
            // 
            this.Campaing_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Campaing_Description.Location = new System.Drawing.Point(142, 90);
            this.Campaing_Description.Name = "Campaing_Description";
            this.Campaing_Description.ReadOnly = true;
            this.Campaing_Description.Size = new System.Drawing.Size(514, 243);
            this.Campaing_Description.TabIndex = 1;
            this.Campaing_Description.Text = "";
            // 
            // Update_Campaing
            // 
            this.Update_Campaing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Update_Campaing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Update_Campaing.Location = new System.Drawing.Point(523, 362);
            this.Update_Campaing.Name = "Update_Campaing";
            this.Update_Campaing.Size = new System.Drawing.Size(133, 62);
            this.Update_Campaing.TabIndex = 5;
            this.Update_Campaing.Text = "Update";
            this.Update_Campaing.UseVisualStyleBackColor = false;
            this.Update_Campaing.Click += new System.EventHandler(this.Update_Click);
            // 
            // Characters_Lists
            // 
            this.Characters_Lists.AllowUserToAddRows = false;
            this.Characters_Lists.AllowUserToDeleteRows = false;
            this.Characters_Lists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Characters_Lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Characters_Lists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.creature_name,
            this.Character_Level});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Characters_Lists.DefaultCellStyle = dataGridViewCellStyle2;
            this.Characters_Lists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Characters_Lists.Location = new System.Drawing.Point(702, 90);
            this.Characters_Lists.MultiSelect = false;
            this.Characters_Lists.Name = "Characters_Lists";
            this.Characters_Lists.ReadOnly = true;
            this.Characters_Lists.RowHeadersWidth = 51;
            this.Characters_Lists.RowTemplate.Height = 24;
            this.Characters_Lists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Characters_Lists.Size = new System.Drawing.Size(423, 243);
            this.Characters_Lists.TabIndex = 10;
            this.Characters_Lists.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Characters_Lists_CellDoubleClick);
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
            // Character_Level
            // 
            this.Character_Level.HeaderText = "Character Level";
            this.Character_Level.MinimumWidth = 6;
            this.Character_Level.Name = "Character_Level";
            this.Character_Level.ReadOnly = true;
            this.Character_Level.Width = 160;
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
            this.button1.TabIndex = 15;
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
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 13;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Campaing_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Characters_Lists);
            this.Controls.Add(this.Update_Campaing);
            this.Controls.Add(this.Campaing_Description);
            this.Controls.Add(this.Campaing_Name);
            this.Name = "Campaing_View";
            this.Text = "Campaing_View";
            this.Load += new System.EventHandler(this.Campaing_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Characters_Lists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Campaing_Name;
        private System.Windows.Forms.RichTextBox Campaing_Description;
        private System.Windows.Forms.Button Update_Campaing;
        private System.Windows.Forms.DataGridView Characters_Lists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character_Level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
    }
}