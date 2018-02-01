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
    public partial class FormLoginTeacher : Form
    {
        UniversityEntities db = new UniversityEntities();
        
        public FormLoginTeacher()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string Ident = txtIdentificator.Text;
            string pass = txtPassword.Text;
            
            int identint;

            if (Ident != string.Empty && pass != string.Empty)
            {
                if (int.TryParse(Ident, out identint))
                {
                    lblerror.Visible = false;

                    Teacher tch = db.Teachers.FirstOrDefault(tc => tc.Identification == Ident);

                    if (tch != null)
                    {
                        if (tch.Password == pass.HashMe())
                        {
                            FormTeacher ft = new FormTeacher(tch);
                            ft.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            lblerror.Visible = true;
                            lblerror.Text = "password is wrong.";
                        }
                    }
                    else
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "identification is wrong.";
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "only numeric charachters.";
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "please fill all the fields.";            
            }
                
        }

        private void FormLoginTeacher_Load(object sender, EventArgs e)
        {

        }

        
    }
}
