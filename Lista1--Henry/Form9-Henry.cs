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
    public partial class Form9_Henry : Form
    {
        public Form9_Henry()
        {
            InitializeComponent();
        }

        private void Form9_Henry_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label4.Text = "_____________";
            label5.Text = "_____________";
            label11.Text = "_____________";
            label9.Text = "_____________";
            label13.Text = "_____________";
            label15.Text = "_____________";
            label25.Text = "_____________";
            label27.Text = "_____________";
            label21.Text = "_____________";
            label17.Text = "_____________";
            label23.Text = "_____________";
            label19.Text = "_____________";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                double A, B, C, D, AMB, AMC, AMD, BMC, BMD, CMD, AXB, AXC, AXD, BXC, BXD, CXD;
                B = Double.Parse(textBox1.Text);
                A = Double.Parse(textBox2.Text);
                C = Double.Parse(textBox3.Text);
                D = Double.Parse(textBox4.Text);

                AMB = A + B;
                AMC = A + C;
                AMD = A + D;
                BMC = B + C;
                BMD = B + D;
                CMD = C + D;

                AXB = A * B;
                AXC = A * C;
                AXD = A * D;
                BXC = B * C;
                BXD = B * D;
                CXD = C * D;

                label4.Text = AMB.ToString();
                label9.Text = AMC.ToString();
                label5.Text = AMD.ToString();
                label11.Text = BMC.ToString();
                label13.Text = BMD.ToString();
                label15.Text = CMD.ToString();

                label27.Text = AXB.ToString();
                label23.Text = AXC.ToString();
                label25.Text = AXD.ToString();
                label21.Text = BXC.ToString();
                label19.Text = BXD.ToString();
                label17.Text = CXD.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
