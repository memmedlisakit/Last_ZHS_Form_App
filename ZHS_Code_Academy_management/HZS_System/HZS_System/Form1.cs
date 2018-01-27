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
    public partial class Form1 : Form
    {
        NewDBEntities db = new NewDBEntities();
        Teacher teacher;
        Mentor mentor;
        Admin admin;
        Student student;

        public Form1()
        {
            InitializeComponent();
            this.btn_login.Click += new EventHandler(this.Login);
        }

        private void Login(object sender, EventArgs e)
        {
            string password = Extentions.getHashCode(this.txt_password.Text);
            string email = this.txt_email.Text;
            this.admin = db.Admins.FirstOrDefault(a => a.email == email && a.password == password);
            this.student = db.Students.FirstOrDefault(s => s.student_email == email && s.student_password == password);
            this.mentor = db.Mentors.FirstOrDefault(m => m.mentor_email == email && m.mentor_password == password);
            this.teacher = db.Teachers.FirstOrDefault(t => t.teacher_email == email && t.teacher_password == password);

           
            if (admin != null)
            {
                AdminPanelForm form = new AdminPanelForm();
                form.ShowDialog();
            }
            else if (student != null)
            {
                new StudentProfilForm(student).ShowDialog();

            }
            else if (mentor != null)
            {
                new ProfileForm(mentor).ShowDialog();
            }
            else if (teacher != null)
            {

                new ProfileForm(teacher).ShowDialog();
            }
            else
            {
                this.lblError.Text = "Email or Password incorrect";
            }
        }
    }
}