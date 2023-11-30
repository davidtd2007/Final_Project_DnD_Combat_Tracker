
namespace dnd
{
    partial class Rules_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.New_User = new System.Windows.Forms.Button();
            this.Conditions = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rule_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules";
            // 
            // New_User
            // 
            this.New_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.New_User.Location = new System.Drawing.Point(83, 87);
            this.New_User.Name = "New_User";
            this.New_User.Size = new System.Drawing.Size(93, 44);
            this.New_User.TabIndex = 1;
            this.New_User.Text = "New User tips";
            this.New_User.UseVisualStyleBackColor = false;
            this.New_User.Click += new System.EventHandler(this.New_User_Click);
            // 
            // Conditions
            // 
            this.Conditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Conditions.Location = new System.Drawing.Point(83, 137);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(93, 44);
            this.Conditions.TabIndex = 2;
            this.Conditions.Text = "Conditions";
            this.Conditions.UseVisualStyleBackColor = false;
            this.Conditions.Click += new System.EventHandler(this.Conditions_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Rules.Location = new System.Drawing.Point(83, 187);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(93, 44);
            this.Rules.TabIndex = 3;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rule_Name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.Location = new System.Drawing.Point(253, 81);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(271, 212);
            this.Data.TabIndex = 4;
            this.Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellDoubleClick);
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
            // Rule_Name
            // 
            this.Rule_Name.HeaderText = "Rule Name";
            this.Rule_Name.MinimumWidth = 6;
            this.Rule_Name.Name = "Rule_Name";
            this.Rule_Name.ReadOnly = true;
            this.Rule_Name.Width = 125;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(12, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 13;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Rules_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 332);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Conditions);
            this.Controls.Add(this.New_User);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Rules_List";
            this.Text = "Rules_List";
            this.Load += new System.EventHandler(this.Rules_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button New_User;
        private System.Windows.Forms.Button Conditions;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule_Name;
        private System.Windows.Forms.Button Back;
    }
}