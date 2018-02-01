namespace FinalProjectCsharp
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblsurname = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.lblIdent = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.dtbirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblrepeat = new System.Windows.Forms.Label();
            this.txtrepeat = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.SlateGray;
            this.btncreate.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncreate.Location = new System.Drawing.Point(36, 375);
            this.btncreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(128, 51);
            this.btncreate.TabIndex = 6;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Visible = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(642, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.createToolStripMenuItem.Text = "Create Student";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem1.Text = "Create Teacher";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "Create Subject";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 26);
            this.toolStripMenuItem3.Text = "Create Group";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToTeacherToolStripMenuItem,
            this.subjectToStudentToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // groupToTeacherToolStripMenuItem
            // 
            this.groupToTeacherToolStripMenuItem.Name = "groupToTeacherToolStripMenuItem";
            this.groupToTeacherToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.groupToTeacherToolStripMenuItem.Text = "Group to Teacher";
            this.groupToTeacherToolStripMenuItem.Click += new System.EventHandler(this.groupToTeacherToolStripMenuItem_Click);
            // 
            // subjectToStudentToolStripMenuItem
            // 
            this.subjectToStudentToolStripMenuItem.Name = "subjectToStudentToolStripMenuItem";
            this.subjectToStudentToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.subjectToStudentToolStripMenuItem.Text = "Subject to Group";
            this.subjectToStudentToolStripMenuItem.Click += new System.EventHandler(this.subjectToStudentToolStripMenuItem_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblname.Location = new System.Drawing.Point(32, 45);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 22);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Name:";
            this.lblname.Visible = false;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(36, 79);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(182, 20);
            this.txtname.TabIndex = 1;
            this.txtname.Visible = false;
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblsurname.Location = new System.Drawing.Point(32, 109);
            this.lblsurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(92, 22);
            this.lblsurname.TabIndex = 7;
            this.lblsurname.Text = "Surname:";
            this.lblsurname.Visible = false;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(287, 225);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(182, 20);
            this.txtfullname.TabIndex = 2;
            this.txtfullname.Visible = false;
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdent.ForeColor = System.Drawing.Color.LightCoral;
            this.lblIdent.Location = new System.Drawing.Point(32, 169);
            this.lblIdent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(131, 22);
            this.lblIdent.TabIndex = 7;
            this.lblIdent.Text = "Identification:";
            this.lblIdent.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.LightCoral;
            this.lblemail.Location = new System.Drawing.Point(32, 236);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 22);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "Email:";
            this.lblemail.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(36, 270);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(182, 20);
            this.txtemail.TabIndex = 4;
            this.txtemail.Visible = false;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.ForeColor = System.Drawing.Color.LightCoral;
            this.lblbirthdate.Location = new System.Drawing.Point(32, 308);
            this.lblbirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(93, 22);
            this.lblbirthdate.TabIndex = 7;
            this.lblbirthdate.Text = "Birthdate";
            this.lblbirthdate.Visible = false;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(36, 206);
            this.txtIdent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(182, 20);
            this.txtIdent.TabIndex = 2;
            this.txtIdent.Visible = false;
            // 
            // dtbirthdate
            // 
            this.dtbirthdate.Location = new System.Drawing.Point(36, 339);
            this.dtbirthdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtbirthdate.Name = "dtbirthdate";
            this.dtbirthdate.Size = new System.Drawing.Size(182, 20);
            this.dtbirthdate.TabIndex = 11;
            this.dtbirthdate.Visible = false;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.LightCoral;
            this.lblpass.Location = new System.Drawing.Point(283, 45);
            this.lblpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(98, 22);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password:";
            this.lblpass.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(287, 79);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(182, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.Visible = false;
            // 
            // lblrepeat
            // 
            this.lblrepeat.AutoSize = true;
            this.lblrepeat.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepeat.ForeColor = System.Drawing.Color.LightCoral;
            this.lblrepeat.Location = new System.Drawing.Point(283, 120);
            this.lblrepeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrepeat.Name = "lblrepeat";
            this.lblrepeat.Size = new System.Drawing.Size(161, 22);
            this.lblrepeat.TabIndex = 7;
            this.lblrepeat.Text = "Repeat Password:";
            this.lblrepeat.Visible = false;
            // 
            // txtrepeat
            // 
            this.txtrepeat.Location = new System.Drawing.Point(287, 154);
            this.txtrepeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrepeat.Name = "txtrepeat";
            this.txtrepeat.Size = new System.Drawing.Size(182, 20);
            this.txtrepeat.TabIndex = 1;
            this.txtrepeat.UseSystemPasswordChar = true;
            this.txtrepeat.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(198, 389);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 22);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblfullname.Location = new System.Drawing.Point(283, 191);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(97, 22);
            this.lblfullname.TabIndex = 7;
            this.lblfullname.Text = "FullName:";
            this.lblfullname.Visible = false;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.LightCoral;
            this.lblSub.Location = new System.Drawing.Point(284, 264);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(78, 22);
            this.lblSub.TabIndex = 7;
            this.lblSub.Text = "Subject:";
            this.lblSub.Visible = false;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(287, 301);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(182, 21);
            this.cmbSubject.TabIndex = 18;
            this.cmbSubject.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(36, 138);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Visible = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtbirthdate);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.txtrepeat);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblbirthdate);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblrepeat);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.DateTimePicker dtbirthdate;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblrepeat;
        private System.Windows.Forms.TextBox txtrepeat;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToStudentToolStripMenuItem;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtSurname;
    }
}