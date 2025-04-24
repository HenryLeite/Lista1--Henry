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
    public partial class Form7_Henry : Form
    {
        public Form7_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dis, tempo, velo, litros;
                tempo = Convert.ToDouble(textBox3.Text);
                velo = Convert.ToDouble(textBox2.Text);
                dis = tempo * velo;
                litros = dis / 12;
                label4.Text = litros.ToString();
                label5.Text = dis.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            label4.Text = "_____________";
            label5.Text = "_____________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
