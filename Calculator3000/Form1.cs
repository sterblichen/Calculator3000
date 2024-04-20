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
    public partial class Form1 : Form
    {
        Form2 formularioSuma;
        Form3 formularioResta;
        Form4 formularioMultiplicacion;
        Form5 formularioDivision;
        public Form1()
        {
            InitializeComponent();
            formularioSuma = new Form2();
            formularioResta = new Form3();
            formularioMultiplicacion = new Form4();
            formularioDivision = new Form5();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                formularioSuma.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1) {
                formularioResta.ShowDialog();

            } else if (comboBox1.SelectedIndex == 2) {
                formularioMultiplicacion.ShowDialog();


            } else if (comboBox1.SelectedIndex == 3) {
                formularioDivision.ShowDialog();

            }
        }
    }
}
