using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe9_pag73_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[100];
            int cont = 0, maior = int.MinValue, menor = int.MaxValue, soma = 0, media = 0 ;
            Random aleatorio = new Random();

            for (cont = 0; cont < 100; cont++)
            {
                num[cont] = aleatorio.Next(100);
                listaResultado.Items.Add(num[cont]);
                soma = soma + num[cont];
                if(num[cont] > maior)
                {
                    maior = num[cont];
                }else if(num[cont] < menor)
                {
                    menor = num[cont];
                }

            }
            media = soma / 100;
            button1.Enabled = false;
            lblmaior.Text = maior.ToString();
            lblmenor.Text = menor.ToString();
            lblmedia.Text = media.ToString();
        }
    }
}
