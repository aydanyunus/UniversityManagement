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
    public partial class CreateStudent : Form
    {
        UniversityEntities db = new UniversityEntities();

        public CreateStudent()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string ident = txtIdent.Text;
            DateTime birthdate = dtBd.Value;
            string group = cmbGroup.Text;
            string password = txtPassword.Text;
            string repeat = txtRepeat.Text;
            string fullname = txtFullname.Text;
            int Identint;

            if(firstname != string.Empty &&
                lastname != string.Empty &&
                email != string.Empty &&
                ident != string.Empty &&
                birthdate != null &&
                group != string.Empty &&
                password != string.Empty &&
                repeat != string.Empty && 
                fullname != string.Empty)
            {
                
                if(int.TryParse(ident, out Identint))
                {
                    lblerror.Visible = false;
                    if(password == repeat)
                    {
                        Student exitsemail = db.Students.FirstOrDefault(stu => stu.Email == email);
                        Student exitident = db.Students.FirstOrDefault(stu => stu.Identification == ident);

                        if(exitsemail == null)
                        {
                            if(exitident == null)
                            {
                                if(ident.Length == 10)
                                {
                                    Student stu = new Student();
                                    stu.FirstName = firstname;
                                    stu.LastName = lastname;
                                    stu.Email = email;
                                    stu.Identification = ident;
                                    stu.Birthdate = birthdate;
                                    stu.Password = password.HashMe();
                                    stu.Group_id = db.Groups.First(gp => gp.Name == group).id;
                                    stu.FullName = fullname;
                                    db.Students.Add(stu);
                                    db.SaveChanges();
                                    MessageBox.Show(firstname + " " + lastname + " was added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtFirstName.Text = "";
                                    txtLastName.Text = "";
                                    txtEmail.Text = "";
                                    txtIdent.Text = "";
                                    txtPassword.Text = "";
                                    txtRepeat.Text = "";
                                    txtFullname.Text = "";
                                    this.Close();
                                }
                                else
                                {
                                    lblerror.Visible = true;
                                    lblerror.Text = "identification length should be at least 8 charachters.";
                                }
                                
                            }
                            else
                            {
                                lblerror.Visible = true;
                                lblerror.Text = "this identification already exists.";
                            }
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
                        lblerror.Text = "Password and Repeat Password do not match.";
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "identification can not contain non-numeric charachters";
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "please fill all the fields.";
            }
        }

        private void FillComboGroups()
        {
            cmbGroup.Items.AddRange(db.Groups.Select(gp => gp.Name).ToArray());

        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            FillComboGroups();
        }
    }
}
