using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab_Mesadinha
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql, saldo;

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite os dados corretamente", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Digite os dados corretamente", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEnd.Text == "")
            {
                MessageBox.Show("Digite os dados corretamente", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Digite os dados corretamente", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Digite os dados corretamente", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text != txtCsenha.Text)
            {
                MessageBox.Show("As senhas não conferem", "Criação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                sql = string.Format("insert into usuarios values(null, '{0}', '{1}', '{2}', '{3}', '{4}')", txtNome.Text, txtEnd.Text, txtTel.Text, txtEmail.Text, txtSenha.Text);
                bd.AlterarDados(sql);
                MessageBox.Show("Usuario cadastrado com sucesso !");
                this.Close();
            }
        }

    
    }
}
