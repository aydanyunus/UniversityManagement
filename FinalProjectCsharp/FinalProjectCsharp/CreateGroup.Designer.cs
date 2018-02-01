namespace FinalProjectCsharp
{
    partial class CreateGroup
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
            this.lblGroupError = new System.Windows.Forms.Label();
            this.txtgroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnGroupCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGroupError
            // 
            this.lblGroupError.AutoSize = true;
            this.lblGroupError.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupError.ForeColor = System.Drawing.Color.Red;
            this.lblGroupError.Location = new System.Drawing.Point(70, 357);
            this.lblGroupError.Name = "lblGroupError";
            this.lblGroupError.Size = new System.Drawing.Size(122, 43);
            this.lblGroupError.TabIndex = 16;
            this.lblGroupError.Text = "label1";
            this.lblGroupError.Visible = false;
            // 
            // txtgroup
            // 
            this.txtgroup.Location = new System.Drawing.Point(78, 135);
            this.txtgroup.Name = "txtgroup";
            this.txtgroup.Size = new System.Drawing.Size(359, 31);
            this.txtgroup.TabIndex = 13;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.LightCoral;
            this.lblGroup.Location = new System.Drawing.Point(70, 55);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(235, 43);
            this.lblGroup.TabIndex = 15;
            this.lblGroup.Text = "Group Name:";
            // 
            // btnGroupCreate
            // 
            this.btnGroupCreate.BackColor = System.Drawing.Color.SlateGray;
            this.btnGroupCreate.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroupCreate.Location = new System.Drawing.Point(78, 219);
            this.btnGroupCreate.Name = "btnGroupCreate";
            this.btnGroupCreate.Size = new System.Drawing.Size(256, 98);
            this.btnGroupCreate.TabIndex = 14;
            this.btnGroupCreate.Text = "Create";
            this.btnGroupCreate.UseVisualStyleBackColor = false;
            this.btnGroupCreate.Click += new System.EventHandler(this.btnGroupCreate_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1535, 810);
            this.Controls.Add(this.lblGroupError);
            this.Controls.Add(this.txtgroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnGroupCreate);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupError;
        private System.Windows.Forms.TextBox txtgroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnGroupCreate;
    }
}