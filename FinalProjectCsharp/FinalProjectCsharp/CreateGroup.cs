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
    public partial class CreateGroup : Form
    {
        UniversityEntities db = new UniversityEntities();
        public CreateGroup()
        {
            InitializeComponent();
        }

        private void btnGroupCreate_Click(object sender, EventArgs e)
        {
            string groupname = txtgroup.Text;
            if (groupname != string.Empty)
            {
                lblGroupError.Visible = false;
                Group exitgroup = db.Groups.FirstOrDefault(gp => gp.Name == groupname);
                if (exitgroup == null)
                {
                    Group gp = new Group();
                    gp.Name = groupname;
                    db.Groups.Add(gp);
                    db.SaveChanges();
                    MessageBox.Show(groupname + " was added succesfully to the group list", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgroup.Text = "";                  

                }
                else
                {
                    lblGroupError.Visible = true;
                    lblGroupError.Text = "this group already exists.";
                }

            }
            else
            {
                lblGroupError.Visible = true;
                lblGroupError.Text = "please fill all the fields.";
            }
        }
    }
}
