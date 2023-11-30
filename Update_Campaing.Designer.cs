
namespace dnd
{
    partial class Update_Campaing
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
            this.Title = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dice = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(116, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Update Campaing";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.ForeColor = System.Drawing.Color.Black;
            this.Description.Location = new System.Drawing.Point(144, 154);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(542, 186);
            this.Description.TabIndex = 1;
            this.Description.Text = "";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(190, 96);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(435, 22);
            this.name.TabIndex = 2;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update.Location = new System.Drawing.Point(366, 357);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(91, 63);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // dice
            // 
            this.dice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dice.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dice.Location = new System.Drawing.Point(95, 357);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(77, 76);
            this.dice.TabIndex = 15;
            this.dice.UseVisualStyleBackColor = false;
            this.dice.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(12, 357);
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
            // Update_Campaing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Update_Campaing";
            this.Text = "Update_Campaing";
            this.Load += new System.EventHandler(this.Update_Campaing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dice;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
    }
}