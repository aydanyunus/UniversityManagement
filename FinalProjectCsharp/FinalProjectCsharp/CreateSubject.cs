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
    public partial class CreateSubject : Form
    {
        UniversityEntities db = new UniversityEntities();

        public CreateSubject()
        {
            InitializeComponent();
        }

        private void btnSubjectCreate_Click(object sender, EventArgs e)
        {
            string subjectname = txtSubject.Text;

            if(subjectname != string.Empty)
            {
                lblError.Visible = false;

                Subject exitsub = db.Subjects.FirstOrDefault(sb => sb.Name == subjectname);
                if(exitsub == null)
                {
                    Subject sb = new Subject();
                    sb.Name = subjectname;
                    db.Subjects.Add(sb);
                    db.SaveChanges();
                    MessageBox.Show(subjectname + " was added succesfully to the subject list", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubject.Text = "";
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "this subject already exists.";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "please fill all the fields.";
            }
        }
    }
}
