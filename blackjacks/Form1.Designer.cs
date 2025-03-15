namespace blackjacks
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnDouble = new Button();
            btnGec = new Button();
            btnKartCek = new Button();
            btnBol = new Button();
            btnKartDagit = new Button();
            pictureBox1 = new PictureBox();
            ımageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            lblKurpiyerToplam = new Label();
            listView1 = new ListView();
            lblToplam2 = new Label();
            pbBol2 = new PictureBox();
            pbBol = new PictureBox();
            txtbox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).BeginInit();
            SuspendLayout();
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(515, 331);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(112, 64);
            btnDouble.TabIndex = 0;
            btnDouble.Text = "Double";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(386, 331);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(112, 64);
            btnGec.TabIndex = 0;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // btnKartCek
            // 
            btnKartCek.Enabled = false;
            btnKartCek.Location = new Point(84, 331);
            btnKartCek.Name = "btnKartCek";
            btnKartCek.Size = new Size(112, 64);
            btnKartCek.TabIndex = 0;
            btnKartCek.Text = "Kart Çek";
            btnKartCek.UseVisualStyleBackColor = true;
            btnKartCek.Click += btnKartCek_Click;
            // 
            // btnBol
            // 
            btnBol.Enabled = false;
            btnBol.Location = new Point(235, 331);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(112, 64);
            btnBol.TabIndex = 0;
            btnBol.Text = "Böl";
            btnBol.UseVisualStyleBackColor = true;
            // 
            // btnKartDagit
            // 
            btnKartDagit.Location = new Point(27, 24);
            btnKartDagit.Name = "btnKartDagit";
            btnKartDagit.Size = new Size(112, 64);
            btnKartDagit.TabIndex = 0;
            btnKartDagit.Text = "kartları Dağıt";
            btnKartDagit.UseVisualStyleBackColor = true;
            btnKartDagit.Click += btnKartDagit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(85, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "2_of_clubs.png");
            ımageList1.Images.SetKeyName(1, "2_of_diamonds.png");
            ımageList1.Images.SetKeyName(2, "2_of_hearts.png");
            ımageList1.Images.SetKeyName(3, "2_of_spades.png");
            ımageList1.Images.SetKeyName(4, "3_of_clubs.png");
            ımageList1.Images.SetKeyName(5, "3_of_diamonds.png");
            ımageList1.Images.SetKeyName(6, "3_of_hearts.png");
            ımageList1.Images.SetKeyName(7, "3_of_spades.png");
            ımageList1.Images.SetKeyName(8, "4_of_clubs.png");
            ımageList1.Images.SetKeyName(9, "4_of_diamonds.png");
            ımageList1.Images.SetKeyName(10, "4_of_hearts.png");
            ımageList1.Images.SetKeyName(11, "4_of_spades.png");
            ımageList1.Images.SetKeyName(12, "5_of_clubs.png");
            ımageList1.Images.SetKeyName(13, "5_of_diamonds.png");
            ımageList1.Images.SetKeyName(14, "5_of_hearts.png");
            ımageList1.Images.SetKeyName(15, "5_of_spades.png");
            ımageList1.Images.SetKeyName(16, "6_of_clubs.png");
            ımageList1.Images.SetKeyName(17, "6_of_diamonds.png");
            ımageList1.Images.SetKeyName(18, "6_of_hearts.png");
            ımageList1.Images.SetKeyName(19, "6_of_spades.png");
            ımageList1.Images.SetKeyName(20, "7_of_clubs.png");
            ımageList1.Images.SetKeyName(21, "7_of_diamonds.png");
            ımageList1.Images.SetKeyName(22, "7_of_hearts.png");
            ımageList1.Images.SetKeyName(23, "7_of_spades.png");
            ımageList1.Images.SetKeyName(24, "8_of_clubs.png");
            ımageList1.Images.SetKeyName(25, "8_of_diamonds.png");
            ımageList1.Images.SetKeyName(26, "8_of_hearts.png");
            ımageList1.Images.SetKeyName(27, "8_of_spades.png");
            ımageList1.Images.SetKeyName(28, "9_of_clubs.png");
            ımageList1.Images.SetKeyName(29, "9_of_diamonds.png");
            ımageList1.Images.SetKeyName(30, "9_of_hearts.png");
            ımageList1.Images.SetKeyName(31, "9_of_spades.png");
            ımageList1.Images.SetKeyName(32, "10_of_clubs.png");
            ımageList1.Images.SetKeyName(33, "10_of_diamonds.png");
            ımageList1.Images.SetKeyName(34, "10_of_hearts.png");
            ımageList1.Images.SetKeyName(35, "10_of_spades.png");
            ımageList1.Images.SetKeyName(36, "ace_of_clubs.png");
            ımageList1.Images.SetKeyName(37, "ace_of_diamonds.png");
            ımageList1.Images.SetKeyName(38, "ace_of_hearts.png");
            ımageList1.Images.SetKeyName(39, "ace_of_spades.png");
            ımageList1.Images.SetKeyName(40, "back.png");
            ımageList1.Images.SetKeyName(41, "back@2x.png");
            ımageList1.Images.SetKeyName(42, "black_joker.png");
            ımageList1.Images.SetKeyName(43, "jack_of_clubs.png");
            ımageList1.Images.SetKeyName(44, "jack_of_diamonds.png");
            ımageList1.Images.SetKeyName(45, "jack_of_hearts.png");
            ımageList1.Images.SetKeyName(46, "jack_of_spades.png");
            ımageList1.Images.SetKeyName(47, "king_of_clubs.png");
            ımageList1.Images.SetKeyName(48, "king_of_diamonds.png");
            ımageList1.Images.SetKeyName(49, "king_of_hearts.png");
            ımageList1.Images.SetKeyName(50, "king_of_spades.png");
            ımageList1.Images.SetKeyName(51, "queen_of_clubs.png");
            ımageList1.Images.SetKeyName(52, "queen_of_diamonds.png");
            ımageList1.Images.SetKeyName(53, "queen_of_hearts.png");
            ımageList1.Images.SetKeyName(54, "queen_of_spades.png");
            ımageList1.Images.SetKeyName(55, "red_joker.png");
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(235, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblKurpiyerToplam
            // 
            lblKurpiyerToplam.Location = new Point(84, 127);
            lblKurpiyerToplam.Name = "lblKurpiyerToplam";
            lblKurpiyerToplam.Size = new Size(112, 33);
            lblKurpiyerToplam.TabIndex = 3;
            lblKurpiyerToplam.Text = "Kurpiyer";
            // 
            // listView1
            // 
            listView1.Location = new Point(546, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(667, 290);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblToplam2
            // 
            lblToplam2.Location = new Point(235, 127);
            lblToplam2.Name = "lblToplam2";
            lblToplam2.Size = new Size(112, 33);
            lblToplam2.TabIndex = 3;
            lblToplam2.Text = "label1";
            // 
            // pbBol2
            // 
            pbBol2.Location = new Point(145, 233);
            pbBol2.Name = "pbBol2";
            pbBol2.Size = new Size(69, 92);
            pbBol2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBol2.TabIndex = 1;
            pbBol2.TabStop = false;
            // 
            // pbBol
            // 
            pbBol.Location = new Point(70, 233);
            pbBol.Name = "pbBol";
            pbBol.Size = new Size(69, 92);
            pbBol.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBol.TabIndex = 1;
            pbBol.TabStop = false;
            // 
            // txtbox3
            // 
            txtbox3.Location = new Point(347, 49);
            txtbox3.Name = "txtbox3";
            txtbox3.Size = new Size(88, 27);
            txtbox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 27);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 502);
            Controls.Add(textBox2);
            Controls.Add(txtbox3);
            Controls.Add(listView1);
            Controls.Add(lblToplam2);
            Controls.Add(lblKurpiyerToplam);
            Controls.Add(pictureBox2);
            Controls.Add(pbBol);
            Controls.Add(pbBol2);
            Controls.Add(pictureBox1);
            Controls.Add(btnKartDagit);
            Controls.Add(btnBol);
            Controls.Add(btnKartCek);
            Controls.Add(btnGec);
            Controls.Add(btnDouble);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDouble;
        private Button btnGec;
        private Button btnKartCek;
        private Button btnBol;
        private Button btnKartDagit;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private PictureBox pictureBox2;
        private Label lblKurpiyerToplam;
        private ListView listView1;
        private Label lblToplam2;
        private PictureBox pbBol2;
        private PictureBox pbBol;
        private TextBox txtbox3;
        private TextBox textBox2;
    }
}
