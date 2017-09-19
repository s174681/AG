namespace WindowsFormsAG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.title2 = new System.Windows.Forms.Label();
            this.Osoba = new System.Windows.Forms.TabControl();
            this.osoba1 = new System.Windows.Forms.TabPage();
            this.osoba2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOsrodek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKwalifikacja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelOsrodekPracy = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.labelUprawnienia = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.textBoxOsrodekPracy = new System.Windows.Forms.TextBox();
            this.textBoxUprawnienia = new System.Windows.Forms.TextBox();
            this.Osoba.SuspendLayout();
            this.osoba1.SuspendLayout();
            this.osoba2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title2.Location = new System.Drawing.Point(117, 9);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(212, 24);
            this.title2.TabIndex = 1;
            this.title2.Text = "DANE PERSONALNE";
            // 
            // Osoba
            // 
            this.Osoba.Controls.Add(this.osoba1);
            this.Osoba.Controls.Add(this.osoba2);
            this.Osoba.Location = new System.Drawing.Point(12, 36);
            this.Osoba.Name = "Osoba";
            this.Osoba.SelectedIndex = 0;
            this.Osoba.Size = new System.Drawing.Size(436, 218);
            this.Osoba.TabIndex = 2;
            // 
            // osoba1
            // 
            this.osoba1.Controls.Add(this.textBoxUprawnienia);
            this.osoba1.Controls.Add(this.textBoxOsrodekPracy);
            this.osoba1.Controls.Add(this.textBoxMiasto);
            this.osoba1.Controls.Add(this.textBoxNazwisko);
            this.osoba1.Controls.Add(this.textBoxImie);
            this.osoba1.Controls.Add(this.labelUprawnienia);
            this.osoba1.Controls.Add(this.labelMiasto);
            this.osoba1.Controls.Add(this.labelOsrodekPracy);
            this.osoba1.Controls.Add(this.labelNazwisko);
            this.osoba1.Controls.Add(this.labelImie);
            this.osoba1.Controls.Add(this.label5);
            this.osoba1.Controls.Add(this.labelKwalifikacja);
            this.osoba1.Controls.Add(this.label3);
            this.osoba1.Controls.Add(this.labelOsrodek);
            this.osoba1.Controls.Add(this.label1);
            this.osoba1.Controls.Add(this.pictureBox1);
            this.osoba1.Location = new System.Drawing.Point(4, 22);
            this.osoba1.Name = "osoba1";
            this.osoba1.Padding = new System.Windows.Forms.Padding(3);
            this.osoba1.Size = new System.Drawing.Size(428, 192);
            this.osoba1.TabIndex = 0;
            this.osoba1.Text = "Osoba I";
            this.osoba1.UseVisualStyleBackColor = true;
            // 
            // osoba2
            // 
            this.osoba2.Controls.Add(this.pictureBox2);
            this.osoba2.Location = new System.Drawing.Point(4, 22);
            this.osoba2.Name = "osoba2";
            this.osoba2.Padding = new System.Windows.Forms.Padding(3);
            this.osoba2.Size = new System.Drawing.Size(428, 192);
            this.osoba2.TabIndex = 1;
            this.osoba2.Text = "Osoba II";
            this.osoba2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 180);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(142, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do ośrodka";
            // 
            // labelOsrodek
            // 
            this.labelOsrodek.AutoSize = true;
            this.labelOsrodek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsrodek.Location = new System.Drawing.Point(227, 15);
            this.labelOsrodek.Name = "labelOsrodek";
            this.labelOsrodek.Size = new System.Drawing.Size(45, 16);
            this.labelOsrodek.TabIndex = 2;
            this.labelOsrodek.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(292, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "z kwalifikacji";
            // 
            // labelKwalifikacja
            // 
            this.labelKwalifikacja.AutoSize = true;
            this.labelKwalifikacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKwalifikacja.Location = new System.Drawing.Point(379, 15);
            this.labelKwalifikacja.Name = "labelKwalifikacja";
            this.labelKwalifikacja.Size = new System.Drawing.Size(45, 16);
            this.labelKwalifikacja.TabIndex = 4;
            this.labelKwalifikacja.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(142, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "przydzielony jest egzaminator:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(142, 71);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(39, 16);
            this.labelImie.TabIndex = 6;
            this.labelImie.Text = "Imie: ";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwisko.Location = new System.Drawing.Point(142, 96);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(69, 16);
            this.labelNazwisko.TabIndex = 7;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelOsrodekPracy
            // 
            this.labelOsrodekPracy.AutoSize = true;
            this.labelOsrodekPracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsrodekPracy.Location = new System.Drawing.Point(142, 145);
            this.labelOsrodekPracy.Name = "labelOsrodekPracy";
            this.labelOsrodekPracy.Size = new System.Drawing.Size(95, 16);
            this.labelOsrodekPracy.TabIndex = 8;
            this.labelOsrodekPracy.Text = "Miejsce pracy:";
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(142, 121);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(48, 16);
            this.labelMiasto.TabIndex = 9;
            this.labelMiasto.Text = "Masto:";
            // 
            // labelUprawnienia
            // 
            this.labelUprawnienia.AutoSize = true;
            this.labelUprawnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUprawnienia.Location = new System.Drawing.Point(142, 170);
            this.labelUprawnienia.Name = "labelUprawnienia";
            this.labelUprawnienia.Size = new System.Drawing.Size(86, 16);
            this.labelUprawnienia.TabIndex = 10;
            this.labelUprawnienia.Text = "Uprawnienia:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(248, 65);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(157, 22);
            this.textBoxImie.TabIndex = 11;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwisko.Location = new System.Drawing.Point(248, 92);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(157, 22);
            this.textBoxNazwisko.TabIndex = 12;
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMiasto.Location = new System.Drawing.Point(248, 117);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(157, 22);
            this.textBoxMiasto.TabIndex = 13;
            // 
            // textBoxOsrodekPracy
            // 
            this.textBoxOsrodekPracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOsrodekPracy.Location = new System.Drawing.Point(248, 141);
            this.textBoxOsrodekPracy.Name = "textBoxOsrodekPracy";
            this.textBoxOsrodekPracy.Size = new System.Drawing.Size(157, 22);
            this.textBoxOsrodekPracy.TabIndex = 14;
            // 
            // textBoxUprawnienia
            // 
            this.textBoxUprawnienia.Location = new System.Drawing.Point(248, 166);
            this.textBoxUprawnienia.Name = "textBoxUprawnienia";
            this.textBoxUprawnienia.Size = new System.Drawing.Size(157, 20);
            this.textBoxUprawnienia.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 266);
            this.Controls.Add(this.Osoba);
            this.Controls.Add(this.title2);
            this.Name = "Form2";
            this.Text = "Egzaminator";
            this.Osoba.ResumeLayout(false);
            this.osoba1.ResumeLayout(false);
            this.osoba1.PerformLayout();
            this.osoba2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.TabControl Osoba;
        private System.Windows.Forms.TabPage osoba1;
        private System.Windows.Forms.TabPage osoba2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOsrodek;
        private System.Windows.Forms.Label labelKwalifikacja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelOsrodekPracy;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelUprawnienia;
        private System.Windows.Forms.TextBox textBoxUprawnienia;
        private System.Windows.Forms.TextBox textBoxOsrodekPracy;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.TextBox textBoxNazwisko;

    }
}