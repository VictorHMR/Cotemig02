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
    public partial class frmCadCat : Form
    {
        public frmCadCat()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql, sql2;
        DateTime data;
        Login objLogado = new Login();
        public void limpar()
        {
            txtCadCat.Clear();
        }
        public void Listar()
        {
            sql = string.Format("Select codigo, nome from categoria where usuarios_codigo = '{0}'", objLogado.CodLogado());
            dtgListar.DataSource = bd.ConsultarDados(sql);
        }
        private void dtgListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCadCat.Text = dtgListar.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frmCadCat_Load(object sender, EventArgs e)
        {
            Listar();
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCadCat.Text == "")
            {
                MessageBox.Show("Digite um nome para a Categoria !!!!", "Dados da conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sql = string.Format("insert into categoria values(null,'{0}','{1}')", txtCadCat.Text, objLogado.CodLogado());
                bd.AlterarDados(sql);
                limpar();
                Listar();
            }
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            if (txtCadCat.Text == "")
            {
                MessageBox.Show("Digite o nome da categoria que deseja excluir !!!!", "Dados da conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("delete from categoria where nome= '{0}' and usuarios_codigo= '{1}' ", txtCadCat.Text, objLogado.CodLogado());
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
