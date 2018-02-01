namespace FinalProjectCsharp
{
    partial class ScoreTable
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
            this.dgwScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwScore
            // 
            this.dgwScore.AllowUserToAddRows = false;
            this.dgwScore.AllowUserToDeleteRows = false;
            this.dgwScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwScore.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwScore.Location = new System.Drawing.Point(0, 0);
            this.dgwScore.Name = "dgwScore";
            this.dgwScore.ReadOnly = true;
            this.dgwScore.RowTemplate.Height = 33;
            this.dgwScore.Size = new System.Drawing.Size(1748, 774);
            this.dgwScore.TabIndex = 0;
            // 
            // ScoreTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1574, 786);
            this.Controls.Add(this.dgwScore);
            this.Name = "ScoreTable";
            this.Text = "ScoreTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScoreTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwScore;
    }
}