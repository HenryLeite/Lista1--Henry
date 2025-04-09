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
    public partial class Form3_Henry : Form
    {
        public Form3_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ht, vh, pc, sb, sl, td;
            ht = Convert.ToDouble(textBox1.Text);
            vh = Convert.ToDouble(textBox2.Text);
            pc = Convert.ToDouble(textBox3.Text);
            sb = ht * vh;
            td = pc / 100 * sb;
            sl = sb - td;
            label5.Text = sl.ToString("F2");
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
