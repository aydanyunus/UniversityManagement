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
    public partial class FormLoginAdmin : Form
    {
        UniversityEntities db = new UniversityEntities();
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            if(email != string.Empty && password != string.Empty)
            {
                lblerror.Visible = false;
                string adminemail = db.Admins.First(ad => ad.id == 1).Email;
                string adminpassword = db.Admins.First(ad => ad.id == 1).Password;

                if(email == adminemail && password == adminpassword)
                {
                    FormAdmin ad = new FormAdmin();
                    ad.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "password or email is wrong.";
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
