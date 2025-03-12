using System.Windows.Forms;

namespace blackjacks
{
    public partial class Form1 : Form
    {
        List<kartlar> Deste = new List<kartlar>();
        List<kartlar> kurpiyer;
        List<kartlar> oyuncu;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KartDagýt();
            KartKarýþtýr();
            oyuncu = new List<kartlar>();
            kurpiyer = new List<kartlar>();

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
            int kartSayisi = 0;
            foreach (var kart in kartlar)
            {
                if (kart.deðerler == "A")
                {
                    As++;
                    skor += 11;
                }
                else if (kart.deðerler == "J" || kart.deðerler == "Q" || kart.deðerler == "K")
                {
                    kartSayisi++;
                    skor += 10;
                }
                else
                {
                    skor += int.Parse(kart.deðerler);
                }

                if (skor > 21 && As == 1)
                {
                    skor -= 10;

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
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;

            listView1.Columns.Add("Kurpiyer", 100);
            listView1.Columns.Add("oyuncu", 100);
            listView1.Columns.Add("Kurpiyer Toplam", 100);
            listView1.Columns.Add("Oyuncu Toplam", 100);

            ListViewItem item = new ListViewItem((Deste[0].ToString()));
            item.SubItems.Add(Deste[1].ToString());
            item.SubItems.Add(lblKurpiyerToplam.Text);
            item.SubItems.Add(lblToplam2.Text);

            ListViewItem item2 = new ListViewItem(Deste[2].ToString());
            item2.SubItems.Add(Deste[3].ToString());
            item2.SubItems.Add(lblKurpiyerToplam.Text);
            item2.SubItems.Add(lblToplam2.Text);

            listView1.Items.Add(item);
            listView1.Items.Add(item2);

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (oyuncu[1].deðerler == oyuncu[3].deðerler)
            {

            }
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


            pictureBox1.Image = ýmageList1.Images[0];
            pictureBox2.Image = ýmageList1.Images[1];
            Hesapla();

            btnDeneme_Click(sender, e);
        }
    }
}
