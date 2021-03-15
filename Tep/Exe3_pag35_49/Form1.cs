using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_pag35_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txt_codigo.Text;
            int valor=0, total=0, qnt= int.Parse(txt_qnt.Text);


            if (txt_codigo.Text == "AUTO")
            {
                valor = 325;
                total = valor * qnt;
                lbl_situação.Text = total.ToString();

            }
            else if (txt_codigo.Text == "MOTO")
            {
                valor = 102;
                total = valor * qnt;
                lbl_situação.Text = total.ToString();
            }
            else if (txt_codigo.Text == "BIKE")
            {
                valor = 76;
                total = valor * qnt;
                lbl_situação.Text = total.ToString();
            }
            else if (txt_codigo.Text == "KLWE")
            {
                valor = 176;
                total = valor * qnt;
                lbl_situação.Text = total.ToString();
            }
            else if (txt_codigo.Text == "WPDD")
            {
                valor = 456;
                total = valor * qnt;
                lbl_situação.Text = total.ToString();
            }
            else
            {
                lbl_situação.Text = "CODIGO INVALIDO !!";
            }
            }
    }
}
