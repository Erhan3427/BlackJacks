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

            lblKurpiyerToplam.Text = kurpiyerSkor.ToString();
            lblToplam2.Text = oyuncuSkor.ToString();
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
            item.SubItems.Add(lblKurpiyerToplam.Text);
            item.SubItems.Add(lblToplam2.Text);
            listView1.Items.Add(item);

            ListViewItem item2 = new ListViewItem(kurpiyer[1].ToString());
            item2.SubItems.Add(oyuncu[1].ToString());
            item2.SubItems.Add(lblKurpiyerToplam.Text);
            item2.SubItems.Add(lblToplam2.Text);
            listView1.Items.Add(item2);

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Bolme(); // Oyuncu eli bölünüyor
        }

        public void Bolme()
        {
            List<kartlar> yeniOyuncu = new List<kartlar>() { oyuncu[0] };
            List<kartlar> yeniOyuncu2 = new List<kartlar>();

            yeniOyuncu.Add(Deste[0]);
            yeniOyuncu.Add(Deste[2]);

            yeniOyuncu2.Add(Deste[1]);
            yeniOyuncu2.Add(Deste[3]);

            pbBol.Image = ýmageList1.Images[0];
            pbBol2.Image = ýmageList1.Images[1];

            Hesapla();
            btnBol.Enabled = false;
        }

        private void btnKartDagit_Click_1(object sender, EventArgs e)
        {
            KartKarýþtýr();
            kurpiyer.Clear();
            oyuncu.Clear();

            kurpiyer.Add(Deste[0]);
            kurpiyer.Add(Deste[2]);
            oyuncu.Add(Deste[1]);
            oyuncu.Add(Deste[3]);
            Deste.RemoveRange(0, 4);

            pictureBox1.Image = ýmageList1.Images[0];
            pictureBox2.Image = ýmageList1.Images[1];
            Hesapla();
            btnDeneme_Click(sender, e);
        }

        int i = 4;
        private void btnKartCek_Click(object sender, EventArgs e)
        {
            if (i < Deste.Count)
            {
                oyuncu.Add(Deste[i]); // Oyuncuya kart çekiliyor
                ListViewItem cekilenKart = new ListViewItem(Deste[i].ToString());
                listView1.Items.Add(cekilenKart);
                Deste.RemoveAt(i);//çekilen kart siliniyo
                i++;


                int oyuncuSkoruSon=SkorHesapla(oyuncu);
                lblToplam2.Text=oyuncuSkoruSon.ToString();


                //if (oyuncuSkoruSon > 21)
                //{
                //    MessageBox.Show("21 i geçtin patladýn");
                //    return;

                //}


            }
        }
    }
}
