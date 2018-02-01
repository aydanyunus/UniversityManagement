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
    public partial class HomePage : Form
    {
        UniversityEntities db = new UniversityEntities();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome";
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FormLoginTeacher tch = new FormLoginTeacher();
            tch.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin ad = new FormLoginAdmin();
            ad.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FormLoginStudent stu = new FormLoginStudent();
            stu.ShowDialog();
        }
    }
}
