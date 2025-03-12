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
            button3 = new Button();
            btnBol = new Button();
            btnKartDagit = new Button();
            pictureBox1 = new PictureBox();
            ımageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            lblKurpiyerToplam = new Label();
            listView1 = new ListView();
            btnDeneme = new Button();
            lblToplam2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(697, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 64);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(546, 331);
            button2.Name = "button2";
            button2.Size = new Size(112, 64);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(386, 331);
            button3.Name = "button3";
            button3.Size = new Size(112, 64);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnBol
            // 
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
            btnKartDagit.Location = new Point(84, 331);
            btnKartDagit.Name = "btnKartDagit";
            btnKartDagit.Size = new Size(112, 64);
            btnKartDagit.TabIndex = 0;
            btnKartDagit.Text = "kartları Dağıt";
            btnKartDagit.UseVisualStyleBackColor = true;
            btnKartDagit.Click += btnKartDagit_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(84, 173);
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
            listView1.Location = new Point(466, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(747, 290);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeneme
            // 
            btnDeneme.Location = new Point(84, 12);
            btnDeneme.Name = "btnDeneme";
            btnDeneme.Size = new Size(112, 64);
            btnDeneme.TabIndex = 0;
            btnDeneme.Text = "hesapdeneme";
            btnDeneme.UseVisualStyleBackColor = true;
            btnDeneme.Click += btnDeneme_Click;
            // 
            // lblToplam2
            // 
            lblToplam2.Location = new Point(235, 127);
            lblToplam2.Name = "lblToplam2";
            lblToplam2.Size = new Size(112, 33);
            lblToplam2.TabIndex = 3;
            lblToplam2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 502);
            Controls.Add(listView1);
            Controls.Add(lblToplam2);
            Controls.Add(lblKurpiyerToplam);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnKartDagit);
            Controls.Add(btnDeneme);
            Controls.Add(btnBol);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnBol;
        private Button btnKartDagit;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private PictureBox pictureBox2;
        private Label lblKurpiyerToplam;
        private ListView listView1;
        private Button btnDeneme;
        private Label lblToplam2;
    }
}
