namespace FinalProjectCsharp
{
    partial class FormLoginAdmin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnlogin.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogin.Location = new System.Drawing.Point(48, 203);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(128, 51);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(239, 227);
            this.lblerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(91, 26);
            this.lblerror.TabIndex = 5;
            this.lblerror.Text = "lblerror";
            this.lblerror.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(48, 89);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(181, 20);
            this.txtemail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(44, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(48, 167);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(181, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // FormLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(642, 407);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnlogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLoginAdmin";
            this.Text = "FormLoginAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
    }
}