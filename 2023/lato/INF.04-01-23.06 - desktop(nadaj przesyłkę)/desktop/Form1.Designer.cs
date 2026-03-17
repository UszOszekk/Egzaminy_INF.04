namespace INF._04_01_23._06_SG_desktop_
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
            this.pocztowka = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.RadioButton();
            this.paczka = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ulica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kodPocztowy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.miasto = new System.Windows.Forms.TextBox();
            this.sprawdzCeneBtn = new System.Windows.Forms.Button();
            this.zdjecie = new System.Windows.Forms.PictureBox();
            this.cenaTxt = new System.Windows.Forms.Label();
            this.zatwierdzBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paczka);
            this.groupBox1.Controls.Add(this.list);
            this.groupBox1.Controls.Add(this.pocztowka);
            this.groupBox1.Location = new System.Drawing.Point(57, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj przesyłki";
            // 
            // pocztowka
            // 
            this.pocztowka.AutoSize = true;
            this.pocztowka.Checked = true;
            this.pocztowka.Location = new System.Drawing.Point(6, 19);
            this.pocztowka.Name = "pocztowka";
            this.pocztowka.Size = new System.Drawing.Size(78, 17);
            this.pocztowka.TabIndex = 1;
            this.pocztowka.TabStop = true;
            this.pocztowka.Text = "Pocztówka";
            this.pocztowka.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(6, 42);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(41, 17);
            this.list.TabIndex = 2;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            // 
            // paczka
            // 
            this.paczka.AutoSize = true;
            this.paczka.Location = new System.Drawing.Point(6, 65);
            this.paczka.Name = "paczka";
            this.paczka.Size = new System.Drawing.Size(61, 17);
            this.paczka.TabIndex = 3;
            this.paczka.Text = "Paczka";
            this.paczka.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.miasto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.kodPocztowy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ulica);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(405, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane adresowe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulica z numerem";
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(29, 42);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(300, 20);
            this.ulica.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kod pocztowy";
            // 
            // kodPocztowy
            // 
            this.kodPocztowy.Location = new System.Drawing.Point(29, 103);
            this.kodPocztowy.Name = "kodPocztowy";
            this.kodPocztowy.Size = new System.Drawing.Size(114, 20);
            this.kodPocztowy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miasto";
            // 
            // miasto
            // 
            this.miasto.Location = new System.Drawing.Point(29, 162);
            this.miasto.Name = "miasto";
            this.miasto.Size = new System.Drawing.Size(300, 20);
            this.miasto.TabIndex = 5;
            // 
            // sprawdzCeneBtn
            // 
            this.sprawdzCeneBtn.Location = new System.Drawing.Point(57, 161);
            this.sprawdzCeneBtn.Name = "sprawdzCeneBtn";
            this.sprawdzCeneBtn.Size = new System.Drawing.Size(200, 23);
            this.sprawdzCeneBtn.TabIndex = 2;
            this.sprawdzCeneBtn.Text = "sprawdzCene";
            this.sprawdzCeneBtn.UseVisualStyleBackColor = true;
            this.sprawdzCeneBtn.Click += new System.EventHandler(this.sprawdzCeneBtn_Click);
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(57, 201);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(149, 92);
            this.zdjecie.TabIndex = 3;
            this.zdjecie.TabStop = false;
            // 
            // cenaTxt
            // 
            this.cenaTxt.AutoSize = true;
            this.cenaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaTxt.Location = new System.Drawing.Point(212, 211);
            this.cenaTxt.Name = "cenaTxt";
            this.cenaTxt.Size = new System.Drawing.Size(81, 25);
            this.cenaTxt.TabIndex = 4;
            this.cenaTxt.Text = "Cena: ";
            // 
            // zatwierdzBtn
            // 
            this.zatwierdzBtn.Location = new System.Drawing.Point(57, 318);
            this.zatwierdzBtn.Name = "zatwierdzBtn";
            this.zatwierdzBtn.Size = new System.Drawing.Size(697, 23);
            this.zatwierdzBtn.TabIndex = 5;
            this.zatwierdzBtn.Text = "Zatwierdź";
            this.zatwierdzBtn.UseVisualStyleBackColor = true;
            this.zatwierdzBtn.Click += new System.EventHandler(this.zatwierdzBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(773, 367);
            this.Controls.Add(this.zatwierdzBtn);
            this.Controls.Add(this.cenaTxt);
            this.Controls.Add(this.zdjecie);
            this.Controls.Add(this.sprawdzCeneBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nadaj przesylke PESEL:67420";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pocztowka;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.RadioButton paczka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kodPocztowy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miasto;
        private System.Windows.Forms.Button sprawdzCeneBtn;
        private System.Windows.Forms.PictureBox zdjecie;
        private System.Windows.Forms.Label cenaTxt;
        private System.Windows.Forms.Button zatwierdzBtn;
    }
}

