using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista1__Henry
{
    public partial class Form13_Henry : Form
    {
        public Form13_Henry()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, n2, r1, r2, r3;
                n1 = Convert.ToDouble(textBox3.Text);
                n2 = Convert.ToDouble(textBox1.Text);
                r1 = n1 * n1;
                r2 = n2 * n2;
                r3 = r1 + r2;
                label3.Text = r3.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            label3.Text = "";
        }

        private void Form13_Henry_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
