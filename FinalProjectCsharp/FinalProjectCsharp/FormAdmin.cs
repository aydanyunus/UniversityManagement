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
    public partial class FormAdmin : Form
    {
        UniversityEntities db = new UniversityEntities();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblname.Visible = true;
            lblsurname.Visible = true;
            lblemail.Visible = true;
            lblIdent.Visible = true;
            lblbirthdate.Visible = true;
            lblpass.Visible = true;
            lblrepeat.Visible = true;
            lblfullname.Visible = true;
            txtSurname.Visible = true;
            txtname.Visible = true;
            txtfullname.Visible = true;
            txtIdent.Visible = true;
            txtemail.Visible = true;
            dtbirthdate.Visible = true;
            txtpassword.Visible = true;
            txtrepeat.Visible = true;
            btncreate.Visible = true;
            cmbSubject.Visible = true;
            lblSub.Visible = true;
            
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string surname = txtSurname.Text;
            string ident = txtIdent.Text;
            string email = txtemail.Text;
            DateTime dtbd = dtbirthdate.Value;
            string password = txtpassword.Text;
            string repeat = txtrepeat.Text;
            string fullname = txtfullname.Text;
            string subject = cmbSubject.Text;
            int intIdent;

            if(name != string.Empty &&
                surname != string.Empty &&
                ident != string.Empty &&
                email != string.Empty &&
                dtbd !=null && password != string.Empty &&
                repeat != string.Empty && fullname != string.Empty
                && subject != string.Empty
                )
            {
                lblError.Visible = false;
                if (int.TryParse(ident, out intIdent))
                {
                    if (password == repeat)
                    {
                        Teacher exitteacher = db.Teachers.FirstOrDefault(t => t.Email == email);
                        Teacher exitident = db.Teachers.FirstOrDefault(t => t.Identification == ident);
                        if (exitteacher == null && exitident == null)
                        {
                            if(ident.Length == 10)
                            {
                                Teacher tc = new Teacher();
                                tc.FirstName = name;
                                tc.LastName = surname;
                                tc.Email = email;
                                tc.Identification = ident;
                                tc.Birthdate = dtbd;
                                tc.Password = password.HashMe();
                                tc.FullName = fullname;
                                tc.Subject_id = db.Subjects.First(sb => sb.Name == subject).id;
                                db.Teachers.Add(tc);
                                db.SaveChanges();
                                MessageBox.Show(name + " " + surname + " was added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtname.Text = "";
                                txtSurname.Text = "";
                                txtIdent.Text = "";
                                txtemail.Text = "";
                                txtpassword.Text = "";
                                txtrepeat.Text = "";
                                txtfullname.Text = "";
                                cmbSubject.Text = "";
                                this.Close();
                            }
                            else
                            {
                                lblError.Visible = true;
                                lblError.Text = "identification length should be at least 10 charachters. ";
                            }                           
                        }                    
                        else
                        {
                        lblError.Visible = true;
                        lblError.Text = "this email or identification already exists.";
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Password and Repeat Password do not match.";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "identification can not contain non-numeric charachters";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "please fill all the fields.";
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CreateGroup cg = new CreateGroup();
            cg.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateSubject cs = new CreateSubject();
            cs.ShowDialog();
            this.Close();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent cstu = new CreateStudent();
            cstu.ShowDialog();
            this.Close();
        }

        private void groupToTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupToTeacher gtt = new GroupToTeacher();
            gtt.ShowDialog();
            this.Close();
        }

        private void subjectToStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubToGroup add = new SubToGroup();
            add.ShowDialog();
            this.Close();
        }

        private void FillComboSubject()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(db.Subjects.Select(sb => sb.Name).Distinct().ToArray());
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FillComboSubject();
        }
    }
}
