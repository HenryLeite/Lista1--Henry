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
    public partial class Form4_Henry : Form
    {
        public Form4_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, resultado;
            v1 = Convert.ToDouble(textBox1.Text);
            resultado = (v1 - 32) * 0.55;
            label3.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
