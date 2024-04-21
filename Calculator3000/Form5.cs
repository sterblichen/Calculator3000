using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3000
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btDividirNumero_Click(object sender, EventArgs e)
        {
            string sum_1 = tbDividir_1.Text.Trim();
            string sum_2 = tbDividir_2.Text.Trim();

            if (sum_1.Length == 0 && sum_2.Length == 0)
            {
                tbDividir_1.BackColor = Color.Red;
                tbDividir_2.BackColor = Color.Red;
                MessageBox.Show("Coloque un valor correspondiente");
                tbDividir_1.BackColor = Color.White;
                tbDividir_2.BackColor = Color.White;
            }
            else if (sum_1 == "0" && sum_2 == "0")
            {
                tbDividir_1.BackColor = Color.Red;
                tbDividir_2.BackColor = Color.Red;
                MessageBox.Show("No se puede dividir entre cero");
                tbDividir_1.BackColor = Color.White;
                tbDividir_2.BackColor = Color.White;
            }
            else
            {
                try
                {
                    double num_1 = Convert.ToDouble(sum_1);
                    double num_2 = Convert.ToDouble(sum_2);
                    double resultado = num_1 / num_2;
                    MessageBox.Show("La Division de los numeros es: " + resultado);
                }
                catch (Exception ex)
                {

                    if (sum_1.Length != 0 && sum_2.Length != 0)
                    {
                        tbDividir_1.BackColor = Color.Red;
                        tbDividir_2.BackColor = Color.Red;
                        MessageBox.Show("Coloque un valor de tipo numerico");
                        tbDividir_1.BackColor = Color.White;
                        tbDividir_2.BackColor = Color.White;
                    }
                    else if (sum_1.Length != 0)
                    {
                        tbDividir_1.BackColor = Color.Red;
                        MessageBox.Show("Coloque un valor de tipo numerico");
                        tbDividir_1.BackColor = Color.White;
                    }
                    else if (sum_2.Length != 0)
                    {
                        tbDividir_2.BackColor = Color.Red;
                        MessageBox.Show("Coloque un valor de tipo numerico");
                        tbDividir_2.BackColor = Color.White;
                    }

                }
            }
            

            tbDividir_1.Clear();
            tbDividir_2.Clear();
        }
    }
}
