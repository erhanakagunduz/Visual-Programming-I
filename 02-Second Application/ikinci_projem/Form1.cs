using System;
using System.Windows.Forms;

namespace ikinci_projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Msj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Özalp Meslek Yüksekokulu Bilgisayar Programcılığı öğrencileri",
                "Mesaj Başlığı",MessageBoxButtons.YesNoCancel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
        }
    }
}
