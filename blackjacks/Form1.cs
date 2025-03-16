using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace blackjacks
{
    public partial class Form1 : Form
    {
        // Kart destesi ve oyuncularýn elleri
        List<kartlar> Deste = new List<kartlar>();
        List<kartlar> kurpiyer = new List<kartlar>();
        List<kartlar> oyuncu = new List<kartlar>();
        Random random;
        public int kalanSaniye = 60;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KartDagýt(); // Kart destesi oluþturuluyor
            KartKarýþtýr(); // Kartlar karýþtýrýlýyor
        }






        public void KartDagýt()
        {
            string[] kart2 = ["karo", "sinek", "maça", "kupa"];
            string[] deðerler2 = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (var item in kart2)
            {
                foreach (var item1 in deðerler2)
                {
                    kartlar kartlar = new kartlar(item, item1);
                    Deste.Add(kartlar);
                }
            }
        }

        void KartKarýþtýr()
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

                // Eðer As varken skor 21'i geçerse, 10 çýkararak As'ý 1 sayarýz
                if (skor > 21 && As == 1)
                {
                    skor -= 10;
                    As--;
                }

                // Oyuncunun ilk iki kartý aynýysa "Bölme" seçeneði aktif edilir
                if (oyuncu[0].degerler == oyuncu[1].degerler)
                {
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
            int kurpiyerSkor = SkorHesapla(kurpiyer);
            int oyuncuSkor = SkorHesapla(oyuncu);
            switch (kurpiyer[0].degerler)
            {
                case "A": lblKurpiyerToplam.Text = "11"; break;
                case "J": 
                case "Q": 
                case "K": lblKurpiyerToplam.Text = "10"; break;
                default: lblKurpiyerToplam.Text = kurpiyer[0].degerler; break;
            }
          
            lblToplam2.Text = oyuncuSkor.ToString();
        }





        public void Bolme()
        {
            List<kartlar> yeniOyuncu = new List<kartlar>() { oyuncu[0] };
            List<kartlar> yeniOyuncu2 = new List<kartlar>() { oyuncu[1] };

            yeniOyuncu.Add(Deste[0]);

            yeniOyuncu2.Add(Deste[1]);

            pbBol.Image = ýmageList1.Images[0];
            pbBol2.Image = ýmageList1.Images[1];

            Hesapla();
            SonucHesapla();
            btnBol.Enabled = false;
        }


        public void KartGoster()
        {
            for (int i = 0; i < Deste.Count; i++)
            {
                pictureBox1.Image = ýmageList1.Images[i];
                pictureBox2.Image = ýmageList1.Images[i + 1];

            }

        }
        public void BitenKartDagit()
        {
            kurpiyer.Clear();
            oyuncu.Clear();
            Deste.Clear();
            KartKarýþtýr();
            KartDagýt();


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
                MessageBox.Show("21'i geçtiniz, kaybettiniz!");
            }
            else if (kurpiyerSkoru > 21 || oyuncuSkoru > kurpiyerSkoru)
            {
                MessageBox.Show("Tebrikler, kazandýnýz!");
            }
            else if (oyuncuSkoru == kurpiyerSkoru)
            {
                MessageBox.Show("Berabere!");
            }
            else
            {
                MessageBox.Show("Kaybettiniz!");
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



        private void btnDeneme_Click(object sender, EventArgs e)
        {
            // ListView temizleniyor ve baþlýklar ekleniyor
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


            // Ýlk oyuncu ve kurpiyer kartlarýný listView'e ekleme
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



        private void btnBol_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Bolme(); // Oyuncu eli bölünüyor
        }




        int i = 4;
        int kartSayisi = 0;
        private void btnKartCek_Click(object sender, EventArgs e)
        {
            if (i < Deste.Count)
            {

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Width = pictureBox1.Width;
                pictureBox1.Height = pictureBox1.Height;
                pictureBox1.Image = ýmageList1.Images[kartSayisi];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox1.Location = new Point(85, 200);
                this.Controls.Add(pictureBox1);

                oyuncu.Add(Deste[i]); // Oyuncuya kart çekiliyor
                ListViewItem cekilenKart = new ListViewItem(Deste[i].ToString());
                listView1.Items.Add(cekilenKart);
                Deste.RemoveAt(i);//çekilen kart siliniyo
                i++;


                int oyuncuSkoruSon = SkorHesapla(oyuncu);
                lblToplam2.Text = oyuncuSkoruSon.ToString();
       
                KartGoster();

                if (oyuncuSkoruSon > 21)
                {
                    MessageBox.Show("21 geçtiniz kaybettiniz");
                    Thread.Sleep(1000);
                    btnKartDagit_Click(sender, e);

                }
                kartSayisi++;

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
                ListViewItem cekilenKart2 = new ListViewItem(Deste[0].ToString());
                listView1.Items.Add(cekilenKart2);
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
            kalanSaniye = 60; // Süreyi sýfýrla
            pgsSaniyeBari.Value = 0; // ProgressBar'ý sýfýrla
            btnGec.Enabled = true;
            btnDouble.Enabled = true;

            Timer();
            btnKartCek.Enabled = true;

            if (Deste.Count <= 0)
            {
                MessageBox.Show("Yeterli kart kalmadý.Baþtan daðýtýlýyor");
                BitenKartDagit();
            }

            KartKarýþtýr();
            kurpiyer.Clear();
            oyuncu.Clear();

            kurpiyer.Add(Deste[0]);
            kurpiyer.Add(Deste[2]);
            oyuncu.Add(Deste[1]);
            oyuncu.Add(Deste[3]);
            KartGoster();


            Deste.RemoveRange(0, 4);
            Hesapla();
            btnDeneme_Click(sender, e);
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
                MessageBox.Show("Süreniz doldu");
                btnKartDagit.Enabled = true;
            }

        }
    }
}
