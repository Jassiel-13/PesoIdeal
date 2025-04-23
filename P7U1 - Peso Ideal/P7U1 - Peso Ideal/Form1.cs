using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7U1___Peso_Ideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double PesoIdeal = 0;
            double Altura;

            if (double.TryParse(textBox3.Text, out Altura))
            {
                if (radioH.Checked)
                {
                    PesoIdeal = (Altura - 100) * 0.90;
                }
                else if (radioM.Checked)
                {
                    PesoIdeal = (Altura - 100) * 0.85;
                }
                textBox4.Text = PesoIdeal.ToString("F2") + " kg";
            }
            else 
            {
                MessageBox.Show("Ingrese una Altura Valida por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
