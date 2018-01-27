namespace HZS_System
{
    partial class TaskPanel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPanel2));
            this.cmb_student = new System.Windows.Forms.ComboBox();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.txt_point = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btm_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_task_type = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_student
            // 
            this.cmb_student.BackColor = System.Drawing.Color.SeaShell;
            this.cmb_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_student.FormattingEnabled = true;
            this.cmb_student.Location = new System.Drawing.Point(587, 175);
            this.cmb_student.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_student.Name = "cmb_student";
            this.cmb_student.Size = new System.Drawing.Size(189, 28);
            this.cmb_student.TabIndex = 44;
            // 
            // cmb_group
            // 
            this.cmb_group.BackColor = System.Drawing.Color.SeaShell;
            this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(587, 131);
            this.cmb_group.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(189, 28);
            this.cmb_group.TabIndex = 43;
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.SeaShell;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(202, 87);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(189, 28);
            this.cmb_type.TabIndex = 42;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Courier New", 28.09091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(365, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 43);
            this.label9.TabIndex = 41;
            this.label9.Text = "TASKS";
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.Color.SeaShell;
            this.txt_note.Location = new System.Drawing.Point(202, 266);
            this.txt_note.Margin = new System.Windows.Forms.Padding(1);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(189, 80);
            this.txt_note.TabIndex = 40;
            this.txt_note.Text = "";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Linen;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(655, 280);
            this.btn_update.Margin = new System.Windows.Forms.Padding(1);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 34);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(559, 280);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 34);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_source
            // 
            this.txt_source.BackColor = System.Drawing.Color.SeaShell;
            this.txt_source.Location = new System.Drawing.Point(587, 91);
            this.txt_source.Margin = new System.Windows.Forms.Padding(1);
            this.txt_source.Multiline = true;
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(189, 25);
            this.txt_source.TabIndex = 37;
            // 
            // txt_point
            // 
            this.txt_point.BackColor = System.Drawing.Color.SeaShell;
            this.txt_point.Location = new System.Drawing.Point(202, 224);
            this.txt_point.Margin = new System.Windows.Forms.Padding(1);
            this.txt_point.Multiline = true;
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(189, 25);
            this.txt_point.TabIndex = 36;
            // 
            // end_date
            // 
            this.end_date.CustomFormat = "dd/MMMM/yyyy";
            this.end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(202, 177);
            this.end_date.Margin = new System.Windows.Forms.Padding(1);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(189, 24);
            this.end_date.TabIndex = 35;
            // 
            // start_date
            // 
            this.start_date.CustomFormat = "dd/MMMM/yyyy";
            this.start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date.Location = new System.Drawing.Point(202, 138);
            this.start_date.Margin = new System.Windows.Forms.Padding(1);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(189, 24);
            this.start_date.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(478, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Student ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(478, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Group ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(479, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "End Date";
            // 
            // dgv_task
            // 
            this.dgv_task.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_task.Location = new System.Drawing.Point(58, 393);
            this.dgv_task.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.RowTemplate.Height = 42;
            this.dgv_task.Size = new System.Drawing.Size(849, 192);
            this.dgv_task.TabIndex = 26;
            this.dgv_task.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.btn_delete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Point";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Source";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Note";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Group ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Student ";
            this.Column9.Name = "Column9";
            // 
            // btm_save
            // 
            this.btm_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btm_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_save.Location = new System.Drawing.Point(463, 280);
            this.btm_save.Margin = new System.Windows.Forms.Padding(1);
            this.btm_save.Name = "btm_save";
            this.btm_save.Size = new System.Drawing.Size(84, 34);
            this.btm_save.TabIndex = 25;
            this.btm_save.Text = "SAVE";
            this.btm_save.UseVisualStyleBackColor = false;
            this.btm_save.Click += new System.EventHandler(this.btm_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Task Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_task_type
            // 
            this.btn_task_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_task_type.FlatAppearance.BorderSize = 0;
            this.btn_task_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_task_type.ForeColor = System.Drawing.Color.White;
            this.btn_task_type.Location = new System.Drawing.Point(840, 25);
            this.btn_task_type.Name = "btn_task_type";
            this.btn_task_type.Size = new System.Drawing.Size(100, 23);
            this.btn_task_type.TabIndex = 46;
            this.btn_task_type.Text = "Task Type";
            this.btn_task_type.UseVisualStyleBackColor = false;
            this.btn_task_type.Click += new System.EventHandler(this.btn_task_type_Click);
            // 
            // TaskPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 613);
            this.Controls.Add(this.btn_task_type);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_student);
            this.Controls.Add(this.cmb_group);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_task);
            this.Controls.Add(this.btm_save);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TaskPanel2";
            this.Text = "TaskPanel2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        public System.Windows.Forms.ComboBox cmb_student;
        public System.Windows.Forms.ComboBox cmb_group;
        public System.Windows.Forms.ComboBox cmb_type;
        public System.Windows.Forms.RichTextBox txt_note;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.TextBox txt_source;
        public System.Windows.Forms.TextBox txt_point;
        public System.Windows.Forms.DateTimePicker end_date;
        public System.Windows.Forms.DateTimePicker start_date;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btm_save;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_task_type;
    }
}