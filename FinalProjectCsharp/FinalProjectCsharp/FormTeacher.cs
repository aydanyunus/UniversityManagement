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
    public partial class FormTeacher : Form
    {
        UniversityEntities db = new UniversityEntities();
        Teacher activeteacher { get; set; }
        


        public FormTeacher(Teacher tch)
        {
            InitializeComponent();
            activeteacher = tch;
      
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = string.Format("Welcome, {0} {1}", activeteacher.FirstName, activeteacher.LastName);

            txtEmail.Text = activeteacher.Email;
            dtBD.Value = (DateTime)activeteacher.Birthdate;

            FillDataGridStudents();
            FillComboGroups();
            FillComboSubjects();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblemail.Visible = true;
            lblBD.Visible = true;
            txtEmail.Visible = true;
            dtBD.Visible = true;
            btnEdit.Visible = true;
            btncancel.Visible = true;
            dgwStudents.Visible = false;
            lblstudent.Visible = false;
            lblsubject.Visible = false;
            lblgroup.Visible = false;
            lblbefore.Visible = false;
            cmbSubject.Visible = false;
            txtBefore.Visible = false;
            cmbGroup.Visible = false;
            cmbStudent.Visible = false;
            btnSubmit.Visible = false;
            lblerrorAdd.Visible = false;
            btnclose.Visible = false;
            cmbGroup.Text = "";
            cmbStudent.Text = "";
            cmbSubject.Text = "";
            txtBefore.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {          

            string email = txtEmail.Text;
            var bd = dtBD.Value;

            lblerror.Visible = false;

            if (email != string.Empty && bd != null)
            {
                Teacher exitteacheremail = db.Teachers.FirstOrDefault(t => t.Email == email);
                if(exitteacheremail == null)
                {
                    var teacher = db.Teachers.Find(activeteacher.id);
                    teacher.Email = email;
                    teacher.Birthdate = bd;
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

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblstudent.Visible = true;
            lblsubject.Visible = true;
            lblgroup.Visible = true;
            lblbefore.Visible = true;
            cmbSubject.Visible = true;
            txtBefore.Visible = true;
            cmbGroup.Visible = true;
            cmbStudent.Visible = true;
            btnSubmit.Visible = true;
            btnclose.Visible = true;
            dgwStudents.Visible = true;
            lblerrorAdd.Visible = false;
            FillDataGridStudents();
            FillComboGroups();
            lblemail.Visible = false;
            lblBD.Visible = false;
            txtEmail.Visible = false;
            dtBD.Visible = false;
            btnEdit.Visible = false;
            btncancel.Visible = false;
            lblerror.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {                
            string group = cmbGroup.Text;
            string student = cmbStudent.Text;
            string subject = cmbSubject.Text;
            string beforeexam = txtBefore.Text;
            short beforeexamShort;

            if(group != string.Empty &&
                student != string.Empty &&
                subject != string.Empty &&
                beforeexam != string.Empty)
            {
                if(short.TryParse(beforeexam, out beforeexamShort))
                {
                    if (beforeexam.Length == 2 && beforeexamShort <= 50)
                    {
                        lblerrorAdd.Visible = false;
                        Score existstu = db.Scores.Where(stu => stu.Student.FullName == student
                        && stu.Subject.Name == subject).FirstOrDefault();
                        if(existstu != null)
                        {
                            dgwStudents.DataSource = db.Scores.Where(st => st.Student.FullName == student).Select(st => new
                            {
                                student = st.Student.FullName,
                                subject = st.Subject.Name,
                                beforeexam = st.Before_exam_score
                            }).ToList();

                            db.Scores.First(sc => sc.Student.FullName == student &&
                            sc.Subject.Name == subject).Before_exam_score = beforeexamShort;
                            db.SaveChanges();
                            MessageBox.Show(student + " 's" + " before exam score is" + beforeexam, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDataGridStudents();
                            cmbGroup.Text = "";
                            cmbStudent.Text = "";
                            cmbSubject.Text = "";
                            txtBefore.Text = "";
                        }
                        else
                        {
                            Score sc = new Score();
                            sc.Student_id = db.Students.First(st => st.FullName == student).id;
                            sc.Subject_id = db.Subjects.First(st => st.Name == subject).id;
                            sc.Before_exam_score = beforeexamShort;
                            db.Scores.Add(sc);
                            db.SaveChanges();
                            MessageBox.Show(student + " 's" + " before exam score is" + beforeexam, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDataGridStudents();
                            cmbGroup.Text = "";
                            cmbStudent.Text = "";
                            cmbSubject.Text = "";
                            txtBefore.Text = "";

                        }                       
                    }
                    else
                    {
                        lblerrorAdd.Visible = true;
                        lblerrorAdd.Text = "exam score length should be at least 2 charachters and under 51.";
                    }                   
                }
                else
                {
                    lblerrorAdd.Visible = true;
                    lblerrorAdd.Text = "exam score can not contain non-numeric charachters";
                }
            }
            else
            {
                lblerrorAdd.Visible = true;
                lblerrorAdd.Text = "please fill all the fields.";

            }
        }

        private void FillDataGridStudents()
        {
            dgwStudents.DataSource = db.Scores.Where(stu => stu.Subject_id == activeteacher.Subject_id).Select(stu => new
            {
                studentName = stu.Student.FirstName + " " + stu.Student.LastName,
                subject = stu.Subject.Name,
                before_exam_score = stu.Before_exam_score
            }).ToList();
        }

        private void FillComboGroups()
        {
            cmbGroup.Items.Clear();
            cmbGroup.Items.AddRange(db.TGS.Where(gp => gp.Teacher_id == activeteacher.id).Select(gp => gp.Group.Name).ToArray());
        }

        private void FillComboStudents(int id)
        {
            cmbStudent.Items.Clear();
            cmbStudent.Items.AddRange(db.Students.Where(gp => gp.Group_id == id).Select(stu => stu.FullName).ToArray());
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupname = cmbGroup.Text;
            int groupid = db.Groups.First(gp => gp.Name == groupname).id;
            FillComboStudents(groupid);
        }

        private void FillComboSubjects()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(db.Subjects.Where(sb => sb.id == activeteacher.Subject_id).Select(sb => sb.Name).Distinct().ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblemail.Visible = false;
            lblBD.Visible = false;
            txtEmail.Visible = false;
            dtBD.Visible = false;
            btnEdit.Visible = false;
            btncancel.Visible = false;
            txtEmail.Text = activeteacher.Email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dgwStudents.Visible = false;
            lblstudent.Visible = false;
            lblsubject.Visible = false;
            lblgroup.Visible = false;
            lblbefore.Visible = false;
            cmbSubject.Visible = false;
            txtBefore.Visible = false;
            cmbGroup.Visible = false;
            cmbStudent.Visible = false;
            btnSubmit.Visible = false;
            lblerrorAdd.Visible = false;
            btnclose.Visible = false;
            cmbGroup.Text = "";
            cmbStudent.Text = "";
            cmbSubject.Text = "";
            txtBefore.Text = "";
        }
    }
}
