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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista1__Henry
{
    public partial class Form20_Henry: Form
    {
        public Form20_Henry()
        {
            InitializeComponent();
        }

        private void Form20_Henry_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label4.Text = "_____________";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ano, semestre, ordem, rm, data, semestre2;
                ano = Convert.ToString(textBox1.Text);
                semestre = Convert.ToString(textBox3.Text);
                ordem = Convert.ToString(textBox4.Text);
                rm = string.Concat("", ano, semestre, ordem);
                data = string.Concat("20", ano);
                semestre2 = string.Concat("",semestre, " Semestre");
                label7.Text = data.ToString();
                label4.Text = semestre2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
