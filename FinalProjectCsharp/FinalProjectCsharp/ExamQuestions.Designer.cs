namespace FinalProjectCsharp
{
    partial class ExamQuestions
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnE = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(99, 20);
            this.lblquestion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(64, 22);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "label1";
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(58, 98);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(144, 26);
            this.rbtnA.TabIndex = 1;
            this.rbtnA.Text = "radioButton1";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(58, 161);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(144, 26);
            this.rbtnB.TabIndex = 2;
            this.rbtnB.Text = "radioButton1";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(58, 294);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(144, 26);
            this.rbtnD.TabIndex = 3;
            this.rbtnD.Text = "radioButton1";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(58, 224);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(144, 26);
            this.rbtnC.TabIndex = 4;
            this.rbtnC.Text = "radioButton1";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnE
            // 
            this.rbtnE.AutoSize = true;
            this.rbtnE.Location = new System.Drawing.Point(58, 357);
            this.rbtnE.Name = "rbtnE";
            this.rbtnE.Size = new System.Drawing.Size(144, 26);
            this.rbtnE.TabIndex = 3;
            this.rbtnE.Text = "radioButton1";
            this.rbtnE.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SlateGray;
            this.btnNext.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(319, 664);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(163, 67);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.SlateGray;
            this.btnPre.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPre.Location = new System.Drawing.Point(97, 664);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(163, 67);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Visible = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SlateGray;
            this.btnSubmit.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(319, 664);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(163, 67);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnA);
            this.groupBox1.Controls.Add(this.rbtnB);
            this.groupBox1.Controls.Add(this.rbtnD);
            this.groupBox1.Controls.Add(this.rbtnE);
            this.groupBox1.Controls.Add(this.rbtnC);
            this.groupBox1.Location = new System.Drawing.Point(97, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1448, 522);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ExamQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1284, 940);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblquestion);
            this.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExamQuestions";
            this.Text = "ExamQuestions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnE;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}