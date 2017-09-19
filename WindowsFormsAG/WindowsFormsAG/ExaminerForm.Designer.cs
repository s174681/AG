namespace WindowsFormsAG
{
    partial class ExaminerForm
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
            this.dataGridViewEgzaminator = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.labelLicznik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEgzaminator)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEgzaminator
            // 
            this.dataGridViewEgzaminator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEgzaminator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEgzaminator.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewEgzaminator.Name = "dataGridViewEgzaminator";
            this.dataGridViewEgzaminator.RowHeadersVisible = false;
            this.dataGridViewEgzaminator.Size = new System.Drawing.Size(500, 114);
            this.dataGridViewEgzaminator.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(120, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(291, 23);
            this.title.TabIndex = 1;
            this.title.Text = "EGZAMINATOR DANE PERSONALNE";
            // 
            // labelLicznik
            // 
            this.labelLicznik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicznik.AutoSize = true;
            this.labelLicznik.Location = new System.Drawing.Point(481, 152);
            this.labelLicznik.Name = "labelLicznik";
            this.labelLicznik.Size = new System.Drawing.Size(36, 13);
            this.labelLicznik.TabIndex = 2;
            this.labelLicznik.Text = "licznik";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 174);
            this.Controls.Add(this.labelLicznik);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridViewEgzaminator);
            this.Name = "Form3";
            this.Text = "Egzaminatorzy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEgzaminator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEgzaminator;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelLicznik;
    }
}