using BlackJackClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjacks
{
    public partial class Bankamatik : Form
    {
        Banka banka = new Banka();
        public Bankamatik()
        {
            InitializeComponent();
            mtbCekilecekTutar.SelectionStart = 0;
            mtbCekilecekTutar.PromptChar = ' ';
            lblBakiye.Text = banka.Bakiye.ToString("C");
        }
        private void Bankamatik_Load(object sender, EventArgs e)
        {

            mtbCekilecekTutar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbCekilecekTutar.Leave += mtbCekilecekTutar_Leave;


        }


        private void btnParaCek_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(mtbCekilecekTutar.Text, out decimal cekilecekTutar))
                {
                    MessageBox.Show("Hatalı isim soyisim");
                }

                else if (string.IsNullOrEmpty(txtİsimSoyisim.Text) || txtİsimSoyisim.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Lütfen isim soyisim kısmını doğru giriniz");

                }
                else if (cekilecekTutar > banka.Bakiye)
                {
                    MessageBox.Show("Yetersiz bakiye.");
                    return;
                }
                else
                {
                    banka.Bakiye -= Convert.ToDecimal(mtbCekilecekTutar.Text);
                    lblBakiye.Text = banka.Bakiye.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(mtbCekilecekTutar.Text, out decimal cekilecekTutar))
            {
                MessageBox.Show("Hatalı isim soyisim");
            }
            else if (string.IsNullOrEmpty(txtİsimSoyisim.Text) || txtİsimSoyisim.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Lütfen isim soyisim kısmını doğru giriniz");

            }
            else if (cekilecekTutar <= 0)
            {
                MessageBox.Show("0 dan küçük para yatırılmaz");


            }
            else
            {
                banka.Bakiye += Convert.ToDecimal(mtbCekilecekTutar.Text);
                lblBakiye.Text = banka.Bakiye.ToString("C");
            }


        }



        private void mtbCekilecekTutar_Leave(object sender, EventArgs e)
        {
            mtbCekilecekTutar.SelectionStart = 0;
        }



    }

}
