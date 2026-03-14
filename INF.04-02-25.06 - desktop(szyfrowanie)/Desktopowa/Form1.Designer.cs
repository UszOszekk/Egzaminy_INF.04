namespace INF._04_02_25._06_SG_desktop_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kluczTextBox = new TextBox();
            jawnyTextBox = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            zaszyfrowanyText = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Podaj wartość klucza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(27, 137);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Podaj tekst";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(475, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 2;
            label3.Text = "Tekst zaszyfrowany";
            // 
            // kluczTextBox
            // 
            kluczTextBox.Location = new Point(105, 58);
            kluczTextBox.Name = "kluczTextBox";
            kluczTextBox.Size = new Size(60, 23);
            kluczTextBox.TabIndex = 3;
            kluczTextBox.TextChanged += kluczTextBox_TextChanged;
            // 
            // jawnyTextBox
            // 
            jawnyTextBox.Location = new Point(27, 166);
            jawnyTextBox.Name = "jawnyTextBox";
            jawnyTextBox.Size = new Size(290, 250);
            jawnyTextBox.TabIndex = 4;
            jawnyTextBox.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(342, 254);
            button1.Name = "button1";
            button1.Size = new Size(85, 35);
            button1.TabIndex = 5;
            button1.Text = "Zaszyfruj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(542, 393);
            button2.Name = "button2";
            button2.Size = new Size(212, 34);
            button2.TabIndex = 6;
            button2.Text = "Zapisz szyfr w pliku";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // zaszyfrowanyText
            // 
            zaszyfrowanyText.AutoSize = true;
            zaszyfrowanyText.ForeColor = Color.AliceBlue;
            zaszyfrowanyText.Location = new Point(17, 22);
            zaszyfrowanyText.Name = "zaszyfrowanyText";
            zaszyfrowanyText.Size = new Size(0, 15);
            zaszyfrowanyText.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(zaszyfrowanyText);
            panel1.Location = new Point(475, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 257);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(jawnyTextBox);
            Controls.Add(kluczTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Szyfrowanie. Wykonane przez";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kluczTextBox;
        private RichTextBox jawnyTextBox;
        private Button button1;
        private Button button2;
        private Label zaszyfrowanyText;
        private Panel panel1;
    }
}
