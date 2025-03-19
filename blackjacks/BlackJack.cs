using BlackJackClass;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace blackjacks
{
    public partial class BlackJack : Form
    {
        // Kart destesi ve oyuncular�n elleri
        List<kartlar> Deste = new List<kartlar>();//Sistemdeki en ba�ta eklenen kartlar
        List<kartlar> kurpiyer = new List<kartlar>();//kurpiyerin kartlar�
        List<kartlar> oyuncu = new List<kartlar>();//oyuncunun kartlar�
        List<PictureBox> kartlarResim = new List<PictureBox>(); // Kartlar� saklayan liste

        Random random = new Random();
        Banka Banka = new Banka();
        decimal yat�r�lanPara = 0;
        public int kalanSaniye = 60;

        public BlackJack()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KartDag�t(); // Kart destesi olu�turuluyor
            KartKaristir(); // Kartlar kar��t�r�l�yor
            lblBakiyeOyun.Text = Banka.Bakiye.ToString("C");

        }




        int ResimIndex = 0;
        //
        public void KartDag�t()
        {
            string[] kart2 = ["karo", "sinek", "ma�a", "kupa"];
            string[] de�erler2 = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (var Kart�sim in kart2)//kart isimlerini ve de�erlerini ekliyoruz
            {
                foreach (var KartSayi in de�erler2)
                {
                    kartlar kartlar = new kartlar(Kart�sim, KartSayi);
                    kartlar.Imageindex = ResimIndex;//resim indexini ekliyoruz
                    Deste.Add(kartlar);//deste listesine ekliyoruz
                    ResimIndex++;
                }
            }
        }

        void KartKaristir()//kartlar� kar��t�r�yoruz
        {
            int n = Deste.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var suanki = Deste[k];
                Deste[k] = Deste[n];
                Deste[n] = suanki;
            }
        }

        public int SkorHesapla(List<kartlar> kartlar)
        {
            int As = 0;
            int skor = 0;
            foreach (var kart in kartlar)
            {
                if (kart.degerler == "A")
                {
                    As++;
                    skor += 11;
                }
                else if (kart.degerler == "J" || kart.degerler == "Q" || kart.degerler == "K")
                {
                    skor += 10;
                }
                else
                {
                    skor += int.Parse(kart.degerler);
                }

                // E�er As varken skor 21'i ge�erse, 10 ��kararak As'� 1 sayar�z
                if (skor > 21 && As == 1)
                {
                    skor -= 10;
                    As--;
                }

                // Oyuncunun ilk iki kart� ayn�ysa "B�lme" se�ene�i aktif edilir
                if (oyuncu.Count >= 2 && oyuncu[0].degerler == oyuncu[1].degerler)
                {
                    btnBol.Visible = true;
                    btnBol.Enabled = true;
                }
                else
                {
                    btnBol.Enabled = false;
                }
            }
            return skor;
        }


        public void Hesapla()
        {
            int oyuncuSkor = SkorHesapla(oyuncu);//Oyuncunun skoru hesaplan�yor
            switch (kurpiyer[0].degerler)//Kurpiyerin ilk kart� hesaplan�yor
            {
                case "A": lblKurpiyerToplam.Text = "11"; break; //e�er A ise 11 say�l�r
                case "J":
                case "Q":
                case "K": lblKurpiyerToplam.Text = "10"; break;
                default: lblKurpiyerToplam.Text = kurpiyer[0].degerler; break;//Di�er kartlar
            }

            lblToplam2.Text = oyuncuSkor.ToString();//Oyuncunun skoru yazd�r�l�yor
        }





        public void Bolme()
        {

            // Oyuncunun elini ikiye b�l
            List<kartlar> yeniOyuncu = new List<kartlar>() { oyuncu[0] };
            List<kartlar> yeniOyuncu2 = new List<kartlar>() { oyuncu[1] };

            // Her bir yeni ele birer kart ekle
            yeniOyuncu.Add(Deste[0]);
            yeniOyuncu2.Add(Deste[1]);

            // Eski oyuncu elini temizle ve yeni ellerle de�i�tir
            oyuncu.Clear();

            pbBol.Image = �mageList1.Images[0];
            pbBol2.Image = �mageList1.Images[1];

            // PictureBox'lar� g�r�n�r yap
            pbBol.Visible = true;
            pbBol2.Visible = true;

            // Desteden �ekilen kartlar� sil
            Deste.RemoveRange(0, 2);

            Hesapla();
            SonucHesapla();

            // B�lme butonunu devre d��� b�rak
            btnBol.Enabled = false;
        }


        public void OyuncuKartGoster()
        {

            // Oyuncunun elindeki kartlar� g�ster
            for (int i = 0; i < oyuncu.Count; i++)
            {
                //PictureBox pictureBox = new PictureBox
                //{
                //    Width = 80,
                //    Height = 120,
                //    SizeMode = PictureBoxSizeMode.StretchImage,
                //    Location = new Point(335 + (i * 110), 250) // Kartlar yatay olarak s�ralan�r
                //};

                // ImageList'ten do�ru resmi al
                pbOyuncu.Image = �mageList1.Images[oyuncu[0].Imageindex];
                pbOyuncu2.Image = �mageList1.Images[oyuncu[1].Imageindex];  

                // PictureBox'� forma ekle
                //this.Controls.Add(pictureBox);
                //pictureBox.BringToFront();

                //// PictureBox'� listeye ekle
                //kartlarResim.Add(pictureBox);
            }
        }
        public void BitenKartDagit()
        {
            kurpiyer.Clear();
            oyuncu.Clear();
            Deste.Clear();
            KartKaristir();
            KartDag�t();


        }
        public void SonucHesapla()
        {
            kalanSaniye = 60;
            timer1.Stop();
            pgsSaniyeBari.Value = 0;

            int kurpiyerSkoru = SkorHesapla(kurpiyer);
            int oyuncuSkoru = SkorHesapla(oyuncu);

            lblKurpiyerToplam.Text = kurpiyerSkoru.ToString();
            lblToplam2.Text = oyuncuSkoru.ToString();

            if (oyuncuSkoru > 21)
            {
                MessageBox.Show("21'i ge�tiniz, kaybettiniz!");
                GuncelBakiye(-yat�r�lanPara);
                KartSil();
            }
            else if (kurpiyerSkoru > 21 || oyuncuSkoru > kurpiyerSkoru)
            {
                MessageBox.Show("Tebrikler, kazand�n�z!");
                GuncelBakiye(yat�r�lanPara * 2);
                KartSil();
            }
            else if (oyuncuSkoru == kurpiyerSkoru)
            {
                MessageBox.Show("Berabere!");
                KartSil();
            }
            else
            {
                MessageBox.Show("Kaybettiniz!");
                GuncelBakiye(-yat�r�lanPara);
                KartSil();
            }

            lblYatirilanPara.Text = "0";
        }

        private void GuncelBakiye(decimal bakiyet)
        {
            if (decimal.TryParse(lblBakiyeOyun.Text, out decimal mevcutBakiye))
            {
                Banka.Bakiye = (mevcutBakiye + bakiyet);
            }
            else
            {
                MessageBox.Show("Bakiye g�ncellenemedi. L�tfen tekrar deneyin.");
            }
        }

        public void Timer()
        {
            timer1.Stop(); 
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;
            kalanSaniye = 60;
            pgsSaniyeBari.Value = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }
        public void kartCek()
        {

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Width = 80;
            pictureBox1.Height = 120;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = �mageList1.Images[oyuncu[0].Imageindex];

            pictureBox1.Location = new Point(450 + (kartlarResim.Count * 110), 250);
            pictureBox1.BringToFront();

            this.Controls.Add(pictureBox1);
            kartlarResim.Add(pictureBox1);//resimleri listeye at�yoruz 


        }
        public void KartSil()
        {
            foreach (var pictureBox in kartlarResim)
            {
                this.Controls.Remove(pictureBox);
                pictureBox.Dispose(); // Haf�zadan kald�r
            }
            kartlarResim.Clear(); // Listeyi s�f�rla

        }


        private void btnDeneme_Click(object sender, EventArgs e)
        {
            // ListView temizleniyor ve ba�l�klar ekleniyor
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Kurpiyer", 100);
            listView1.Columns.Add("oyuncu", 100);
            listView1.Columns.Add("Kurpiyer Toplam", 100);
            listView1.Columns.Add("Oyuncu Toplam", 100);
            listView1.Columns.Add("yeni oyuncu", 100);
            listView1.Columns.Add("yeni oyuncu", 100);
            listView1.Columns.Add("yeni oyuncu2", 100);
            listView1.Columns.Add("yeni oyuncu2", 100);

            listView1.Items.Clear();


            // �lk oyuncu ve kurpiyer kartlar�n� listView'e ekleme
            ListViewItem item = new ListViewItem((kurpiyer[0].ToString()));
            item.SubItems.Add(oyuncu[0].ToString());
            item.SubItems.Add(SkorHesapla(kurpiyer).ToString());
            item.SubItems.Add(SkorHesapla(oyuncu).ToString());
            listView1.Items.Add(item);

            ListViewItem item2 = new ListViewItem(kurpiyer[1].ToString());
            item2.SubItems.Add(oyuncu[1].ToString());
            item2.SubItems.Add(SkorHesapla(kurpiyer).ToString());
            item2.SubItems.Add(SkorHesapla(oyuncu).ToString());
            listView1.Items.Add(item2);

        }



        private void btnBol_Click_1(object sender, EventArgs e)
        {
            pbOyuncu.Visible = false;
            pbKurpiyer.Visible = false;
            pbBol.Visible = true;
            pbBol2.Visible = true;
            Bolme(); // Oyuncu eli b�l�n�yor
        }




        int i = 4;
        private void btnKartCek_Click(object sender, EventArgs e)
        {
            if (i < Deste.Count)
            {


                oyuncu.Add(Deste[i]); // Oyuncuya kart �ekiliyor
                ListViewItem cekilenKart = new ListViewItem(Deste[i].ToString());
                listView1.Items.Add(cekilenKart);

                kartCek();
                Deste.RemoveAt(i);//�ekilen kart siliniyo
                i++;


                int oyuncuSkoruSon = SkorHesapla(oyuncu);
                lblToplam2.Text = oyuncuSkoruSon.ToString();


                if (oyuncuSkoruSon > 21)
                {
                    MessageBox.Show("21 ge�tiniz kaybettiniz");

                    btnKartDagit_Click(sender, e);

                }

            }
        }




        private void btnGec_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pgsSaniyeBari.Value = 0;
            kalanSaniye = 60;

            btnKartCek.Enabled = false;

            int kurpiyerSkoru = SkorHesapla(kurpiyer);
            int oyuncuSkoru = SkorHesapla(oyuncu);
            while (SkorHesapla(kurpiyer) < 17 && Deste.Count > 0)
            {
                kurpiyer.Add(Deste[0]);
                PictureBox pictureBox2 = new PictureBox();
                ListViewItem cekilenKart2 = new ListViewItem(Deste[0].ToString());
                listView1.Items.Add(cekilenKart2);


                pictureBox2.Size = new Size(80, 120);  // Boyut ayarla
                pictureBox2.Location = new Point(660, 12);
                pictureBox2.Image = �mageList1.Images[kurpiyer[^1].Imageindex];
                this.Controls.Add(pictureBox2);



                Deste.RemoveAt(0);
                lblKurpiyerToplam.Text = kurpiyerSkoru.ToString();
                lblToplam2.Text = oyuncuSkoru.ToString();
            }
            lblKurpiyerToplam.Text = kurpiyerSkoru.ToString();
            SonucHesapla();
            btnKartDagit_Click(sender, e);

        }






        private void btnKartDagit_Click(object sender, EventArgs e)
        {
            OyuncuKartGoster();
            btnBol.Visible = false;
            pbBol.Visible = false;
            pbBol2.Visible = false;

            kalanSaniye = 60; // S�reyi s�f�rla
            pgsSaniyeBari.Value = 0; // ProgressBar'� s�f�rla
            btnGec.Enabled = true;
            btnDouble.Enabled = true;

            Timer();
            btnKartCek.Enabled = true;

            OyuncuKartGoster();
            if (Deste.Count <= 0)
            {
                MessageBox.Show("Yeterli kart kalmad�.Ba�tan da��t�l�yor");
                BitenKartDagit();
            }
            else
            {

                
                kurpiyer.Clear();
                oyuncu.Clear();
                if (Deste.Count >= 4)
                {
                    kurpiyer.Add(Deste[0]);
                    kurpiyer.Add(Deste[2]);
                    oyuncu.Add(Deste[1]);
                    oyuncu.Add(Deste[3]);
                    OyuncuKartGoster();
                    pbKurpiyer.Image = �mageList1.Images[kurpiyer[0].Imageindex];
                    pbKurpiyer2.Image = �mageList1.Images[kurpiyer[1].Imageindex];
                    Deste.RemoveRange(0, 4);
                    Hesapla();
                    btnDeneme_Click(sender, e);

                }
                else { BitenKartDagit(); }



            }
        }



        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (Deste.Count > 0)
            {
                oyuncu.Add(Deste[0]);
                ListViewItem cekilenKart = new ListViewItem(Deste[i].ToString());
                listView1.Items.Add(cekilenKart);
                Deste.RemoveAt(0);
                btnGec_Click(sender, e);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            kalanSaniye--;
            pgsSaniyeBari.Value = 60 - kalanSaniye;
            lblSaniye.Text = kalanSaniye.ToString();
            if (kalanSaniye <= 0)
            {
                timer1.Stop();
                MessageBox.Show("S�reniz doldu");
                btnKartDagit.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            Bankamatik banka = new Bankamatik();
            banka.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnPara1_Click(object sender, EventArgs e)
        {
            yat�r�lanPara = 0;
            if (decimal.TryParse(lblYatirilanPara.Text, out decimal mevcutBakiye))
            {
                yat�r�lanPara += 100;
                lblYatirilanPara.Text = (mevcutBakiye + yat�r�lanPara).ToString();
            }

        }
    }
}
