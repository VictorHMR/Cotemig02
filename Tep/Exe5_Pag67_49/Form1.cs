using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe5_Pag67_49
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            if(int.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Valor Invalido");
            }
            else
            {
                for(int i= int.Parse(textBox1.Text); i > 0; i--)
                {
                    fatorial *= i;
                }
                label2.Text = fatorial.ToString();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
