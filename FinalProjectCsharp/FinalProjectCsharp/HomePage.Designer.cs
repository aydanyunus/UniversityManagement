namespace FinalProjectCsharp
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightCoral;
            this.lblWelcome.Location = new System.Drawing.Point(518, 83);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(316, 112);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.SlateGray;
            this.btnStudent.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Snow;
            this.btnStudent.Location = new System.Drawing.Point(1050, 470);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(256, 98);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.SlateGray;
            this.btnTeacher.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.Snow;
            this.btnTeacher.Location = new System.Drawing.Point(623, 470);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(256, 98);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdmin.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Snow;
            this.btnAdmin.Location = new System.Drawing.Point(1510, 470);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(256, 98);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(611, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login As";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1601, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
    }
}

