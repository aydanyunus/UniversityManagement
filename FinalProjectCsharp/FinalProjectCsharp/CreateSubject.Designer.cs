namespace FinalProjectCsharp
{
    partial class CreateSubject
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
            this.lblError = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnSubjectCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(75, 372);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(122, 43);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(83, 152);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(359, 31);
            this.txtSubject.TabIndex = 17;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.LightCoral;
            this.lblSubject.Location = new System.Drawing.Point(75, 70);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(253, 43);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Subject Name:";
            // 
            // btnSubjectCreate
            // 
            this.btnSubjectCreate.BackColor = System.Drawing.Color.SlateGray;
            this.btnSubjectCreate.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubjectCreate.Location = new System.Drawing.Point(83, 234);
            this.btnSubjectCreate.Name = "btnSubjectCreate";
            this.btnSubjectCreate.Size = new System.Drawing.Size(256, 98);
            this.btnSubjectCreate.TabIndex = 18;
            this.btnSubjectCreate.Text = "Create";
            this.btnSubjectCreate.UseVisualStyleBackColor = false;
            this.btnSubjectCreate.Click += new System.EventHandler(this.btnSubjectCreate_Click);
            // 
            // CreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1523, 809);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSubjectCreate);
            this.Name = "CreateSubject";
            this.Text = "CreateSubject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSubjectCreate;
    }
}