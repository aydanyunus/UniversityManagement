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
    public partial class ScoreTable : Form
    {
        UniversityEntities db = new UniversityEntities();
        Student activestudent { get; set; }
        public ScoreTable(Student stu)
        {
            InitializeComponent();
            activestudent = stu;
        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
            dgwScore.DataSource = db.Scores.Where(stu => stu.Student_id == activestudent.id).Select(stu => new
            {
                name = stu.Student.FirstName,
                subject = stu.Subject.Name,
                before_exam_score = stu.Before_exam_score,
                after_exam_score = stu.After_exam_score

            }).ToList();
        }
    }
}
