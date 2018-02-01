namespace FinalProjectCsharp
{
    partial class FormStudent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editYourProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblBD = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editYourProfileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.examToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1564, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editYourProfileToolStripMenuItem
            // 
            this.editYourProfileToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editYourProfileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.editYourProfileToolStripMenuItem.Name = "editYourProfileToolStripMenuItem";
            this.editYourProfileToolStripMenuItem.Size = new System.Drawing.Size(300, 47);
            this.editYourProfileToolStripMenuItem.Text = "Edit your profile";
            this.editYourProfileToolStripMenuItem.Click += new System.EventHandler(this.editYourProfileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 47);
            this.toolStripMenuItem1.Text = "Score";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(123, 47);
            this.examToolStripMenuItem.Text = "Exam";
            this.examToolStripMenuItem.Click += new System.EventHandler(this.examToolStripMenuItem_Click);
            // 
            // dtBD
            // 
            this.dtBD.Location = new System.Drawing.Point(70, 348);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(365, 31);
            this.dtBD.TabIndex = 2;
            this.dtBD.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.SlateGray;
            this.btncancel.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.Location = new System.Drawing.Point(70, 586);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(256, 98);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateGray;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(70, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(256, 98);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.Color.LightCoral;
            this.lblBD.Location = new System.Drawing.Point(62, 262);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(191, 43);
            this.lblBD.TabIndex = 11;
            this.lblBD.Text = "BirthDate:";
            this.lblBD.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(399, 508);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(108, 43);
            this.lblerror.TabIndex = 12;
            this.lblerror.Text = "error";
            this.lblerror.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.LightCoral;
            this.lblemail.Location = new System.Drawing.Point(62, 109);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(125, 43);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "Email:";
            this.lblemail.Visible = false;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1564, 792);
            this.Controls.Add(this.dtBD);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editYourProfileToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtBD;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
    }
}