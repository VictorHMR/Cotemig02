using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_pag52_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total=0, valor1 = int.Parse(txtvalor1.Text), valormes = int.Parse(txtqntmes.Text);
            string codigo = txtcod.Text;

            if (codigo == "RESIDENCIAL")
            {
                total = valor1 * valormes;
                lblsit.Text = "R$" + total.ToString();
            }else if (codigo == "COMERCIAL")
            {
                total = (valor1 * valormes)-(((valor1 * valormes)/100)*5)  ;
                lblsit.Text = "R$" + total.ToString();
            }else if (codigo == "INDUSTRIAL")
                {
                    total = (valor1 * valormes) - (((valor1 * valormes) / 100) * 3);
                    lblsit.Text = "R$"+ total.ToString();
            }
            else { lblsit.Text = "Codigo de Consumidor incorreto"; }

        }
    }
}
