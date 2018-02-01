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
    public partial class SubToGroup : Form
    {
        UniversityEntities db = new UniversityEntities();
        public SubToGroup()
        {
            InitializeComponent();
        }

        private void SubToStu_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillComboGroup();
            FillComboSubject();
        }

        private void FillComboGroup ()
        {
            cmbGroup.Items.Clear();
            cmbGroup.Items.AddRange(db.Groups.Select(stu => stu.Name).ToArray());
        }

        private void FillDataGrid()
        {
            dgwTgs.DataSource = db.TGS.Select(sc => new
            {
                Group_Name = sc.Group.Name,
                Subject_Name = sc.Subject.Name
            }).ToList();
        }

        private void FillComboSubject()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(db.Subjects.Select(sb => sb.Name).ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = cmbGroup.Text;
            string subject = cmbSubject.Text;

            if(name != string.Empty && subject != string.Empty)
            {
                lblerror.Visible = false;

                TG exist = db.TGS.Where(gp => gp.Group.Name == name && gp.Subject.Name == subject).FirstOrDefault();
                if(exist == null)
                {
                    TG tg = new TG();
                    tg.Group_id = db.Groups.First(stu => stu.Name == name).id;
                    tg.Subject_id = db.Subjects.First(sub => sub.Name == subject).id;
                    db.TGS.Add(tg);
                    db.SaveChanges();
                    MessageBox.Show(subject + " added to " + name + "successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGrid();
                    cmbGroup.Text = "";
                    cmbSubject.Text = "";

                }
                else
                {                  
                    FillDataGrid();
                    MessageBox.Show(subject + " already exists in this group.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbGroup.Text = "";
                    cmbSubject.Text = "";
                }

            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "please fill all the fields.";
            }
        }
    }
}
