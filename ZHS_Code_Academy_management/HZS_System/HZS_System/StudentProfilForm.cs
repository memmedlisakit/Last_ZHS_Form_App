using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZS_System
{
    public partial class StudentProfilForm : Form
    {
        NewDBEntities db = new NewDBEntities();
        Student selectedStu;
        string password;
        double average;
        public StudentProfilForm(Student stu)
        {
            selectedStu = stu;
            InitializeComponent();
            this.lbl_settings.Click += new EventHandler(this.Update);
        }

        private void Update(object sender, EventArgs e)
        {
            Student stu = db.Students.Find(selectedStu.id);
            password = Interaction.InputBox("Enter your old password");
           
            if (stu.student_password == Extentions.getHashCode(password))
            {
                this.txt_email.Text = stu.student_email;
                this.txt_password.Text = password;
                this.lbl_error.Text = "";
                this.setting_group.Visible = true;
            }
            else
            {
                this.lbl_error.Text = "Password incorrect";
            }
            
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Student stu = db.Students.Find(selectedStu.id);
            stu.student_email = this.txt_email.Text;
            stu.student_password = Extentions.getHashCode(this.txt_password.Text);
            db.SaveChanges();
            this.lbl_email.Text = stu.student_email;
            this.setting_group.Visible = false;
            this.txt_password.Text = "";
            this.txt_email.Text = "";
            
        }

        private void StudentProfilForm_Load(object sender, EventArgs e)
        {
            Student stu = db.Students.Find(selectedStu.id);
            this.lbl_account.Text = stu.student_github_account;
            this.lbl_cap_point.Text = stu.student_cap_point + "";
            this.lbl_email.Text = stu.student_email;
            this.lbl_gender.Text = stu.Gender.gender_name;
            this.lbl_group.Text = stu.Group.group_name;
            this.lbl_name.Text = stu.student_name;
            this.lbl_phone.Text = stu.student_phone;
            this.lbl_surname.Text = stu.student_surname;
            this.txt_info.Text = stu.student_info;
            this.txt_info.ReadOnly = true;
            this.pct_student.Image = Image.FromFile(Extentions.uploads_path + stu.student_photo);



            List<Task> tasks = db.Tasks.Where(t => t.task_student_id == selectedStu.id).ToList();
            for (int i = 0; i < tasks.Count; i++)
            {
                this.average += tasks[i].task_point;
                this.dgw_tasks.Rows.Add();
                this.dgw_tasks.Rows[i].Cells[0].Value = tasks[i].Task_types.task_type_name;
                this.dgw_tasks.Rows[i].Cells[1].Value = tasks[i].task_start_date.ToShortDateString();
                this.dgw_tasks.Rows[i].Cells[2].Value = tasks[i].task_end_date.ToShortDateString();
                this.dgw_tasks.Rows[i].Cells[3].Value = tasks[i].task_point;
                this.dgw_tasks.Rows[i].Cells[4].Value = tasks[i].task_note;

            }

            List<int> task_types = new List<int>();


            foreach (Task item in tasks)
            {
                if (!task_types.Contains(item.task_type_id))
                {
                    task_types.Add(item.task_type_id);
                }
            }


            int count = 0;
            double sum = 0;
            double cap_point = 0;
            double rate = 0;
            double average = 0;
            foreach (int item in task_types)
            {
                count = tasks.Where(t => t.task_type_id == item).Count();
                sum = tasks.Where(t => t.task_type_id == item).Select(t => t.task_point).Sum();
                rate = db.Task_types.First(t => t.id == item).task_type_rate;
                average += (sum / count) * rate;
                cap_point = average * 0.05;
            }

            this.lbl_average.Text = Math.Round(average, 2).ToString();

            this.lbl_cap_point.Text = Math.Round(cap_point, 2).ToString();

            selectedStu.student_cap_point = cap_point;
            db.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(this.dgw_tasks, sfd.FileName);
            }
        }
    }
}
