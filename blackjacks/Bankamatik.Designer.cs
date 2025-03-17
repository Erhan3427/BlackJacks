namespace blackjacks
{
    partial class Bankamatik
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
            btnParaCek = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mtbKartNo = new MaskedTextBox();
            mtbSKT = new MaskedTextBox();
            mtbCVC = new MaskedTextBox();
            label4 = new Label();
            txtİsimSoyisim = new TextBox();
            label5 = new Label();
            btnParaYatir = new Button();
            label6 = new Label();
            lblBakiye = new Label();
            mtbCekilecekTutar = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnParaCek
            // 
            btnParaCek.Location = new Point(161, 269);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(100, 39);
            btnParaCek.TabIndex = 0;
            btnParaCek.Text = "Para Cek";
            btnParaCek.UseVisualStyleBackColor = true;
            btnParaCek.Click += btnParaCek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 136);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Kart Numaranız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 172);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "Son Kullanma Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 205);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "CVC";
            // 
            // mtbKartNo
            // 
            mtbKartNo.Location = new Point(161, 129);
            mtbKartNo.Mask = "0000  0000   0000   0000";
            mtbKartNo.Name = "mtbKartNo";
            mtbKartNo.Size = new Size(202, 27);
            mtbKartNo.TabIndex = 3;
            mtbKartNo.TextAlign = HorizontalAlignment.Center;
            // 
            // mtbSKT
            // 
            mtbSKT.Location = new Point(161, 165);
            mtbSKT.Mask = "00/0000";
            mtbSKT.Name = "mtbSKT";
            mtbSKT.Size = new Size(202, 27);
            mtbSKT.TabIndex = 3;
            mtbSKT.TextAlign = HorizontalAlignment.Center;
            mtbSKT.ValidatingType = typeof(DateTime);
            // 
            // mtbCVC
            // 
            mtbCVC.Location = new Point(161, 196);
            mtbCVC.Mask = "000";
            mtbCVC.Name = "mtbCVC";
            mtbCVC.Size = new Size(202, 27);
            mtbCVC.TabIndex = 3;
            mtbCVC.TextAlign = HorizontalAlignment.Center;
            mtbCVC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 60);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 2;
            label4.Text = "Çekeceğiniz Tutar";
            // 
            // txtİsimSoyisim
            // 
            txtİsimSoyisim.Location = new Point(161, 99);
            txtİsimSoyisim.Name = "txtİsimSoyisim";
            txtİsimSoyisim.Size = new Size(202, 27);
            txtİsimSoyisim.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 106);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 2;
            label5.Text = "İsim Soyisim";
            // 
            // btnParaYatir
            // 
            btnParaYatir.Location = new Point(267, 269);
            btnParaYatir.Name = "btnParaYatir";
            btnParaYatir.Size = new Size(100, 39);
            btnParaYatir.TabIndex = 0;
            btnParaYatir.Text = "Para Yatır";
            btnParaYatir.UseVisualStyleBackColor = true;
            btnParaYatir.Click += btnParaYatir_Click;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.MenuText;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(373, -2);
            label6.Name = "label6";
            label6.Size = new Size(10, 357);
            label6.TabIndex = 6;
            label6.Text = "|";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI", 20F);
            lblBakiye.Location = new Point(422, 30);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(115, 46);
            lblBakiye.TabIndex = 7;
            lblBakiye.Text = "Bakiye";
            // 
            // mtbCekilecekTutar
            // 
            mtbCekilecekTutar.Location = new Point(161, 60);
            mtbCekilecekTutar.Mask = "00000000";
            mtbCekilecekTutar.Name = "mtbCekilecekTutar";
            mtbCekilecekTutar.Size = new Size(195, 27);
            mtbCekilecekTutar.TabIndex = 8;
            mtbCekilecekTutar.ValidatingType = typeof(int);
            mtbCekilecekTutar.MaskInputRejected += mtbCekilecekTutar_MaskInputRejected;
            // 
            // Bankamatik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(620, 349);
            Controls.Add(mtbCekilecekTutar);
            Controls.Add(lblBakiye);
            Controls.Add(label6);
            Controls.Add(txtİsimSoyisim);
            Controls.Add(mtbCVC);
            Controls.Add(mtbSKT);
            Controls.Add(mtbKartNo);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnParaYatir);
            Controls.Add(btnParaCek);
            Name = "Bankamatik";
            Text = "Banka";
            Load += Bankamatik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnParaCek;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtbKartNo;
        private MaskedTextBox mtbSKT;
        private MaskedTextBox mtbCVC;
        private Label label4;
        private TextBox txtİsimSoyisim;
        private Label label5;
        private Button btnParaYatir;
        private Label label6;
        private Label lblBakiye;
        private MaskedTextBox mtbCekilecekTutar;
    }
}