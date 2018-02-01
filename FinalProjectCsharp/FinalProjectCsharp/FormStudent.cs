using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectCsharp.Model;

namespace FinalProjectCsharp
{
    public partial class FormStudent : Form
    {
        UniversityEntities db = new UniversityEntities();

        Student activeStudent { get; set; }
        

        public FormStudent(Student st)
        {
            InitializeComponent();
            activeStudent = st;
        }


        private void FormStudent_Load(object sender, EventArgs e)
        {

            txtEmail.Text = activeStudent.Email;
            dtBD.Value = (DateTime)activeStudent.Birthdate;
        }

        private void editYourProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblemail.Visible = true;
            lblBD.Visible = true;
            txtEmail.Visible = true;
            dtBD.Visible = true;
            btnEdit.Visible = true;
            btncancel.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            var bd = dtBD.Value;

            lblerror.Visible = false;

            if (email != string.Empty && bd != null)
            {
                Student exitstudentemail = db.Students.FirstOrDefault(stu => stu.Email == email);
                if(exitstudentemail == null)
                {
                    var student = db.Students.Find(activeStudent.id);
                    student.Email = email;
                    student.Birthdate = bd;
                    db.SaveChanges();
                    MessageBox.Show("your profile edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblemail.Visible = false;
                    lblBD.Visible = false;
                    txtEmail.Visible = false;
                    dtBD.Visible = false;
                    btnEdit.Visible = false;
                    btncancel.Visible = false;

                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "this email already exists.";
                }                
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "please fill all the fields.";
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            lblemail.Visible = false;
            lblBD.Visible = false;
            txtEmail.Visible = false;
            dtBD.Visible = false;
            btnEdit.Visible = false;
            btncancel.Visible = false;
            txtEmail.Text = activeStudent.Email;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScoreTable score = new ScoreTable(activeStudent);
            score.ShowDialog();
            this.Close();
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExam ex = new FormExam(activeStudent);
            ex.ShowDialog();
            this.Close();
        }
    }
}
