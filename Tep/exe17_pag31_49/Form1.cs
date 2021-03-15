using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe17_pag31_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtn1.Text),
                nota2 = int.Parse(txtn2.Text),
                nota3 = int.Parse(txtn3.Text),
                media = (nota1 + nota2 + nota3) / 3;


            if (media >= 60 )
            {
                lblsituacao.Text = "Aprovado";
            }
            else if(media >= 45)
            {
                lblsituacao.Text = "Recuperação";
            }
            else
            {
                lblsituacao.Text = "Reprovado";

            }

            

            lblmedia.Text = media.ToString();
        }
    }
}
