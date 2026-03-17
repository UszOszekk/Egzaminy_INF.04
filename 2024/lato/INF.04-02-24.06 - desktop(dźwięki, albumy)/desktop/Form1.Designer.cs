namespace dzwieki_desktopowa
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
            this.prawoBTN = new System.Windows.Forms.Button();
            this.lewoBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wykonawcaLBL = new System.Windows.Forms.Label();
            this.tytulLBL = new System.Windows.Forms.Label();
            this.liczbaUtworowLBL = new System.Windows.Forms.Label();
            this.liczbaPobranLBL = new System.Windows.Forms.Label();
            this.rokLBL = new System.Windows.Forms.Label();
            this.pobierzBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prawoBTN
            // 
            this.prawoBTN.BackgroundImage = global::dzwieki_desktopowa.Properties.Resources.obraz2;
            this.prawoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prawoBTN.Location = new System.Drawing.Point(1135, 108);
            this.prawoBTN.Name = "prawoBTN";
            this.prawoBTN.Size = new System.Drawing.Size(85, 70);
            this.prawoBTN.TabIndex = 3;
            this.prawoBTN.UseVisualStyleBackColor = true;
            this.prawoBTN.Click += new System.EventHandler(this.prawoBTN_Click);
            // 
            // lewoBTN
            // 
            this.lewoBTN.BackgroundImage = global::dzwieki_desktopowa.Properties.Resources.obraz3;
            this.lewoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lewoBTN.Location = new System.Drawing.Point(12, 108);
            this.lewoBTN.Name = "lewoBTN";
            this.lewoBTN.Size = new System.Drawing.Size(85, 70);
            this.lewoBTN.TabIndex = 0;
            this.lewoBTN.UseVisualStyleBackColor = true;
            this.lewoBTN.Click += new System.EventHandler(this.lewoBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::dzwieki_desktopowa.Properties.Resources.obraz;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(142, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 203);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // wykonawcaLBL
            // 
            this.wykonawcaLBL.AutoSize = true;
            this.wykonawcaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykonawcaLBL.ForeColor = System.Drawing.Color.White;
            this.wykonawcaLBL.Location = new System.Drawing.Point(375, 40);
            this.wykonawcaLBL.Name = "wykonawcaLBL";
            this.wykonawcaLBL.Size = new System.Drawing.Size(208, 76);
            this.wykonawcaLBL.TabIndex = 5;
            this.wykonawcaLBL.Text = "label1";
            // 
            // tytulLBL
            // 
            this.tytulLBL.AutoSize = true;
            this.tytulLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulLBL.ForeColor = System.Drawing.Color.White;
            this.tytulLBL.Location = new System.Drawing.Point(380, 116);
            this.tytulLBL.Name = "tytulLBL";
            this.tytulLBL.Size = new System.Drawing.Size(126, 46);
            this.tytulLBL.TabIndex = 6;
            this.tytulLBL.Text = "label1";
            // 
            // liczbaUtworowLBL
            // 
            this.liczbaUtworowLBL.AutoSize = true;
            this.liczbaUtworowLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczbaUtworowLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.liczbaUtworowLBL.Location = new System.Drawing.Point(382, 162);
            this.liczbaUtworowLBL.Name = "liczbaUtworowLBL";
            this.liczbaUtworowLBL.Size = new System.Drawing.Size(86, 31);
            this.liczbaUtworowLBL.TabIndex = 7;
            this.liczbaUtworowLBL.Text = "label1";
            // 
            // liczbaPobranLBL
            // 
            this.liczbaPobranLBL.AutoSize = true;
            this.liczbaPobranLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczbaPobranLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.liczbaPobranLBL.Location = new System.Drawing.Point(122, 251);
            this.liczbaPobranLBL.Name = "liczbaPobranLBL";
            this.liczbaPobranLBL.Size = new System.Drawing.Size(86, 31);
            this.liczbaPobranLBL.TabIndex = 8;
            this.liczbaPobranLBL.Text = "label2";
            // 
            // rokLBL
            // 
            this.rokLBL.AutoSize = true;
            this.rokLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rokLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.rokLBL.Location = new System.Drawing.Point(474, 162);
            this.rokLBL.Name = "rokLBL";
            this.rokLBL.Size = new System.Drawing.Size(86, 31);
            this.rokLBL.TabIndex = 9;
            this.rokLBL.Text = "label3";
            // 
            // pobierzBTN
            // 
            this.pobierzBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.pobierzBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobierzBTN.ForeColor = System.Drawing.Color.Black;
            this.pobierzBTN.Location = new System.Drawing.Point(302, 244);
            this.pobierzBTN.Name = "pobierzBTN";
            this.pobierzBTN.Size = new System.Drawing.Size(129, 44);
            this.pobierzBTN.TabIndex = 10;
            this.pobierzBTN.Text = "Pobierz";
            this.pobierzBTN.UseVisualStyleBackColor = false;
            this.pobierzBTN.Click += new System.EventHandler(this.pobierzBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1232, 307);
            this.Controls.Add(this.pobierzBTN);
            this.Controls.Add(this.rokLBL);
            this.Controls.Add(this.liczbaPobranLBL);
            this.Controls.Add(this.liczbaUtworowLBL);
            this.Controls.Add(this.tytulLBL);
            this.Controls.Add(this.wykonawcaLBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prawoBTN);
            this.Controls.Add(this.lewoBTN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.Name = "Form1";
            this.Text = "MojeDźwięki, Wykonał: ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lewoBTN;
        private System.Windows.Forms.Button prawoBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wykonawcaLBL;
        private System.Windows.Forms.Label tytulLBL;
        private System.Windows.Forms.Label liczbaUtworowLBL;
        private System.Windows.Forms.Label liczbaPobranLBL;
        private System.Windows.Forms.Label rokLBL;
        private System.Windows.Forms.Button pobierzBTN;
    }
}

