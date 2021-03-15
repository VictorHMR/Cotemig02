using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeResolvido_Pag50_49
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            if (txt_cpf.Text == "")
                mensagem += "Digite o valor do CPF\n";
            if (txt_nome.Text == "")
                mensagem += "Digite o nome completo";
            if (txt_telcell.Text == "")
                mensagem += "Digite o seu celular";
            if (txt_email.Text == "")
                mensagem += "Digite Seu email";

            lbl_obrigatorio.ForeColor = Color.Red;
            lbl_obrigatorio.Text = mensagem;


            if (txt_cpf.Text.Length != 14)
            {
                MessageBox.Show("CPF Invalido !!\n deve conter 11 caracteres", "Erro!");
                txt_cpf.Focus();
            }
            else if (txt_nome.Text.Length < 5)
            {
                MessageBox.Show("Nome Invalido !!\n deve conter ao menos 5 caracteres", "Erro!");
                txt_nome.Focus();
            }
            else if (txt_uf.Text.Length != 2)
            {
                MessageBox.Show("UF Invalido !!\n deve conter 2 caracteres", "Erro!");
                txt_uf.Focus();
            }
            else if ((!txt_email.Text.Contains("@") || !txt_email.Text.Contains(".")) || txt_email.Text.Length == 0)
            {
                MessageBox.Show("Email invalido!", "Erro!");
                txt_email.Focus();
            }
        }
    }
}
