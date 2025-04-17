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
    public partial class Form11_Henry : Form
    {
        public Form11_Henry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               double n1, r1, r2;
                n1 = Convert.ToDouble(textBox1.Text);
                r1 = n1* n1;
                r2 = n1* n1 * n1;
                label4.Text = r1.ToString();
                label5.Text = r2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira os valores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "_____________";
            label5.Text = "_____________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
