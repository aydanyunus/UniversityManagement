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
    public partial class GroupToTeacher : Form
    {
        UniversityEntities db = new UniversityEntities();

        public GroupToTeacher()
        {
            InitializeComponent();
        }

        private void GroupToTeacher_Load(object sender, EventArgs e)
        {
            FillComboTeachers();
            FillComboGroups();
        }


        private void FillComboTeachers()
        {
            cmbTeacherName.Items.Clear();
            cmbTeacherName.Items.AddRange(db.Teachers.Select(tc => tc.FullName).ToArray());
        }

        private void FillComboGroups()
        {
            cmbGroup.Items.Clear();
            cmbGroup.Items.AddRange(db.Groups.Select(gp => gp.Name).ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string teachername = cmbTeacherName.Text;
            string groupname = cmbGroup.Text;

            if(teachername != string.Empty && groupname != string.Empty)
            {
                lblerror.Visible = false;
                TG tgs = new TG();
                tgs.Teacher_id = db.Teachers.First(tc => tc.FullName == teachername).id;
                tgs.Group_id = db.Groups.First(gp => gp.Name == groupname).id;
                db.TGS.Add(tgs);
                db.SaveChanges();
                MessageBox.Show(groupname + "was added to" + teachername, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTeacherName.Text = "";
                cmbGroup.Text = "";
                this.Close();

            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "please fill all the fields.";
            }
        }
    }
}
