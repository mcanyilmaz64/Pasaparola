namespace Veri_Tabanlı_Grafik_Seçim_Istatistik
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtIlce = new TextBox();
            TxtA = new TextBox();
            TxtB = new TextBox();
            TxtC = new TextBox();
            TxtD = new TextBox();
            TxtE = new TextBox();
            BtnOyGiris = new Button();
            BtnGrafikler = new Button();
            BtnCikisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 71);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 0;
            label1.Text = "İLÇE AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 144);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 1;
            label2.Text = "A PARTİ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 185);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 2;
            label3.Text = "B PARTİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 235);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 3;
            label4.Text = "C PARTİ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 280);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 31);
            label5.TabIndex = 4;
            label5.Text = "D PARTİ ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 322);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 31);
            label6.TabIndex = 5;
            label6.Text = "E PARTİ";
            // 
            // TxtIlce
            // 
            TxtIlce.Location = new Point(227, 75);
            TxtIlce.Name = "TxtIlce";
            TxtIlce.Size = new Size(211, 38);
            TxtIlce.TabIndex = 6;
            // 
            // TxtA
            // 
            TxtA.Location = new Point(227, 144);
            TxtA.Name = "TxtA";
            TxtA.Size = new Size(362, 38);
            TxtA.TabIndex = 7;
            // 
            // TxtB
            // 
            TxtB.Location = new Point(227, 188);
            TxtB.Name = "TxtB";
            TxtB.Size = new Size(362, 38);
            TxtB.TabIndex = 8;
            // 
            // TxtC
            // 
            TxtC.Location = new Point(227, 232);
            TxtC.Name = "TxtC";
            TxtC.Size = new Size(362, 38);
            TxtC.TabIndex = 9;
            // 
            // TxtD
            // 
            TxtD.Location = new Point(227, 280);
            TxtD.Name = "TxtD";
            TxtD.Size = new Size(362, 38);
            TxtD.TabIndex = 10;
            // 
            // TxtE
            // 
            TxtE.Location = new Point(227, 324);
            TxtE.Name = "TxtE";
            TxtE.Size = new Size(362, 38);
            TxtE.TabIndex = 11;
            // 
            // BtnOyGiris
            // 
            BtnOyGiris.Location = new Point(227, 382);
            BtnOyGiris.Name = "BtnOyGiris";
            BtnOyGiris.Size = new Size(380, 39);
            BtnOyGiris.TabIndex = 12;
            BtnOyGiris.Text = "OY GİRİŞİ YAP";
            BtnOyGiris.UseVisualStyleBackColor = true;
            BtnOyGiris.Click += button1_Click;
            // 
            // BtnGrafikler
            // 
            BtnGrafikler.Location = new Point(227, 427);
            BtnGrafikler.Name = "BtnGrafikler";
            BtnGrafikler.Size = new Size(193, 39);
            BtnGrafikler.TabIndex = 13;
            BtnGrafikler.Text = "GRAFİKLER";
            BtnGrafikler.UseVisualStyleBackColor = true;
            // 
            // BtnCikisYap
            // 
            BtnCikisYap.Location = new Point(418, 427);
            BtnCikisYap.Name = "BtnCikisYap";
            BtnCikisYap.Size = new Size(189, 39);
            BtnCikisYap.TabIndex = 14;
            BtnCikisYap.Text = "ÇIKIŞ YAP";
            BtnCikisYap.UseVisualStyleBackColor = true;
            BtnCikisYap.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(731, 561);
            Controls.Add(BtnCikisYap);
            Controls.Add(BtnGrafikler);
            Controls.Add(BtnOyGiris);
            Controls.Add(TxtE);
            Controls.Add(TxtD);
            Controls.Add(TxtC);
            Controls.Add(TxtB);
            Controls.Add(TxtA);
            Controls.Add(TxtIlce);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "VtGS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtIlce;
        private TextBox TxtA;
        private TextBox TxtB;
        private TextBox TxtC;
        private TextBox TxtD;
        private TextBox TxtE;
        private Button BtnOyGiris;
        private Button BtnGrafikler;
        private Button BtnCikisYap;
    }
}
