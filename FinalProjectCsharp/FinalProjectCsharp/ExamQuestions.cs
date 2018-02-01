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
    public partial class ExamQuestions : Form
    {
        UniversityEntities db = new UniversityEntities();
        int selectedSubject { get; set; }
        Score selectedScore;
        Student activeStudent { get; set; }
        List<Exam> questions = new List<Exam>();
        List<string> Answers = new List<string>();
        int i = 0;
        RadioButton selectedRadio = new RadioButton();

        public ExamQuestions(Student stu, int sb)
        {
            InitializeComponent();
            activeStudent = stu;
            selectedSubject = sb;
        }

        private void ExamQuestions_Load(object sender, EventArgs e)
        {
            questions = db.Exams.Where(ex => ex.Subject_id == selectedSubject).ToList();

            for(var i = 0; i <= 3; i++)
            {
                Answers.Insert(i, null);
            }

            Questions();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if(selectedRadio !=null)
            {
                string stuanswer = selectedRadio.Text;
                Answers[i] = stuanswer;
            }
           

            if (Answers[i] != null)
            {
                radioButtonSelector(Answers[i]);
            }

            i++;

            Questions();
            btnPre.Visible = true;

            if (i == questions.Count -1)
            {
                btnNext.Visible = false;
                btnSubmit.Visible = true;
            }
            Radiochecked();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = false;
            
            i--;
            Questions();
            btnNext.Visible = true;

            if (i == 0)
            {
                btnPre.Visible = false;
            }

            if (Answers[i] != null)
            {
                radioButtonSelector(Answers[i]);
            }
        }                

        private void Questions()
        {
            lblquestion.Text = questions[i].Question;

            rbtnA.Text = questions[i].A;
            rbtnB.Text = questions[i].B;
            rbtnC.Text = questions[i].C;
            rbtnD.Text = questions[i].D;
            rbtnE.Text = questions[i].E;
        }

        private void Radiochecked()
        {
            selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
            if (selectedRadio != null)
            {
                selectedRadio.Checked = false;
            }
        }

        private void radioButtonSelector(string userAnswer)
        {
            foreach (var rd in groupBox1.Controls.OfType<RadioButton>())
            {
                if ((rd.Text == userAnswer))
                {
                    rd.Checked = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string stuanswer = selectedRadio.Text;
            Answers[i] = stuanswer;

            int score = 0;
            for(var j = 0; j< questions.Count; j++)
            {
                if (Answers[j] == questions[j].A)
                {
                    score += 12;
                }
            }
            MessageBox.Show("your exam score is" + score.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int Scoreid = (int)db.Scores.First(sc => sc.Student_id == activeStudent.id && sc.Subject_id == selectedSubject).id;
            selectedScore = db.Scores.Find(Scoreid);
            selectedScore.After_exam_score = (short)score;
            db.SaveChanges();
            this.Close();
        }

    }
}
