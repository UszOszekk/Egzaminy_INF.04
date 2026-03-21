namespace rgb_desktop
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
            this.czerwonyTrackBar = new System.Windows.Forms.TrackBar();
            this.zielonyTrackBar = new System.Windows.Forms.TrackBar();
            this.niebieskiTrackBar = new System.Windows.Forms.TrackBar();
            this.kolorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.czerwonyWartosc = new System.Windows.Forms.Label();
            this.zielonyWartosc = new System.Windows.Forms.Label();
            this.niebieskiWartosc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pobierzBTN = new System.Windows.Forms.Button();
            this.wartosciKoloruLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.czerwonyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zielonyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieskiTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // czerwonyTrackBar
            // 
            this.czerwonyTrackBar.Location = new System.Drawing.Point(50, 162);
            this.czerwonyTrackBar.Maximum = 255;
            this.czerwonyTrackBar.Name = "czerwonyTrackBar";
            this.czerwonyTrackBar.Size = new System.Drawing.Size(681, 45);
            this.czerwonyTrackBar.TabIndex = 0;
            this.czerwonyTrackBar.Value = 255;
            this.czerwonyTrackBar.Scroll += new System.EventHandler(this.czerwonyTrackBar_Scroll);
            // 
            // zielonyTrackBar
            // 
            this.zielonyTrackBar.Location = new System.Drawing.Point(50, 213);
            this.zielonyTrackBar.Maximum = 255;
            this.zielonyTrackBar.Name = "zielonyTrackBar";
            this.zielonyTrackBar.Size = new System.Drawing.Size(681, 45);
            this.zielonyTrackBar.TabIndex = 1;
            this.zielonyTrackBar.Value = 255;
            this.zielonyTrackBar.Scroll += new System.EventHandler(this.zielonyTrackBar_Scroll);
            // 
            // niebieskiTrackBar
            // 
            this.niebieskiTrackBar.Location = new System.Drawing.Point(50, 264);
            this.niebieskiTrackBar.Maximum = 255;
            this.niebieskiTrackBar.Name = "niebieskiTrackBar";
            this.niebieskiTrackBar.Size = new System.Drawing.Size(681, 45);
            this.niebieskiTrackBar.TabIndex = 2;
            this.niebieskiTrackBar.Value = 255;
            this.niebieskiTrackBar.Scroll += new System.EventHandler(this.niebieskiTrackBar_Scroll);
            // 
            // kolorPanel
            // 
            this.kolorPanel.BackColor = System.Drawing.Color.White;
            this.kolorPanel.Location = new System.Drawing.Point(33, 12);
            this.kolorPanel.Name = "kolorPanel";
            this.kolorPanel.Size = new System.Drawing.Size(729, 100);
            this.kolorPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // czerwonyWartosc
            // 
            this.czerwonyWartosc.AutoSize = true;
            this.czerwonyWartosc.Location = new System.Drawing.Point(737, 162);
            this.czerwonyWartosc.Name = "czerwonyWartosc";
            this.czerwonyWartosc.Size = new System.Drawing.Size(25, 13);
            this.czerwonyWartosc.TabIndex = 8;
            this.czerwonyWartosc.Text = "255";
            // 
            // zielonyWartosc
            // 
            this.zielonyWartosc.AutoSize = true;
            this.zielonyWartosc.Location = new System.Drawing.Point(738, 213);
            this.zielonyWartosc.Name = "zielonyWartosc";
            this.zielonyWartosc.Size = new System.Drawing.Size(25, 13);
            this.zielonyWartosc.TabIndex = 9;
            this.zielonyWartosc.Text = "255";
            // 
            // niebieskiWartosc
            // 
            this.niebieskiWartosc.AutoSize = true;
            this.niebieskiWartosc.Location = new System.Drawing.Point(737, 264);
            this.niebieskiWartosc.Name = "niebieskiWartosc";
            this.niebieskiWartosc.Size = new System.Drawing.Size(25, 13);
            this.niebieskiWartosc.TabIndex = 10;
            this.niebieskiWartosc.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            // 
            // pobierzBTN
            // 
            this.pobierzBTN.BackColor = System.Drawing.Color.Peru;
            this.pobierzBTN.Location = new System.Drawing.Point(302, 315);
            this.pobierzBTN.Name = "pobierzBTN";
            this.pobierzBTN.Size = new System.Drawing.Size(172, 36);
            this.pobierzBTN.TabIndex = 12;
            this.pobierzBTN.Text = "Pobierz";
            this.pobierzBTN.UseVisualStyleBackColor = false;
            this.pobierzBTN.Click += new System.EventHandler(this.pobierzBTN_Click);
            // 
            // wartosciKoloruLBL
            // 
            this.wartosciKoloruLBL.AutoSize = true;
            this.wartosciKoloruLBL.BackColor = System.Drawing.Color.White;
            this.wartosciKoloruLBL.Location = new System.Drawing.Point(302, 354);
            this.wartosciKoloruLBL.Name = "wartosciKoloruLBL";
            this.wartosciKoloruLBL.Padding = new System.Windows.Forms.Padding(8, 5, 90, 20);
            this.wartosciKoloruLBL.Size = new System.Drawing.Size(171, 38);
            this.wartosciKoloruLBL.TabIndex = 13;
            this.wartosciKoloruLBL.Text = "255, 255, 255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wartosciKoloruLBL);
            this.Controls.Add(this.pobierzBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.niebieskiWartosc);
            this.Controls.Add(this.zielonyWartosc);
            this.Controls.Add(this.czerwonyWartosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolorPanel);
            this.Controls.Add(this.niebieskiTrackBar);
            this.Controls.Add(this.zielonyTrackBar);
            this.Controls.Add(this.czerwonyTrackBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.czerwonyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zielonyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieskiTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar czerwonyTrackBar;
        private System.Windows.Forms.TrackBar zielonyTrackBar;
        private System.Windows.Forms.TrackBar niebieskiTrackBar;
        private System.Windows.Forms.Panel kolorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label czerwonyWartosc;
        private System.Windows.Forms.Label zielonyWartosc;
        private System.Windows.Forms.Label niebieskiWartosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pobierzBTN;
        private System.Windows.Forms.Label wartosciKoloruLBL;
    }
}

