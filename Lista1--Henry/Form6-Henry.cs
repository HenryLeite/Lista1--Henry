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
    public partial class Form6_Henry : Form
    {
        public Form6_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alt, raio, area;
            alt = Convert.ToDouble(textBox1.Text);
            raio = Convert.ToDouble(textBox2.Text);
            area = (raio * raio) * alt;
            label4.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "_____________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
