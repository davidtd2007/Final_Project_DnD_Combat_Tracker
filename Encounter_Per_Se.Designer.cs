
namespace dnd
{
    partial class Encounter_Per_Se
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Save = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridView();
            this.Creature_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inititative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximun_HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creature_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curren_HP_text = new System.Windows.Forms.TextBox();
            this.maximum_HP_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.TextBox();
            this.Heal = new System.Windows.Forms.Button();
            this.Damage = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Statblock = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Turn_label = new System.Windows.Forms.Label();
            this.Round_label = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turn_of_Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Round_To_Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Condition = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ST = new System.Windows.Forms.PictureBox();
            this.Tota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save.Location = new System.Drawing.Point(930, 17);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 74);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(178, 43);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(132, 48);
            this.Title.TabIndex = 4;
            this.Title.Text = "label1";
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Creature_ID,
            this.creature_name,
            this.Inititative,
            this.AC,
            this.Current_HP,
            this.Maximun_HP,
            this.Creature_Type,
            this.List_ID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Data.Location = new System.Drawing.Point(56, 94);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(821, 206);
            this.Data.TabIndex = 8;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellClick);
            // 
            // Creature_ID
            // 
            this.Creature_ID.HeaderText = "Creature_ID";
            this.Creature_ID.MinimumWidth = 6;
            this.Creature_ID.Name = "Creature_ID";
            this.Creature_ID.ReadOnly = true;
            this.Creature_ID.Visible = false;
            this.Creature_ID.Width = 125;
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
            // Inititative
            // 
            this.Inititative.HeaderText = "Initiative";
            this.Inititative.MinimumWidth = 6;
            this.Inititative.Name = "Inititative";
            this.Inititative.ReadOnly = true;
            this.Inititative.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Inititative.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Inititative.Width = 125;
            // 
            // AC
            // 
            this.AC.HeaderText = "AC";
            this.AC.MinimumWidth = 6;
            this.AC.Name = "AC";
            this.AC.ReadOnly = true;
            this.AC.Width = 125;
            // 
            // Current_HP
            // 
            this.Current_HP.HeaderText = "Current HP";
            this.Current_HP.MinimumWidth = 6;
            this.Current_HP.Name = "Current_HP";
            this.Current_HP.ReadOnly = true;
            this.Current_HP.Width = 125;
            // 
            // Maximun_HP
            // 
            this.Maximun_HP.HeaderText = "Maximun HP";
            this.Maximun_HP.MinimumWidth = 6;
            this.Maximun_HP.Name = "Maximun_HP";
            this.Maximun_HP.ReadOnly = true;
            this.Maximun_HP.Width = 125;
            // 
            // Creature_Type
            // 
            this.Creature_Type.HeaderText = "Creature_Type";
            this.Creature_Type.MinimumWidth = 6;
            this.Creature_Type.Name = "Creature_Type";
            this.Creature_Type.ReadOnly = true;
            this.Creature_Type.Visible = false;
            this.Creature_Type.Width = 125;
            // 
            // List_ID
            // 
            this.List_ID.HeaderText = "List_ID";
            this.List_ID.MinimumWidth = 6;
            this.List_ID.Name = "List_ID";
            this.List_ID.Visible = false;
            this.List_ID.Width = 125;
            // 
            // curren_HP_text
            // 
            this.curren_HP_text.Location = new System.Drawing.Point(935, 146);
            this.curren_HP_text.Name = "curren_HP_text";
            this.curren_HP_text.ReadOnly = true;
            this.curren_HP_text.Size = new System.Drawing.Size(72, 22);
            this.curren_HP_text.TabIndex = 9;
            // 
            // maximum_HP_text
            // 
            this.maximum_HP_text.Location = new System.Drawing.Point(935, 169);
            this.maximum_HP_text.Name = "maximum_HP_text";
            this.maximum_HP_text.ReadOnly = true;
            this.maximum_HP_text.Size = new System.Drawing.Size(72, 22);
            this.maximum_HP_text.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(913, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current HP";
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(1057, 162);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(72, 22);
            this.Modifier.TabIndex = 13;
            this.Modifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Modifier_KeyPress);
            // 
            // Heal
            // 
            this.Heal.BackColor = System.Drawing.Color.Lime;
            this.Heal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heal.Location = new System.Drawing.Point(1046, 98);
            this.Heal.Name = "Heal";
            this.Heal.Size = new System.Drawing.Size(108, 46);
            this.Heal.TabIndex = 14;
            this.Heal.Text = "Heal";
            this.Heal.UseVisualStyleBackColor = false;
            this.Heal.Click += new System.EventHandler(this.Heal_Click);
            // 
            // Damage
            // 
            this.Damage.BackColor = System.Drawing.Color.Red;
            this.Damage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Damage.Location = new System.Drawing.Point(1046, 196);
            this.Damage.Name = "Damage";
            this.Damage.Size = new System.Drawing.Size(108, 46);
            this.Damage.TabIndex = 15;
            this.Damage.Text = "Damage";
            this.Damage.UseVisualStyleBackColor = false;
            this.Damage.Click += new System.EventHandler(this.Damage_Click);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Undo.Location = new System.Drawing.Point(883, 259);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(81, 34);
            this.Undo.TabIndex = 16;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Next.Location = new System.Drawing.Point(883, 219);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(81, 34);
            this.Next.TabIndex = 17;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Statblock
            // 
            this.Statblock.Location = new System.Drawing.Point(35, 392);
            this.Statblock.Name = "Statblock";
            this.Statblock.Size = new System.Drawing.Size(80, 40);
            this.Statblock.TabIndex = 18;
            this.Statblock.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(349, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Turn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(105, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Round";
            // 
            // Turn_label
            // 
            this.Turn_label.AutoSize = true;
            this.Turn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Turn_label.Location = new System.Drawing.Point(475, 430);
            this.Turn_label.Name = "Turn_label";
            this.Turn_label.Size = new System.Drawing.Size(69, 25);
            this.Turn_label.TabIndex = 21;
            this.Turn_label.Text = "Round";
            // 
            // Round_label
            // 
            this.Round_label.AutoSize = true;
            this.Round_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Round_label.Location = new System.Drawing.Point(230, 430);
            this.Round_label.Name = "Round_label";
            this.Round_label.Size = new System.Drawing.Size(69, 25);
            this.Round_label.TabIndex = 22;
            this.Round_label.Text = "Round";
            // 
            // Status
            // 
            this.Status.AllowUserToAddRows = false;
            this.Status.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Status.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.duration_time,
            this.Duration_Type,
            this.Turn_of_Round,
            this.Round_To_Hide});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.GridColor = System.Drawing.SystemColors.Control;
            this.Status.Location = new System.Drawing.Point(23, 310);
            this.Status.Name = "Status";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Status.RowHeadersWidth = 51;
            this.Status.RowTemplate.Height = 24;
            this.Status.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Status.Size = new System.Drawing.Size(619, 117);
            this.Status.TabIndex = 23;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // duration_time
            // 
            this.duration_time.HeaderText = "Duration";
            this.duration_time.MinimumWidth = 6;
            this.duration_time.Name = "duration_time";
            this.duration_time.ReadOnly = true;
            this.duration_time.Width = 125;
            // 
            // Duration_Type
            // 
            this.Duration_Type.HeaderText = "Duration Type";
            this.Duration_Type.MinimumWidth = 6;
            this.Duration_Type.Name = "Duration_Type";
            this.Duration_Type.ReadOnly = true;
            this.Duration_Type.Width = 125;
            // 
            // Turn_of_Round
            // 
            this.Turn_of_Round.HeaderText = "Turn_of_Round";
            this.Turn_of_Round.MinimumWidth = 6;
            this.Turn_of_Round.Name = "Turn_of_Round";
            this.Turn_of_Round.Visible = false;
            this.Turn_of_Round.Width = 125;
            // 
            // Round_To_Hide
            // 
            this.Round_To_Hide.HeaderText = "Round_To_Hide";
            this.Round_To_Hide.MinimumWidth = 6;
            this.Round_To_Hide.Name = "Round_To_Hide";
            this.Round_To_Hide.Visible = false;
            this.Round_To_Hide.Width = 125;
            // 
            // Add_Condition
            // 
            this.Add_Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Condition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_Condition.Location = new System.Drawing.Point(648, 350);
            this.Add_Condition.Name = "Add_Condition";
            this.Add_Condition.Size = new System.Drawing.Size(81, 34);
            this.Add_Condition.TabIndex = 24;
            this.Add_Condition.Text = "Add Condition";
            this.Add_Condition.UseVisualStyleBackColor = false;
            this.Add_Condition.Click += new System.EventHandler(this.Add_Condition_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.Location = new System.Drawing.Point(648, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 34);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ST
            // 
            this.ST.Location = new System.Drawing.Point(12, 458);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(1141, 855);
            this.ST.TabIndex = 26;
            this.ST.TabStop = false;
            // 
            // Tota
            // 
            this.Tota.AutoSize = true;
            this.Tota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tota.Location = new System.Drawing.Point(913, 196);
            this.Tota.Name = "Tota";
            this.Tota.Size = new System.Drawing.Size(110, 20);
            this.Tota.TabIndex = 29;
            this.Tota.Text = "Maximum HP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::dnd.Properties.Resources.d20_icon_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(95, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 76);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dice_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Help.BackgroundImage = global::dnd.Properties.Resources.help__v1;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Help.Location = new System.Drawing.Point(12, 16);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(77, 76);
            this.Help.TabIndex = 31;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Encounter_Per_Se
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1248, 1325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Tota);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add_Condition);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Round_label);
            this.Controls.Add(this.Turn_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Statblock);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Damage);
            this.Controls.Add(this.Heal);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maximum_HP_text);
            this.Controls.Add(this.curren_HP_text);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Title);
            this.Name = "Encounter_Per_Se";
            this.Text = "Encounter";
            this.Load += new System.EventHandler(this.Encounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.TextBox curren_HP_text;
        private System.Windows.Forms.TextBox maximum_HP_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Modifier;
        private System.Windows.Forms.Button Heal;
        private System.Windows.Forms.Button Damage;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.PictureBox Statblock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Turn_label;
        private System.Windows.Forms.Label Round_label;
        private System.Windows.Forms.DataGridView Status;
        private System.Windows.Forms.Button Add_Condition;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox ST;
        private System.Windows.Forms.Label Tota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ceature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creature_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn creature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inititative;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximun_HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creature_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turn_of_Round;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round_To_Hide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
    }
}
