namespace FinalProjectCsharp
{
    partial class FormExam
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
            this.lbl = new System.Windows.Forms.Label();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnexam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl.Location = new System.Drawing.Point(111, 66);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(158, 57);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Location = new System.Drawing.Point(121, 194);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(328, 33);
            this.cmbSub.TabIndex = 1;
            this.cmbSub.SelectedIndexChanged += new System.EventHandler(this.cmbSub_SelectedIndexChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(126, 304);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(175, 62);
            this.lblerror.TabIndex = 0;
            this.lblerror.Text = "label1";
            this.lblerror.Visible = false;
            // 
            // btnexam
            // 
            this.btnexam.BackColor = System.Drawing.Color.SlateGray;
            this.btnexam.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnexam.Location = new System.Drawing.Point(137, 304);
            this.btnexam.Name = "btnexam";
            this.btnexam.Size = new System.Drawing.Size(256, 98);
            this.btnexam.TabIndex = 4;
            this.btnexam.Text = "Start Exam";
            this.btnexam.UseVisualStyleBackColor = false;
            this.btnexam.Visible = false;
            this.btnexam.Click += new System.EventHandler(this.btnexam_Click);
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1569, 777);
            this.Controls.Add(this.btnexam);
            this.Controls.Add(this.cmbSub);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lbl);
            this.Name = "FormExam";
            this.Text = "FormExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnexam;
    }
}