namespace FinalProjectCsharp
{
    partial class GroupToTeacher
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(35, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 51);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(31, 306);
            this.lblerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(131, 22);
            this.lblerror.TabIndex = 12;
            this.lblerror.Text = "Subject Name:";
            this.lblerror.Visible = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblname.Location = new System.Drawing.Point(31, 49);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(136, 22);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Teacher Name:";
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Location = new System.Drawing.Point(35, 85);
            this.cmbTeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(166, 21);
            this.cmbTeacherName.TabIndex = 11;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(35, 176);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(166, 21);
            this.cmbGroup.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Group Name:";
            // 
            // GroupToTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(642, 418);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cmbTeacherName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GroupToTeacher";
            this.Text = "GroupToTeacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GroupToTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label2;
    }
}