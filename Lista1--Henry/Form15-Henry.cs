using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista1__Henry
{
    public partial class Form15_Henry : Form
    {
        public Form15_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            label4.Text = n2.ToString();
            label5.Text = n1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "_____________";
            label5.Text = "_____________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
