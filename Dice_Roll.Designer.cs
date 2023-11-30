
namespace dnd
{
    partial class Dice_Roll
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
            this.dice_Type_Text = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dice_Number_Text = new System.Windows.Forms.TextBox();
            this.modifier_Text = new System.Windows.Forms.TextBox();
            this.result_text = new System.Windows.Forms.TextBox();
            this.Roll = new System.Windows.Forms.Button();
            this.Advantage = new System.Windows.Forms.CheckBox();
            this.Disadvantage = new System.Windows.Forms.CheckBox();
            this.Num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dice_Type_Text
            // 
            this.dice_Type_Text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dice_Type_Text.FormattingEnabled = true;
            this.dice_Type_Text.Location = new System.Drawing.Point(284, 144);
            this.dice_Type_Text.Name = "dice_Type_Text";
            this.dice_Type_Text.Size = new System.Drawing.Size(104, 24);
            this.dice_Type_Text.TabIndex = 29;
            this.dice_Type_Text.SelectedIndexChanged += new System.EventHandler(this.dice_Type_Text_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 48);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dice Roller";
            // 
            // dice_Number_Text
            // 
            this.dice_Number_Text.Location = new System.Drawing.Point(85, 144);
            this.dice_Number_Text.Name = "dice_Number_Text";
            this.dice_Number_Text.Size = new System.Drawing.Size(100, 22);
            this.dice_Number_Text.TabIndex = 30;
            this.dice_Number_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dice_Number_Text_KeyPress);
            // 
            // modifier_Text
            // 
            this.modifier_Text.Location = new System.Drawing.Point(458, 144);
            this.modifier_Text.Name = "modifier_Text";
            this.modifier_Text.Size = new System.Drawing.Size(100, 22);
            this.modifier_Text.TabIndex = 31;
            this.modifier_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modifier_Text_KeyPress);
            // 
            // result_text
            // 
            this.result_text.Enabled = false;
            this.result_text.Location = new System.Drawing.Point(640, 144);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(100, 22);
            this.result_text.TabIndex = 32;
            // 
            // Roll
            // 
            this.Roll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Roll.Location = new System.Drawing.Point(330, 190);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(129, 71);
            this.Roll.TabIndex = 33;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = false;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // Advantage
            // 
            this.Advantage.AutoSize = true;
            this.Advantage.Location = new System.Drawing.Point(415, 47);
            this.Advantage.Name = "Advantage";
            this.Advantage.Size = new System.Drawing.Size(98, 21);
            this.Advantage.TabIndex = 34;
            this.Advantage.Text = "Advantage";
            this.Advantage.UseVisualStyleBackColor = true;
            this.Advantage.CheckedChanged += new System.EventHandler(this.Advantage_CheckedChanged);
            // 
            // Disadvantage
            // 
            this.Disadvantage.AutoSize = true;
            this.Disadvantage.Location = new System.Drawing.Point(547, 47);
            this.Disadvantage.Name = "Disadvantage";
            this.Disadvantage.Size = new System.Drawing.Size(117, 21);
            this.Disadvantage.TabIndex = 35;
            this.Disadvantage.Text = "Disadvantage";
            this.Disadvantage.UseVisualStyleBackColor = true;
            this.Disadvantage.CheckedChanged += new System.EventHandler(this.Disadvantage_CheckedChanged);
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(82, 124);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(109, 17);
            this.Num.TabIndex = 36;
            this.Num.Text = "Number Of Dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dice Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Modifier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "=";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Back.BackgroundImage = global::dnd.Properties.Resources.Back___copia1;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(12, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 76);
            this.Back.TabIndex = 44;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Dice_Roll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Disadvantage);
            this.Controls.Add(this.Advantage);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.modifier_Text);
            this.Controls.Add(this.dice_Number_Text);
            this.Controls.Add(this.dice_Type_Text);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Dice_Roll";
            this.Text = "Dice_Roll";
            this.Load += new System.EventHandler(this.Dice_Roll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dice_Type_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dice_Number_Text;
        private System.Windows.Forms.TextBox modifier_Text;
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.CheckBox Advantage;
        private System.Windows.Forms.CheckBox Disadvantage;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Back;
    }
}