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
    public partial class frmAlterarsenha : Form
    {
        public frmAlterarsenha()
        {
            InitializeComponent();
        }
        Login objSenha = new Login();
        ConexaoBD bd = new ConexaoBD();
        string sql;
        Login objCodigo = new Login();
        DataTable dt = new DataTable();


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if(txtSenha.Text == "")
            {
                MessageBox.Show("Digite uma senha", "Dados do usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSenha.Text == objSenha.SenhaLogado())
                {
                    if (txtCNsenha.Text == txtNsenha.Text)
                    {
                        sql = string.Format("update usuarios set senha= '{0}'where codigo='{1}'", txtNsenha.Text, objCodigo.CodLogado());
                        bd.AlterarDados(sql);
                        MessageBox.Show("Senha alterada com sucesso!! Faça login novamente para continuar", "Dados do usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNsenha.Clear();
                        txtSenha.Clear();
                        txtCNsenha.Clear();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("As novas senhas não conferem", "Dados do usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Senha Incorreta", "Dados do usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarsenha_Load(object sender, EventArgs e)

        {

        }
    }
}
