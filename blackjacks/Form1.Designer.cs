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
            button1 = new Button();
            button2 = new Button();
            btnKartCek = new Button();
            btnBol = new Button();
            btnKartDagit = new Button();
            pictureBox1 = new PictureBox();
            ımageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            lblKurpiyerToplam = new Label();
            listView1 = new ListView();
            lblToplam2 = new Label();
            pictureBox3 = new PictureBox();
            pbBol2 = new PictureBox();
            pbBol = new PictureBox();
            txtbox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(515, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 64);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(386, 331);
            button2.Name = "button2";
            button2.Size = new Size(112, 64);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnKartCek
            // 
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
            btnBol.Click += btnBol_Click;
            // 
            // btnKartDagit
            // 
            btnKartDagit.Location = new Point(27, 24);
            btnKartDagit.Name = "btnKartDagit";
            btnKartDagit.Size = new Size(112, 64);
            btnKartDagit.TabIndex = 0;
            btnKartDagit.Text = "kartları Dağıt";
            btnKartDagit.UseVisualStyleBackColor = true;
            btnKartDagit.Click += btnKartDagit_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(84, 163);
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
            ımageList1.Images.SetKeyName(0, "sK.jpg");
            ımageList1.Images.SetKeyName(1, "K.jpg");
            ımageList1.Images.SetKeyName(2, "K.jpg");
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
            lblKurpiyerToplam.Text = "label1";
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
            // pictureBox3
            // 
            pictureBox3.Location = new Point(386, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
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
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pbBol);
            Controls.Add(pbBol2);
            Controls.Add(pictureBox1);
            Controls.Add(btnKartDagit);
            Controls.Add(btnBol);
            Controls.Add(btnKartCek);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnKartCek;
        private Button btnBol;
        private Button btnKartDagit;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private PictureBox pictureBox2;
        private Label lblKurpiyerToplam;
        private ListView listView1;
        private Label lblToplam2;
        private PictureBox pictureBox3;
        private PictureBox pbBol2;
        private PictureBox pbBol;
        private TextBox txtbox3;
        private TextBox textBox2;
    }
}
