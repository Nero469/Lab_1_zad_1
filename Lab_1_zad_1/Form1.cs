using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_zad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void y_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBoxWynik.Text = (x + y + z).ToString();
            }
            catch
            {
                MessageBox.Show("Podano bledne dane ", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void Iloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBoxWynik.Text = (x * y * z).ToString();
            }
            catch
            {
                MessageBox.Show("Podano bledne dane ", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void Wyjście_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
