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
    public partial class frmEditarPerfil : Form
    {
        public frmEditarPerfil()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        DateTime data;
        Login objCodigo = new Login();
        DataTable dt = new DataTable();
      
        public void Listar()
        {
            sql = string.Format("select * from usuarios where codigo = '{0}'", objCodigo.CodLogado());
            dt = bd.ConsultarDados(sql);
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            
            sql = string.Format("select * from usuarios where codigo = '{0}'", objCodigo.CodLogado());
            dt = bd.ConsultarDados(sql);

            
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                txtEnd.Text = dt.Rows[0]["endereco"].ToString();
                txtTel.Text = dt.Rows[0]["telefone"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
            
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update usuarios set nome= '{0}', endereco= '{1}', telefone='{2}',email='{3}' where codigo='{4}'", txtNome.Text, txtEnd.Text, txtTel.Text, txtEmail.Text, objCodigo.CodLogado());
            bd.AlterarDados(sql);
            MessageBox.Show("Dados alterados com sucesso!!", "Dados do usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
