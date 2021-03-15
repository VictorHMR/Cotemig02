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
    public partial class frmCadContas : Form
    {
        public frmCadContas()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        string nm;
        Login objLogado = new Login();

        public void Listar()
        {
            sql = string.Format("Select codigo, nome, tipo from contas where usuarios_codigo = '{0}'" ,objLogado.CodLogado());
            dtgListar.DataSource = bd.ConsultarDados(sql);
        }

        public void limpar()
        {
            txtNome.Clear();
            cbxCat.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;
        }

        private void frmCadContas_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex = 0;
            Listar();
            DataTable dt = new DataTable();
            nm = string.Format("select codigo, nome from categoria where usuarios_codigo = '{0}'", objLogado.CodLogado());
            dt = bd.ConsultarDados(nm);
            cbxCat.DataSource = dt;
            cbxCat.DisplayMember = "nome";
            cbxCat.ValueMember = "codigo";



        }


        private void dtgListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome para a conta !!!!", "Dados da conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(cbxCat.Text == "")
            {
                MessageBox.Show("Crie Uma Categoria !!!!", "Dados da conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("insert into contas values(null,'{0}', '{1}', '{2}', '{3}')", txtNome.Text, cbxTipo.Text, cbxCat.SelectedValue.ToString(), objLogado.CodLogado());
                bd.AlterarDados(sql);
                limpar();
                Listar();
            }
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome da conta que deseja excluir !!!!", "Dados da conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("delete from contas where nome= '{0}'and usuarios_codigo= '{1}'", txtNome.Text, objLogado.CodLogado());
                bd.AlterarDados(sql);
                limpar();
                Listar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
