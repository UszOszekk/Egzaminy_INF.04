namespace pracownicy_desktop
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imieTB = new System.Windows.Forms.TextBox();
            this.nazwiskoTB = new System.Windows.Forms.TextBox();
            this.stanowiskoCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zatwierdzBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ileZnakowTB = new System.Windows.Forms.TextBox();
            this.maleWielkieCheck = new System.Windows.Forms.CheckBox();
            this.cyfryCheck = new System.Windows.Forms.CheckBox();
            this.znakiCheck = new System.Windows.Forms.CheckBox();
            this.generujHasloBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stanowiskoCB);
            this.groupBox1.Controls.Add(this.nazwiskoTB);
            this.groupBox1.Controls.Add(this.imieTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pracownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanowisko";
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(83, 28);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(100, 20);
            this.imieTB.TabIndex = 3;
            // 
            // nazwiskoTB
            // 
            this.nazwiskoTB.Location = new System.Drawing.Point(83, 61);
            this.nazwiskoTB.Name = "nazwiskoTB";
            this.nazwiskoTB.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoTB.TabIndex = 4;
            // 
            // stanowiskoCB
            // 
            this.stanowiskoCB.FormattingEnabled = true;
            this.stanowiskoCB.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.stanowiskoCB.Location = new System.Drawing.Point(83, 94);
            this.stanowiskoCB.Name = "stanowiskoCB";
            this.stanowiskoCB.Size = new System.Drawing.Size(100, 21);
            this.stanowiskoCB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generujHasloBTN);
            this.groupBox2.Controls.Add(this.znakiCheck);
            this.groupBox2.Controls.Add(this.cyfryCheck);
            this.groupBox2.Controls.Add(this.maleWielkieCheck);
            this.groupBox2.Controls.Add(this.ileZnakowTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(284, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generowanie hasła";
            // 
            // zatwierdzBTN
            // 
            this.zatwierdzBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.zatwierdzBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.zatwierdzBTN.Location = new System.Drawing.Point(161, 202);
            this.zatwierdzBTN.Name = "zatwierdzBTN";
            this.zatwierdzBTN.Size = new System.Drawing.Size(195, 23);
            this.zatwierdzBTN.TabIndex = 7;
            this.zatwierdzBTN.Text = "Zatwierdź";
            this.zatwierdzBTN.UseVisualStyleBackColor = false;
            this.zatwierdzBTN.Click += new System.EventHandler(this.zatwierdzBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ile znaków?";
            // 
            // ileZnakowTB
            // 
            this.ileZnakowTB.Location = new System.Drawing.Point(107, 28);
            this.ileZnakowTB.Name = "ileZnakowTB";
            this.ileZnakowTB.Size = new System.Drawing.Size(100, 20);
            this.ileZnakowTB.TabIndex = 6;
            // 
            // maleWielkieCheck
            // 
            this.maleWielkieCheck.AutoSize = true;
            this.maleWielkieCheck.Checked = true;
            this.maleWielkieCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maleWielkieCheck.Location = new System.Drawing.Point(23, 60);
            this.maleWielkieCheck.Name = "maleWielkieCheck";
            this.maleWielkieCheck.Size = new System.Drawing.Size(115, 17);
            this.maleWielkieCheck.TabIndex = 7;
            this.maleWielkieCheck.Text = "Małe i wielkie litery";
            this.maleWielkieCheck.UseVisualStyleBackColor = true;
            // 
            // cyfryCheck
            // 
            this.cyfryCheck.AutoSize = true;
            this.cyfryCheck.Location = new System.Drawing.Point(23, 83);
            this.cyfryCheck.Name = "cyfryCheck";
            this.cyfryCheck.Size = new System.Drawing.Size(49, 17);
            this.cyfryCheck.TabIndex = 8;
            this.cyfryCheck.Text = "Cyfry";
            this.cyfryCheck.UseVisualStyleBackColor = true;
            // 
            // znakiCheck
            // 
            this.znakiCheck.AutoSize = true;
            this.znakiCheck.Location = new System.Drawing.Point(23, 106);
            this.znakiCheck.Name = "znakiCheck";
            this.znakiCheck.Size = new System.Drawing.Size(101, 17);
            this.znakiCheck.TabIndex = 9;
            this.znakiCheck.Text = "Znaki specjalne";
            this.znakiCheck.UseVisualStyleBackColor = true;
            // 
            // generujHasloBTN
            // 
            this.generujHasloBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.generujHasloBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.generujHasloBTN.Location = new System.Drawing.Point(79, 146);
            this.generujHasloBTN.Name = "generujHasloBTN";
            this.generujHasloBTN.Size = new System.Drawing.Size(83, 23);
            this.generujHasloBTN.TabIndex = 10;
            this.generujHasloBTN.Text = "Generuj hasło";
            this.generujHasloBTN.UseVisualStyleBackColor = false;
            this.generujHasloBTN.Click += new System.EventHandler(this.generujHasloBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(532, 240);
            this.Controls.Add(this.zatwierdzBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dodaj pracownika 00000000000";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stanowiskoCB;
        private System.Windows.Forms.TextBox nazwiskoTB;
        private System.Windows.Forms.TextBox imieTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generujHasloBTN;
        private System.Windows.Forms.CheckBox znakiCheck;
        private System.Windows.Forms.CheckBox cyfryCheck;
        private System.Windows.Forms.CheckBox maleWielkieCheck;
        private System.Windows.Forms.TextBox ileZnakowTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zatwierdzBTN;
    }
}

