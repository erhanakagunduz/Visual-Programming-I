using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buton yakalandığında ekrana mesaj veririz
            MessageBox.Show("Tebrikler Butonu Yakaladın");
            //Formun arka plan rengini değiştiriyoruz
            this.BackColor = Color.MediumVioletRed;
            //label1 in başlangıçta boş olan text ine yazı yazıyoruz
            label1.Text = "Afferin Bak ne yaptın";
            //label1 in yazı rengini beyaz yapıyoruz
            label1.ForeColor = Color.White;
            //butonumuzu saklıyoruz
            button1.Hide();

        }

        // Rastgele sayı üretmek için Random nesnesi
        Random r = new Random();
        // butonun boyutunu takip eden boyut isimli değişken
        int boyut = 50;

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // butonun boyutunu 5 piksel artır
            boyut += 5;

            // butonun pencere içindeki dikey (Y) konumunu rastgele değiştir
            // (0 ile pencerenin yüksekliği - 50 arasında bir değer seç)
            button1.Top = r.Next(0, this.Height - 50);

            // butonun pencere içindeki yatay (X) konumunu rastgele değiştir
            // (0 ile pencerenin genişliği - 50 arasında bir değer seç)
            button1.Left = r.Next(0, this.Width - 50);

            // butonun yeni boyutunu ayarla (fareyle üzerine her gelindiğinde buton büyür)
            button1.Width = boyut;
            button1.Height = boyut;
        }

    }
}
