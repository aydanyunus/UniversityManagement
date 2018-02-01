namespace FinalProjectCsharp
{
    partial class CreateStudent
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
            this.lblerror = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(402, 706);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(122, 43);
            this.lblerror.TabIndex = 20;
            this.lblerror.Text = "label1";
            this.lblerror.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(359, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblfirstname.Location = new System.Drawing.Point(76, 58);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(199, 43);
            this.lblfirstname.TabIndex = 19;
            this.lblfirstname.Text = "Firstname:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(84, 651);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(256, 98);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(76, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lastname:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 280);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(359, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(83, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 431);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(83, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 43);
            this.label3.TabIndex = 19;
            this.label3.Text = "Identification:";
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(91, 578);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(359, 31);
            this.txtIdent.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(543, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 43);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(551, 475);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(359, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(531, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 43);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birthdate:";
            // 
            // dtBd
            // 
            this.dtBd.Location = new System.Drawing.Point(551, 142);
            this.dtBd.Name = "dtBd";
            this.dtBd.Size = new System.Drawing.Size(365, 31);
            this.dtBd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(543, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 43);
            this.label6.TabIndex = 19;
            this.label6.Text = "Group:";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(551, 310);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(359, 33);
            this.cmbGroup.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(543, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 43);
            this.label7.TabIndex = 19;
            this.label7.Text = "Repeat Password:";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(551, 626);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(359, 31);
            this.txtRepeat.TabIndex = 8;
            this.txtRepeat.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(1009, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 43);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fullname:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(1017, 138);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(359, 31);
            this.txtFullname.TabIndex = 9;
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1531, 771);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.dtBd);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateStudent";
            this.Text = "CreateStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFullname;
    }
}