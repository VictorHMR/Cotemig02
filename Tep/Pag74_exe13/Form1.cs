using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag74_exe13
{
    public partial class Form1 : Form
    {
        int[] vetor;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtTamanho.Text == "0")
                MessageBox.Show("Forneça o tamanho do vetor");
            else
            {
                lstElementos.Items.Clear();

                vetor= new int[int.Parse(txtTamanho.Text)];

                btnPreencher.Enabled = true;
                btnMaior.Enabled = true;
                btnMenor.Enabled = true;
                btnQtZeros.Enabled = true;
                btnMedia.Enabled = true;

                for (int i = 0; i < vetor.Length; i++)
                    lstElementos.Items.Add(vetor[i]);
            }
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            Random elementos = new Random();
            lstElementos.Items.Clear();

            for(int i=0;i < vetor.Length; i++)
            {
                vetor[i] = elementos.Next(0, 100);
                lstElementos.Items.Add(vetor[i]);
            }
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int maior = vetor[0];
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];
            }
            lblResultados.Text = maior.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int menor = vetor[0];
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
            }
            lblResultados.Text = menor.ToString();
        }

        private void btnQtZeros_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] ==0)
                    cont++;
            }
            lblResultados.Text = cont.ToString();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            
            int i, soma=0;
            double media;

            for (i = 0; i < vetor.Length; i++)
            {

                soma += vetor[i];
            }
            media = (double)soma / vetor.Length;
            lblResultados.Text = media.ToString("#,##0.00");
        }
    }
}
