namespace paszporty_desktopowa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numerTB = new System.Windows.Forms.TextBox();
            this.imieTB = new System.Windows.Forms.TextBox();
            this.nazwiskoTB = new System.Windows.Forms.TextBox();
            this.zdjecie_pictureBox = new System.Windows.Forms.PictureBox();
            this.odcisk_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.niebieskieRB = new System.Windows.Forms.RadioButton();
            this.zieloneRB = new System.Windows.Forms.RadioButton();
            this.piwneRB = new System.Windows.Forms.RadioButton();
            this.okBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odcisk_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // numerTB
            // 
            this.numerTB.BackColor = System.Drawing.Color.Azure;
            this.numerTB.Location = new System.Drawing.Point(136, 27);
            this.numerTB.Name = "numerTB";
            this.numerTB.Size = new System.Drawing.Size(216, 20);
            this.numerTB.TabIndex = 3;
            this.numerTB.TextChanged += new System.EventHandler(this.numerTB_TextChanged);
            this.numerTB.Leave += new System.EventHandler(this.numerTB_Leave);
            // 
            // imieTB
            // 
            this.imieTB.BackColor = System.Drawing.Color.Azure;
            this.imieTB.Location = new System.Drawing.Point(136, 53);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(216, 20);
            this.imieTB.TabIndex = 4;
            // 
            // nazwiskoTB
            // 
            this.nazwiskoTB.BackColor = System.Drawing.Color.Azure;
            this.nazwiskoTB.Location = new System.Drawing.Point(136, 79);
            this.nazwiskoTB.Name = "nazwiskoTB";
            this.nazwiskoTB.Size = new System.Drawing.Size(216, 20);
            this.nazwiskoTB.TabIndex = 5;
            // 
            // zdjecie_pictureBox
            // 
            this.zdjecie_pictureBox.Location = new System.Drawing.Point(409, 43);
            this.zdjecie_pictureBox.Name = "zdjecie_pictureBox";
            this.zdjecie_pictureBox.Size = new System.Drawing.Size(164, 180);
            this.zdjecie_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zdjecie_pictureBox.TabIndex = 6;
            this.zdjecie_pictureBox.TabStop = false;
            // 
            // odcisk_pictureBox
            // 
            this.odcisk_pictureBox.Location = new System.Drawing.Point(601, 43);
            this.odcisk_pictureBox.Name = "odcisk_pictureBox";
            this.odcisk_pictureBox.Size = new System.Drawing.Size(164, 180);
            this.odcisk_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.odcisk_pictureBox.TabIndex = 7;
            this.odcisk_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.piwneRB);
            this.groupBox1.Controls.Add(this.zieloneRB);
            this.groupBox1.Controls.Add(this.niebieskieRB);
            this.groupBox1.Location = new System.Drawing.Point(34, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolor oczu";
            // 
            // niebieskieRB
            // 
            this.niebieskieRB.AutoSize = true;
            this.niebieskieRB.Checked = true;
            this.niebieskieRB.Location = new System.Drawing.Point(6, 19);
            this.niebieskieRB.Name = "niebieskieRB";
            this.niebieskieRB.Size = new System.Drawing.Size(72, 17);
            this.niebieskieRB.TabIndex = 0;
            this.niebieskieRB.TabStop = true;
            this.niebieskieRB.Text = "niebieskie";
            this.niebieskieRB.UseVisualStyleBackColor = true;
            // 
            // zieloneRB
            // 
            this.zieloneRB.AutoSize = true;
            this.zieloneRB.Location = new System.Drawing.Point(6, 53);
            this.zieloneRB.Name = "zieloneRB";
            this.zieloneRB.Size = new System.Drawing.Size(58, 17);
            this.zieloneRB.TabIndex = 1;
            this.zieloneRB.Text = "zielone";
            this.zieloneRB.UseVisualStyleBackColor = true;
            // 
            // piwneRB
            // 
            this.piwneRB.AutoSize = true;
            this.piwneRB.Location = new System.Drawing.Point(6, 86);
            this.piwneRB.Name = "piwneRB";
            this.piwneRB.Size = new System.Drawing.Size(53, 17);
            this.piwneRB.TabIndex = 2;
            this.piwneRB.Text = "piwne";
            this.piwneRB.UseVisualStyleBackColor = true;
            // 
            // okBTN
            // 
            this.okBTN.BackColor = System.Drawing.Color.Azure;
            this.okBTN.Location = new System.Drawing.Point(448, 263);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(280, 55);
            this.okBTN.TabIndex = 3;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = false;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odcisk_pictureBox);
            this.Controls.Add(this.zdjecie_pictureBox);
            this.Controls.Add(this.nazwiskoTB);
            this.Controls.Add(this.imieTB);
            this.Controls.Add(this.numerTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wprowadzenie danych do paszportu. Wykonał: nigger";
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odcisk_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numerTB;
        private System.Windows.Forms.TextBox imieTB;
        private System.Windows.Forms.TextBox nazwiskoTB;
        private System.Windows.Forms.PictureBox zdjecie_pictureBox;
        private System.Windows.Forms.PictureBox odcisk_pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton piwneRB;
        private System.Windows.Forms.RadioButton zieloneRB;
        private System.Windows.Forms.RadioButton niebieskieRB;
        private System.Windows.Forms.Button okBTN;
    }
}

