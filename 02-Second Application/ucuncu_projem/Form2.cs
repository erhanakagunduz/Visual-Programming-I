using System;
using System.Drawing;
using System.Windows.Forms;

namespace ucuncu_projem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";

            textBox1.ForeColor = Color.Red;
            listBox1.ForeColor = Color.BlueViolet; 
        }
    }
}
