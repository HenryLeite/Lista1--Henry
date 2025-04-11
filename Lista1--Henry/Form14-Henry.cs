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
    public partial class Form14_Henry : Form
    {
        public Form14_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, r1, r2;
            n1 = Convert.ToDouble(textBox3.Text);
            n2 = Convert.ToDouble(textBox1.Text);
            r1 = n1 + n2;
            r2 = r1 / 2;
            label3.Text = r2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
