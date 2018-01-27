using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HZS_System
{
    public partial class ProfileForm : Form
    {
        private NewDBEntities db = new NewDBEntities();
        Mentor mentor;
        Teacher teacher;
        public ProfileForm(Mentor m)
        {
            this.Init();
            mentor = m;
        }
        public ProfileForm(Teacher t)
        {
            this.Init();
            teacher = t;
        }
       
        
        private void Init()
        {
            InitializeComponent();
            this.lbl_settings.Click += new EventHandler(this.Settings);
            this.btn_save.Click += new EventHandler(this.Update);
        }

        private void Settings(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("Enter your password", "Confirem password");
            if (mentor != null)
            {
                Mentor mtr = db.Mentors.Find(mentor.id);
                if (mtr.mentor_password == Extentions.getHashCode(password))
                {
                    this.group.Visible = true;
                    this.txt_mail.Text = mtr.mentor_email;
                    this.txt_password.Text = password;
                    this.lbl_error.Text = "";
                }
                else
                {
                    this.lbl_error.Text = "Password incorrect";
                }
            }
            else if (teacher != null)
            {
                Teacher tchr = db.Teachers.Find(teacher.id);
                if (tchr.teacher_password == Extentions.getHashCode(password))
                {
                    this.group.Visible = true;
                    this.txt_mail.Text = tchr.teacher_email;
                    this.txt_password.Text = password;
                    this.lbl_error.Text = "";
                }
                else
                {
                    this.lbl_error.Text = "Password incorrect";
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (mentor != null)
            {
                Mentor mtr = db.Mentors.Find(mentor.id);

                mtr.mentor_email = this.txt_mail.Text;
                mtr.mentor_password = Extentions.getHashCode(this.txt_password.Text);
                db.SaveChanges();
                this.group.Visible = false;
                this.lbl_email.Text = mtr.mentor_email;
            }
            else if (teacher != null)
            {
                Teacher tchr = db.Teachers.Find(teacher.id);

                tchr.teacher_email = this.txt_mail.Text;
                tchr.teacher_password = Extentions.getHashCode(this.txt_password.Text);
                db.SaveChanges();
                this.group.Visible = false;
                this.lbl_email.Text = tchr.teacher_email;
            }
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            StudentsListForm stu = new StudentsListForm();
            List<Student> students = db.Students.Where(s => s.Group.group_techer_id == teacher.id).ToList();
            stu.Fill_data(students);
            stu.ShowDialog();
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            TaskPanel2 task = new TaskPanel2(teacher);
            List<Group> groups = db.Groups.Where(g => g.group_techer_id == teacher.id).ToList();
            List<Student> students = db.Students.Where(s => s.Group.group_techer_id == teacher.id).ToList();
            task.Fill_cmb(groups, students);
            task.ShowDialog();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (mentor != null)
            {
                string group_name = db.Groups.Where(g=>g.group_mentor_id ==mentor.id).First().group_name;

              

                this.lbl_name.Text = mentor.mentor_name;
                this.lbl_surname.Text = mentor.mentor_surname;
                this.lbl_email.Text = mentor.mentor_email;
                this.lbl_gender.Text = mentor.Gender.gender_name;
                this.lbl_phone.Text = mentor.mentor_phone;
                this.txt_info.Text = mentor.mentor_info;
                this.lbl_group.Text = group_name != "" ? group_name : "No group";
                this.pct_mentor.Image = Image.FromFile(Extentions.uploads_path + mentor.mentor_photo);

            }
            else if (teacher != null)
            {
                string group_name = db.Groups.Where(g=>g.group_techer_id == teacher.id).First().group_name;

               
                this.lbl_name.Text = teacher.teacher_name;
                this.lbl_surname.Text = teacher.teacher_surname;
                this.lbl_email.Text = teacher.teacher_email;
                this.lbl_gender.Text = teacher.Gender.gender_name;
                this.lbl_phone.Text = teacher.teacher_phone;
                this.txt_info.Text = teacher.teacher_info;
                this.lbl_group.Text = group_name != "" ? group_name : "No group";
                this.pct_mentor.Image = Image.FromFile(Extentions.uploads_path + teacher.teacher_photo);
                this.btn_students.Visible = true;
                this.btn_task.Visible = true;
            }
        }
    }
}
