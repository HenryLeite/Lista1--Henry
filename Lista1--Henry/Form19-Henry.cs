using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lista1__Henry
{
    public partial class Form19_Henry : Form
    {
        public Form19_Henry()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dia, mes, ano;
                string resultado;
                ano = Convert.ToInt32(textBox1.Text);
                mes = Convert.ToInt32(textBox2.Text);
                dia = Convert.ToInt32(textBox3.Text);
                resultado = string.Concat("", dia, "/", mes, "/", ano);
                label5.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
