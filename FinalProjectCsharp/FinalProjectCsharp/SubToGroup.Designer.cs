namespace FinalProjectCsharp
{
    partial class SubToGroup
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
            this.dgwTgs = new System.Windows.Forms.DataGridView();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTgs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTgs
            // 
            this.dgwTgs.AllowUserToAddRows = false;
            this.dgwTgs.AllowUserToDeleteRows = false;
            this.dgwTgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTgs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTgs.Location = new System.Drawing.Point(307, 24);
            this.dgwTgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwTgs.Name = "dgwTgs";
            this.dgwTgs.ReadOnly = true;
            this.dgwTgs.RowTemplate.Height = 33;
            this.dgwTgs.Size = new System.Drawing.Size(473, 448);
            this.dgwTgs.TabIndex = 0;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(30, 60);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(166, 21);
            this.cmbGroup.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.LightCoral;
            this.lblname.Location = new System.Drawing.Point(26, 24);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 22);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Group Name:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(30, 145);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(166, 21);
            this.cmbSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(28, 193);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 51);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(29, 280);
            this.lblerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(131, 22);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "Subject Name:";
            this.lblerror.Visible = false;
            // 
            // SubToStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(642, 404);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.dgwTgs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubToStu";
            this.Text = "SubToStu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubToStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTgs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTgs;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblerror;
    }
}