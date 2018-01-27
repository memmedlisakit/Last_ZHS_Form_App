using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZS_System
{
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
        }

        public void Fill_data(List<Student> stu)
        {
            this.dgw_student.Rows.Clear();
            for (int a = 0; a < stu.Count; a++)
            {
                this.dgw_student.Rows.Add();
                this.dgw_student.Rows[a].Cells[0].Value = stu[a].id;
                this.dgw_student.Rows[a].Cells[1].Value = stu[a].student_name;
                this.dgw_student.Rows[a].Cells[2].Value = stu[a].student_surname;
                this.dgw_student.Rows[a].Cells[3].Value = stu[a].student_email;
                this.dgw_student.Rows[a].Cells[4].Value = stu[a].student_cap_point;
                this.dgw_student.Rows[a].Cells[5].Value = stu[a].student_phone;
                this.dgw_student.Rows[a].Cells[6].Value = stu[a].Gender.gender_name;
                this.dgw_student.Rows[a].Cells[7].Value = stu[a].Group.group_name;
                this.dgw_student.Rows[a].Cells[8].Value = stu[a].student_github_account;
                this.dgw_student.Rows[a].Cells[9].Value = stu[a].student_info;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(this.dgw_student, sfd.FileName);
            }
        }


    }
}
