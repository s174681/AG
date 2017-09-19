namespace WindowsFormsAG
{
    partial class AlgorithmSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericOfChromosomes = new System.Windows.Forms.NumericUpDown();
            this.numericReplace = new System.Windows.Forms.NumericUpDown();
            this.numericTrackBest = new System.Windows.Forms.NumericUpDown();
            this.numericOfCrossoverPoints = new System.Windows.Forms.NumericUpDown();
            this.numericMutationSize = new System.Windows.Forms.NumericUpDown();
            this.numericCrossoverProbability = new System.Windows.Forms.NumericUpDown();
            this.numericMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfChromosomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTrackBest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfCrossoverPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCrossoverProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutationProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba chromosomów (populacja):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PARAMETRY ALGORYTMU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liczba chromosomów nowo wygenerowanych (potomstwo):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Liczba najlepszych chromosomów:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prawdopodobieństwo krzyżowania:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rozmiar mutacji:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(21, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prawdopodobieństwo mutacji:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(21, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Liczba punktów krzyżowania:";
            // 
            // numericOfChromosomes
            // 
            this.numericOfChromosomes.Location = new System.Drawing.Point(413, 44);
            this.numericOfChromosomes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericOfChromosomes.Name = "numericOfChromosomes";
            this.numericOfChromosomes.Size = new System.Drawing.Size(77, 20);
            this.numericOfChromosomes.TabIndex = 10;
            this.numericOfChromosomes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericOfChromosomes.ValueChanged += new System.EventHandler(this.numericOfChromosomes_ValueChanged);
            // 
            // numericReplace
            // 
            this.numericReplace.Location = new System.Drawing.Point(413, 74);
            this.numericReplace.Name = "numericReplace";
            this.numericReplace.Size = new System.Drawing.Size(77, 20);
            this.numericReplace.TabIndex = 11;
            this.numericReplace.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericReplace.ValueChanged += new System.EventHandler(this.numericReplace_ValueChanged);
            // 
            // numericTrackBest
            // 
            this.numericTrackBest.Location = new System.Drawing.Point(413, 105);
            this.numericTrackBest.Name = "numericTrackBest";
            this.numericTrackBest.Size = new System.Drawing.Size(77, 20);
            this.numericTrackBest.TabIndex = 12;
            this.numericTrackBest.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericTrackBest.ValueChanged += new System.EventHandler(this.numericTrackBest_ValueChanged);
            // 
            // numericOfCrossoverPoints
            // 
            this.numericOfCrossoverPoints.Location = new System.Drawing.Point(413, 135);
            this.numericOfCrossoverPoints.Name = "numericOfCrossoverPoints";
            this.numericOfCrossoverPoints.Size = new System.Drawing.Size(77, 20);
            this.numericOfCrossoverPoints.TabIndex = 13;
            this.numericOfCrossoverPoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericOfCrossoverPoints.ValueChanged += new System.EventHandler(this.numericOfCrossoverPoints_ValueChanged);
            // 
            // numericMutationSize
            // 
            this.numericMutationSize.Location = new System.Drawing.Point(413, 165);
            this.numericMutationSize.Name = "numericMutationSize";
            this.numericMutationSize.Size = new System.Drawing.Size(77, 20);
            this.numericMutationSize.TabIndex = 14;
            this.numericMutationSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericMutationSize.ValueChanged += new System.EventHandler(this.numericMutationSize_ValueChanged);
            // 
            // numericCrossoverProbability
            // 
            this.numericCrossoverProbability.Location = new System.Drawing.Point(413, 195);
            this.numericCrossoverProbability.Name = "numericCrossoverProbability";
            this.numericCrossoverProbability.Size = new System.Drawing.Size(77, 20);
            this.numericCrossoverProbability.TabIndex = 15;
            this.numericCrossoverProbability.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericCrossoverProbability.ValueChanged += new System.EventHandler(this.numericCrossoverProbability_ValueChanged);
            // 
            // numericMutationProbability
            // 
            this.numericMutationProbability.Location = new System.Drawing.Point(413, 226);
            this.numericMutationProbability.Name = "numericMutationProbability";
            this.numericMutationProbability.Size = new System.Drawing.Size(77, 20);
            this.numericMutationProbability.TabIndex = 16;
            this.numericMutationProbability.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericMutationProbability.ValueChanged += new System.EventHandler(this.numericMutationProbability_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(190, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 28);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AlgorithmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 294);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericMutationProbability);
            this.Controls.Add(this.numericCrossoverProbability);
            this.Controls.Add(this.numericMutationSize);
            this.Controls.Add(this.numericOfCrossoverPoints);
            this.Controls.Add(this.numericTrackBest);
            this.Controls.Add(this.numericReplace);
            this.Controls.Add(this.numericOfChromosomes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlgorithmSettingsForm";
            this.Text = "AlgorithmSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericOfChromosomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTrackBest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfCrossoverPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCrossoverProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutationProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericOfChromosomes;
        private System.Windows.Forms.NumericUpDown numericReplace;
        private System.Windows.Forms.NumericUpDown numericTrackBest;
        private System.Windows.Forms.NumericUpDown numericOfCrossoverPoints;
        private System.Windows.Forms.NumericUpDown numericMutationSize;
        private System.Windows.Forms.NumericUpDown numericCrossoverProbability;
        private System.Windows.Forms.NumericUpDown numericMutationProbability;
        private System.Windows.Forms.Button buttonSave;
    }
}