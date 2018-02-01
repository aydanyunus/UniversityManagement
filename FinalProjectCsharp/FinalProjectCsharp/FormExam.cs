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
    public partial class FormExam : Form
    {
        UniversityEntities db = new UniversityEntities();
        Student activestudent { get; set; }
        int subjectid;


        public FormExam(Student student)
        {
            InitializeComponent();
            activestudent = student;
        }

        private void FormExam_Load(object sender, EventArgs e)
        {
            lbl.Text = "Dear " + activestudent.FullName + " Please Select subject down below";
            FillComboSubject();
        }

        private void FillComboSubject()
        {
            cmbSub.Items.Clear();
            cmbSub.Items.AddRange(db.Scores.Where(stu => stu.Student_id == activestudent.id).Select(sb => sb.Subject.Name).ToArray());           

        }

        private void cmbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectid = db.Subjects.FirstOrDefault(sb => sb.Name == cmbSub.Text).id;

            int score = (int)db.Scores.FirstOrDefault(sb => sb.Subject_id == subjectid && sb.Student_id == activestudent.id).Before_exam_score;
            var afterscore = db.Scores.First(sb => sb.Subject_id == subjectid && sb.Student_id == activestudent.id).After_exam_score;

            if(score < 15)
            {
                btnexam.Visible = false;
                lblerror.Visible = true;
                lblerror.Text = "your score is low to enter this exam.";

            }else if(afterscore != null)
            {
                lblerror.Visible = true;
                lblerror.Text = "you entered this exam once before.";
            }
            else
            {
                lblerror.Visible = false;
                btnexam.Visible = true;
            }
        }

        private void btnexam_Click(object sender, EventArgs e)
        {
            ExamQuestions eq = new ExamQuestions(activestudent, subjectid);
            eq.ShowDialog();
            this.Close();
        }
    }
}
