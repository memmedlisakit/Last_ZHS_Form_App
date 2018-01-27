namespace HZS_System
{
    partial class StudentProfilForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.setting_group = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_cap_point = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pct_student = new System.Windows.Forms.PictureBox();
            this.txt_info = new System.Windows.Forms.RichTextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.dgw_tasks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_average = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.setting_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // setting_group
            // 
            this.setting_group.Controls.Add(this.btn_save);
            this.setting_group.Controls.Add(this.txt_password);
            this.setting_group.Controls.Add(this.txt_email);
            this.setting_group.Controls.Add(this.label24);
            this.setting_group.Controls.Add(this.label23);
            this.setting_group.Location = new System.Drawing.Point(530, 306);
            this.setting_group.Margin = new System.Windows.Forms.Padding(1);
            this.setting_group.Name = "setting_group";
            this.setting_group.Padding = new System.Windows.Forms.Padding(1);
            this.setting_group.Size = new System.Drawing.Size(340, 142);
            this.setting_group.TabIndex = 1;
            this.setting_group.TabStop = false;
            this.setting_group.Text = "groupBox1";
            this.setting_group.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(201, 101);
            this.btn_save.Margin = new System.Windows.Forms.Padding(1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 24);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Change";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(120, 69);
            this.txt_password.Margin = new System.Windows.Forms.Padding(1);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(129, 18);
            this.txt_password.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 28);
            this.txt_email.Margin = new System.Windows.Forms.Padding(1);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(129, 18);
            this.txt_email.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 71);
            this.label24.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Password";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 30);
            this.label23.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(19, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(19, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Github Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(521, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1138, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Photo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(521, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(19, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(525, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 27);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cap Point";
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_settings.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_settings.Location = new System.Drawing.Point(978, 57);
            this.lbl_settings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(61, 19);
            this.lbl_settings.TabIndex = 22;
            this.lbl_settings.Text = "Setting...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Bisque;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Gabriola", 25.90909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1077, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 67);
            this.label13.TabIndex = 21;
            this.label13.Text = "STUDENT PROFILE";
            // 
            // lbl_cap_point
            // 
            this.lbl_cap_point.AutoSize = true;
            this.lbl_cap_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cap_point.Location = new System.Drawing.Point(692, 97);
            this.lbl_cap_point.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_cap_point.Name = "lbl_cap_point";
            this.lbl_cap_point.Size = new System.Drawing.Size(53, 17);
            this.lbl_cap_point.TabIndex = 20;
            this.lbl_cap_point.Text = "lbl_cap";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_group.Location = new System.Drawing.Point(688, 35);
            this.lbl_group.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(54, 17);
            this.lbl_group.TabIndex = 18;
            this.lbl_group.Text = "label16";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(234, 373);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(54, 17);
            this.lbl_gender.TabIndex = 17;
            this.lbl_gender.Text = "label17";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(234, 304);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(54, 17);
            this.lbl_account.TabIndex = 16;
            this.lbl_account.Text = "label18";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(234, 232);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(54, 17);
            this.lbl_phone.TabIndex = 15;
            this.lbl_phone.Text = "label19";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(234, 167);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 17);
            this.lbl_email.TabIndex = 14;
            this.lbl_email.Text = "label20";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(234, 102);
            this.lbl_surname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(54, 17);
            this.lbl_surname.TabIndex = 13;
            this.lbl_surname.Text = "label21";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(236, 35);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 17);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "label22";
            // 
            // pct_student
            // 
            this.pct_student.Location = new System.Drawing.Point(1141, 178);
            this.pct_student.Margin = new System.Windows.Forms.Padding(1);
            this.pct_student.Name = "pct_student";
            this.pct_student.Size = new System.Drawing.Size(160, 154);
            this.pct_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_student.TabIndex = 23;
            this.pct_student.TabStop = false;
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(691, 229);
            this.txt_info.Margin = new System.Windows.Forms.Padding(1);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(255, 63);
            this.txt_info.TabIndex = 24;
            this.txt_info.Text = "";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_error.Location = new System.Drawing.Point(21, 533);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 25;
            // 
            // dgw_tasks
            // 
            this.dgw_tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgw_tasks.Location = new System.Drawing.Point(24, 452);
            this.dgw_tasks.Name = "dgw_tasks";
            this.dgw_tasks.Size = new System.Drawing.Size(1277, 195);
            this.dgw_tasks.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Point";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Note";
            this.Column5.Name = "Column5";
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_average.Location = new System.Drawing.Point(688, 172);
            this.lbl_average.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(54, 17);
            this.lbl_average.TabIndex = 28;
            this.lbl_average.Text = "label16";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.ForestGreen;
            this.label12.Location = new System.Drawing.Point(521, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 27);
            this.label12.TabIndex = 27;
            this.label12.Text = "Average";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1220, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1335, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgw_tasks);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.pct_student);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_cap_point);
            this.Controls.Add(this.lbl_group);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setting_group);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StudentProfilForm";
            this.Text = "StudentProfilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentProfilForm_Load);
            this.setting_group.ResumeLayout(false);
            this.setting_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox setting_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label lbl_cap_point;
        public System.Windows.Forms.Label lbl_group;
        public System.Windows.Forms.Label lbl_gender;
        public System.Windows.Forms.Label lbl_account;
        public System.Windows.Forms.Label lbl_phone;
        public System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.Label lbl_surname;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.PictureBox pct_student;
        public System.Windows.Forms.RichTextBox txt_info;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.DataGridView dgw_tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}