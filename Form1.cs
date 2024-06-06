using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convensor_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declara as variaveis
            int Tcel, Tkel, Tfah;

            // Ler a Temperatura em Celsius a ser convertida
            Tcel = int.Parse(textBox1.Text);
            // Vale destacar que a linha de cima, faz a conversão do valor que será digitdo em textBox1 do tipo string, em valor Int

            // Calculando as Conversões
            Tkel = Tcel + 273;
            Tfah = (((Tcel * 9) / 5) + 32);

            // Converter o redutado do calculo acima (int) para string
            // Dessa forma conseguimos o resultado nos labels
            label3.Text = Tkel.ToString();
            label5.Text = Tfah.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
