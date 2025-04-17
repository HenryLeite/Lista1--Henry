using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista1__Henry
{
    public partial class Form18_Henry: Form
    {
        public Form18_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ht, vh, pc, sb, sl, sl2, td;
                ht = Convert.ToDouble(textBox1.Text);
                vh = Convert.ToDouble(textBox2.Text);
                pc = Convert.ToDouble(textBox3.Text);
                sb = ht * vh;
                td = pc / 100 * sb;
                sl = td % 90;
                sl2 = sl % 95;
                label5.Text = sl2.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
