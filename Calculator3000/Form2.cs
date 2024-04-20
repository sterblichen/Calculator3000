using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3000
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btSumarNumero_Click(object sender, EventArgs e)
        {

            string sum_1 = tbSuma_1.Text.Trim();
            string sum_2 = tbSuma_2.Text.Trim();

            if (sum_1.Length == 0 && sum_2.Length == 0)
            {
                MessageBox.Show("Coloque un valor correspondiente");
            }
            try
            {
                double num_1 = Convert.ToDouble(sum_1);
                double num_2 = Convert.ToDouble(sum_2);
                double resultado = num_1 + num_2;
                MessageBox.Show("La suma de ambos numeros es: " + resultado);

            }
            catch (Exception ex)
            {

                if(sum_1.Length != 0 && sum_2.Length != 0)
                {
                    tbSuma_1.BackColor = Color.Red;
                    tbSuma_2.BackColor = Color.Red;
                    MessageBox.Show("Coloque un valor de tipo numerico");
                    tbSuma_1.BackColor = Color.White;
                    tbSuma_2.BackColor = Color.White;
                }
                else if( sum_1.Length != 0)
                {
                     tbSuma_1.BackColor = Color.Red;
                     MessageBox.Show("Coloque un valor de tipo numerico");
                     tbSuma_1.BackColor = Color.White;
                }
                else if(sum_2.Length != 0)
                {
                    tbSuma_2.BackColor = Color.Red;
                    MessageBox.Show("Coloque un valor de tipo numerico");
                    tbSuma_2.BackColor = Color.White;
                }
                
            }

            tbSuma_1.Clear();
            tbSuma_2.Clear();

        }
    }
}
