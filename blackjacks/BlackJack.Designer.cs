namespace blackjacks
{
    partial class BlackJack
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            btnDouble = new Button();
            btnGec = new Button();
            btnKartCek = new Button();
            btnBol = new Button();
            btnKartDagit = new Button();
            ımageList1 = new ImageList(components);
            pbKurpiyer = new PictureBox();
            lblKurpiyerToplam = new Label();
            listView1 = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            pgsSaniyeBari = new ProgressBar();
            lblSaniye = new Label();
            btnParaCek = new Button();
            btnCikis = new Button();
            lblBakiyeOyun = new Label();
            btnPara1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblYatirilanPara = new Label();
            pbOyuncu = new PictureBox();
            pbBol2 = new PictureBox();
            pbBol = new PictureBox();
            lblToplam2 = new Label();
            pbOyuncu2 = new PictureBox();
            pbKurpiyer2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbKurpiyer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncu2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKurpiyer2).BeginInit();
            SuspendLayout();
            // 
            // btnDouble
            // 
            btnDouble.BackColor = Color.Black;
            btnDouble.Enabled = false;
            btnDouble.FlatStyle = FlatStyle.Flat;
            btnDouble.ForeColor = Color.White;
            btnDouble.Location = new Point(365, 395);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(112, 64);
            btnDouble.TabIndex = 0;
            btnDouble.Text = "Double";
            btnDouble.UseVisualStyleBackColor = false;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnGec
            // 
            btnGec.BackColor = Color.Gold;
            btnGec.Enabled = false;
            btnGec.FlatStyle = FlatStyle.Flat;
            btnGec.Location = new Point(228, 395);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(112, 64);
            btnGec.TabIndex = 0;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // btnKartCek
            // 
            btnKartCek.BackColor = Color.DarkRed;
            btnKartCek.Enabled = false;
            btnKartCek.FlatStyle = FlatStyle.Flat;
            btnKartCek.Location = new Point(84, 395);
            btnKartCek.Name = "btnKartCek";
            btnKartCek.Size = new Size(112, 64);
            btnKartCek.TabIndex = 0;
            btnKartCek.Text = "Kart Çek";
            btnKartCek.UseVisualStyleBackColor = false;
            btnKartCek.Click += btnKartCek_Click;
            // 
            // btnBol
            // 
            btnBol.BackColor = Color.DodgerBlue;
            btnBol.Enabled = false;
            btnBol.FlatStyle = FlatStyle.Flat;
            btnBol.Location = new Point(494, 395);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(112, 64);
            btnBol.TabIndex = 0;
            btnBol.Text = "Böl";
            btnBol.UseVisualStyleBackColor = false;
            btnBol.Click += btnBol_Click_1;
            // 
            // btnKartDagit
            // 
            btnKartDagit.BackColor = Color.LimeGreen;
            btnKartDagit.FlatStyle = FlatStyle.Popup;
            btnKartDagit.Location = new Point(838, 12);
            btnKartDagit.Name = "btnKartDagit";
            btnKartDagit.Size = new Size(163, 75);
            btnKartDagit.TabIndex = 0;
            btnKartDagit.Text = "kartları Dağıt";
            btnKartDagit.UseVisualStyleBackColor = false;
            btnKartDagit.Click += btnKartDagit_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "2_of_diamonds.png");
            ımageList1.Images.SetKeyName(1, "3_of_diamonds.png");
            ımageList1.Images.SetKeyName(2, "4_of_diamonds.png");
            ımageList1.Images.SetKeyName(3, "5_of_diamonds.png");
            ımageList1.Images.SetKeyName(4, "6_of_diamonds.png");
            ımageList1.Images.SetKeyName(5, "7_of_diamonds.png");
            ımageList1.Images.SetKeyName(6, "8_of_diamonds.png");
            ımageList1.Images.SetKeyName(7, "9_of_diamonds.png");
            ımageList1.Images.SetKeyName(8, "10_of_diamonds.png");
            ımageList1.Images.SetKeyName(9, "jack_of_diamonds.png");
            ımageList1.Images.SetKeyName(10, "queen_of_diamonds.png");
            ımageList1.Images.SetKeyName(11, "king_of_diamonds.png");
            ımageList1.Images.SetKeyName(12, "ace_of_diamonds.png");
            ımageList1.Images.SetKeyName(13, "2_of_clubs.png");
            ımageList1.Images.SetKeyName(14, "3_of_clubs.png");
            ımageList1.Images.SetKeyName(15, "4_of_clubs.png");
            ımageList1.Images.SetKeyName(16, "5_of_clubs.png");
            ımageList1.Images.SetKeyName(17, "6_of_clubs.png");
            ımageList1.Images.SetKeyName(18, "7_of_clubs.png");
            ımageList1.Images.SetKeyName(19, "8_of_clubs.png");
            ımageList1.Images.SetKeyName(20, "9_of_clubs.png");
            ımageList1.Images.SetKeyName(21, "10_of_clubs.png");
            ımageList1.Images.SetKeyName(22, "jack_of_clubs.png");
            ımageList1.Images.SetKeyName(23, "queen_of_clubs.png");
            ımageList1.Images.SetKeyName(24, "king_of_clubs.png");
            ımageList1.Images.SetKeyName(25, "ace_of_clubs.png");
            ımageList1.Images.SetKeyName(26, "2_of_spades.png");
            ımageList1.Images.SetKeyName(27, "3_of_spades.png");
            ımageList1.Images.SetKeyName(28, "4_of_spades.png");
            ımageList1.Images.SetKeyName(29, "5_of_spades.png");
            ımageList1.Images.SetKeyName(30, "6_of_spades.png");
            ımageList1.Images.SetKeyName(31, "7_of_spades.png");
            ımageList1.Images.SetKeyName(32, "8_of_spades.png");
            ımageList1.Images.SetKeyName(33, "9_of_spades.png");
            ımageList1.Images.SetKeyName(34, "10_of_spades.png");
            ımageList1.Images.SetKeyName(35, "jack_of_spades.png");
            ımageList1.Images.SetKeyName(36, "queen_of_spades.png");
            ımageList1.Images.SetKeyName(37, "king_of_spades.png");
            ımageList1.Images.SetKeyName(38, "ace_of_spades.png");
            ımageList1.Images.SetKeyName(39, "2_of_hearts.png");
            ımageList1.Images.SetKeyName(40, "3_of_hearts.png");
            ımageList1.Images.SetKeyName(41, "4_of_hearts.png");
            ımageList1.Images.SetKeyName(42, "5_of_hearts.png");
            ımageList1.Images.SetKeyName(43, "6_of_hearts.png");
            ımageList1.Images.SetKeyName(44, "7_of_hearts.png");
            ımageList1.Images.SetKeyName(45, "8_of_hearts.png");
            ımageList1.Images.SetKeyName(46, "9_of_hearts.png");
            ımageList1.Images.SetKeyName(47, "10_of_hearts.png");
            ımageList1.Images.SetKeyName(48, "jack_of_hearts.png");
            ımageList1.Images.SetKeyName(49, "queen_of_hearts.png");
            ımageList1.Images.SetKeyName(50, "king_of_hearts.png");
            ımageList1.Images.SetKeyName(51, "ace_of_hearts.png");
            // 
            // pbKurpiyer
            // 
            pbKurpiyer.Location = new Point(483, 12);
            pbKurpiyer.Name = "pbKurpiyer";
            pbKurpiyer.Size = new Size(81, 121);
            pbKurpiyer.SizeMode = PictureBoxSizeMode.CenterImage;
            pbKurpiyer.TabIndex = 1;
            pbKurpiyer.TabStop = false;
            pbKurpiyer.Click += pictureBox2_Click;
            // 
            // lblKurpiyerToplam
            // 
            lblKurpiyerToplam.Location = new Point(503, 149);
            lblKurpiyerToplam.Name = "lblKurpiyerToplam";
            lblKurpiyerToplam.Size = new Size(112, 33);
            lblKurpiyerToplam.TabIndex = 3;
            lblKurpiyerToplam.Text = "Kurpiyer";
            // 
            // listView1
            // 
            listView1.Location = new Point(1029, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(255, 301);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pgsSaniyeBari
            // 
            pgsSaniyeBari.Location = new Point(12, 12);
            pgsSaniyeBari.Maximum = 60;
            pgsSaniyeBari.Name = "pgsSaniyeBari";
            pgsSaniyeBari.Size = new Size(169, 29);
            pgsSaniyeBari.TabIndex = 6;
            // 
            // lblSaniye
            // 
            lblSaniye.FlatStyle = FlatStyle.Popup;
            lblSaniye.Location = new Point(187, 12);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(92, 29);
            lblSaniye.TabIndex = 7;
            lblSaniye.Text = "saniye";
            // 
            // btnParaCek
            // 
            btnParaCek.BackColor = Color.DarkKhaki;
            btnParaCek.FlatStyle = FlatStyle.Flat;
            btnParaCek.Location = new Point(1029, 340);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(152, 58);
            btnParaCek.TabIndex = 8;
            btnParaCek.Text = "Para Cek";
            btnParaCek.UseVisualStyleBackColor = false;
            btnParaCek.Click += btnParaCek_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.DarkRed;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Location = new Point(1029, 424);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(152, 58);
            btnCikis.TabIndex = 8;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += button1_Click;
            // 
            // lblBakiyeOyun
            // 
            lblBakiyeOyun.AutoSize = true;
            lblBakiyeOyun.Font = new Font("Segoe UI", 15F);
            lblBakiyeOyun.Location = new Point(628, 424);
            lblBakiyeOyun.Name = "lblBakiyeOyun";
            lblBakiyeOyun.Size = new Size(81, 35);
            lblBakiyeOyun.TabIndex = 9;
            lblBakiyeOyun.Text = "label1";
            // 
            // btnPara1
            // 
            btnPara1.Location = new Point(12, 149);
            btnPara1.Name = "btnPara1";
            btnPara1.Size = new Size(61, 56);
            btnPara1.TabIndex = 10;
            btnPara1.Text = "button1";
            btnPara1.UseVisualStyleBackColor = true;
            btnPara1.Click += btnPara1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 340);
            button2.Name = "button2";
            button2.Size = new Size(61, 56);
            button2.TabIndex = 10;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 271);
            button3.Name = "button3";
            button3.Size = new Size(61, 56);
            button3.TabIndex = 10;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblYatirilanPara
            // 
            lblYatirilanPara.AutoSize = true;
            lblYatirilanPara.Font = new Font("Segoe UI", 11F);
            lblYatirilanPara.Location = new Point(137, 337);
            lblYatirilanPara.Name = "lblYatirilanPara";
            lblYatirilanPara.Size = new Size(22, 25);
            lblYatirilanPara.TabIndex = 11;
            lblYatirilanPara.Text = "0";
            // 
            // pbOyuncu
            // 
            pbOyuncu.BackColor = Color.DarkGreen;
            pbOyuncu.Location = new Point(235, 250);
            pbOyuncu.Name = "pbOyuncu";
            pbOyuncu.Size = new Size(81, 121);
            pbOyuncu.SizeMode = PictureBoxSizeMode.CenterImage;
            pbOyuncu.TabIndex = 1;
            pbOyuncu.TabStop = false;
            // 
            // pbBol2
            // 
            pbBol2.BackColor = Color.DarkGreen;
            pbBol2.Location = new Point(284, 281);
            pbBol2.Name = "pbBol2";
            pbBol2.Size = new Size(69, 91);
            pbBol2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBol2.TabIndex = 1;
            pbBol2.TabStop = false;
            // 
            // pbBol
            // 
            pbBol.BackColor = Color.DarkGreen;
            pbBol.Location = new Point(208, 281);
            pbBol.Name = "pbBol";
            pbBol.Size = new Size(69, 91);
            pbBol.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBol.TabIndex = 1;
            pbBol.TabStop = false;
            // 
            // lblToplam2
            // 
            lblToplam2.Location = new Point(261, 215);
            lblToplam2.Name = "lblToplam2";
            lblToplam2.Size = new Size(112, 32);
            lblToplam2.TabIndex = 3;
            lblToplam2.Text = "oyuncu";
            // 
            // pbOyuncu2
            // 
            pbOyuncu2.BackColor = Color.DarkGreen;
            pbOyuncu2.Location = new Point(322, 250);
            pbOyuncu2.Name = "pbOyuncu2";
            pbOyuncu2.Size = new Size(81, 121);
            pbOyuncu2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbOyuncu2.TabIndex = 12;
            pbOyuncu2.TabStop = false;
            // 
            // pbKurpiyer2
            // 
            pbKurpiyer2.Location = new Point(570, 12);
            pbKurpiyer2.Name = "pbKurpiyer2";
            pbKurpiyer2.Size = new Size(81, 121);
            pbKurpiyer2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbKurpiyer2.TabIndex = 1;
            pbKurpiyer2.TabStop = false;
            pbKurpiyer2.Click += pictureBox2_Click;
            // 
            // BlackJack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1310, 502);
            Controls.Add(pbOyuncu2);
            Controls.Add(lblToplam2);
            Controls.Add(pbBol);
            Controls.Add(lblYatirilanPara);
            Controls.Add(pbBol2);
            Controls.Add(pbOyuncu);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnPara1);
            Controls.Add(lblBakiyeOyun);
            Controls.Add(btnCikis);
            Controls.Add(btnParaCek);
            Controls.Add(lblSaniye);
            Controls.Add(pgsSaniyeBari);
            Controls.Add(listView1);
            Controls.Add(lblKurpiyerToplam);
            Controls.Add(pbKurpiyer2);
            Controls.Add(pbKurpiyer);
            Controls.Add(btnKartDagit);
            Controls.Add(btnBol);
            Controls.Add(btnKartCek);
            Controls.Add(btnGec);
            Controls.Add(btnDouble);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BlackJack";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbKurpiyer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOyuncu2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKurpiyer2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDouble;
        private Button btnGec;
        private Button btnKartCek;
        private Button btnBol;
        private Button btnKartDagit;
        private ImageList ımageList1;
        private PictureBox pbKurpiyer;
        private Label lblKurpiyerToplam;
        private ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar pgsSaniyeBari;
        private Label lblSaniye;
        private Button btnParaCek;
        private Button btnCikis;
        private Label lblBakiyeOyun;
        private Button btnPara1;
        private Button button2;
        private Button button3;
        private Label lblYatirilanPara;
        private PictureBox pbOyuncu;
        private PictureBox pbBol2;
        private PictureBox pbBol;
        private Label lblToplam2;
        private PictureBox pbOyuncu2;
        private PictureBox pbKurpiyer2;
    }
}
