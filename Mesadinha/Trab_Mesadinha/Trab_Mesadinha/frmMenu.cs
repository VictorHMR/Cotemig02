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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }
        ConexaoBD bd = new ConexaoBD();
        Login objLogin = new Login();
        Login objLogado = new Login();
        string nm, sql, nmI, nmII,nmIII, sql2;
        DateTime dataH= DateTime.Now;

        public void Listar()
        {
            sql = string.Format("select contas.nome as Conta, movimentacao.valor as Valor, movimentacao.dt as Data from contas, movimentacao where contas.codigo = movimentacao.contas_codigo and contas.usuarios_codigo = '{0}'", objLogado.CodLogado());
            
            dtgListar.DataSource = bd.ConsultarDados(sql);
            
        }
        public void Atualizar()
        {
            DataTable dtN = new DataTable();
            nmII = string.Format("select movimentacao.valor,contas.tipo as tipo from movimentacao, contas where contas.usuarios_codigo = '{0}'", objLogado.CodLogado());
            dtN = bd.ConsultarDados(nmII);
            
                if (dtN.Rows.Count > 0)
                {

                txtDespesas.Text = "0";
                txtReceitas.Text = "0";
                txtSaldo.Text = "0";
                //Receitas

                DataTable receitas = new DataTable();
                nmI = string.Format("select sum(valor) as Receitas from movimentacao, contas where contas.tipo ='Receitas' and movimentacao.contas_codigo = contas.codigo and contas.usuarios_codigo='{0}'", objLogado.CodLogado());
                receitas = bd.ConsultarDados(nmI);
                txtReceitas.Text = receitas.Rows[0]["Receitas"].ToString();
                        
                //Despesas
                DataTable despesas = new DataTable();
                nmI = string.Format("select sum(valor) as Despesas from movimentacao, contas where contas.tipo ='Despesas' and movimentacao.contas_codigo = contas.codigo and contas.usuarios_codigo='{0}'", objLogado.CodLogado());
                despesas = bd.ConsultarDados(nmI);
                txtDespesas.Text = despesas.Rows[0]["Despesas"].ToString();

                //Saldo
                int receitasT, despesasT;
                int.TryParse(txtReceitas.Text,out receitasT);
                int.TryParse(txtDespesas.Text, out despesasT);
                int totalT = receitasT - despesasT;
                txtSaldo.Text = totalT.ToString();

                }else
                {
                txtDespesas.Text = "0";
                txtReceitas.Text = "0";
                txtSaldo.Text = "0";
                }
            
            
        }
        public void limpar()
        {
            txtVal.Clear();
            cbxConta.SelectedIndex = 0;
            dataH = DateTime.Now;
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Seja bem vindo " + objLogin.UsuarioLogado() + ".";
            DataTable dtT = new DataTable();
            nmIII = string.Format("select * from contas where usuarios_codigo = '{0}'", objLogado.CodLogado());
            dtT = bd.ConsultarDados(nmIII);
            if (dtT.Rows.Count != 0)
            {
                Atualizar();
            }
            else
            {
                MessageBox.Show("Seja bem vindo :3 lembre-se de criar uma categoria e uma conta antes de criar uma movimentação !!", "Bem vindo :3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEditarPerfil usu = new frmEditarPerfil();
            usu.ShowDialog();
            this.Visible = true;
        }

    
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlterarsenha alt = new frmAlterarsenha();
            alt.ShowDialog();
            this.Close();
        }

        private void cadastroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadCat CadCat = new frmCadCat();
            CadCat.ShowDialog();
            this.Visible = true;
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxConta.Text == "")
            {
                MessageBox.Show("Selecione uma Conta", "Lançar Movimentação", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtVal.Text == "")
            {
                MessageBox.Show("Digite o valor da conta !!! ", "Lançar Movimentação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DataTable add = new DataTable();
                nmI = string.Format("insert into movimentacao values(null, '{0}', '{1}', '{2}')", txtVal.Text, dataH.ToString("yyyy-MM-dd"), cbxConta.SelectedValue.ToString());
                bd.AlterarDados(nmI);
                limpar();
                Listar();
                Atualizar();
              

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVal.Text == "")
            {
                MessageBox.Show("Digite o valor da conta que deseja excluir !!! ", "Excluir movimentação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("delete from movimentacao where contas_codigo= '{0}' and valor = '{1}' ", cbxConta.SelectedValue.ToString(), txtVal.Text);
                bd.AlterarDados(sql);
                Atualizar();
                limpar();
                Listar();
            }       
        }

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cbxConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLancamentos_Click(object sender, EventArgs e)
        {
            Listar();
            DataTable dt = new DataTable();
            nm = string.Format("select * from contas where usuarios_codigo = '{0}'", objLogado.CodLogado());
            dt = bd.ConsultarDados(nm);
            cbxConta.DataSource = dt;
            cbxConta.DisplayMember = "nome";
            cbxConta.ValueMember = "codigo";

            btnSalvar.Visible = true;
            btnApagar.Visible = true;
            lblConta.Visible = true;
            lblLM.Visible = true;
            txtVal.Visible = true;
            picLM.Visible = true;
            dtgListar.Visible = true;
            lblValor.Visible = true;
            cbxConta.Visible = true;

        }

        private void cadastroDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadContas CadConta = new frmCadContas();
            CadConta.ShowDialog();
            this.Visible = true;
            btnSalvar.Visible = false;
            btnApagar.Visible = false;
            lblConta.Visible = false;
            lblLM.Visible = false;
            txtVal.Visible = false;
            picLM.Visible = false;
            dtgListar.Visible = false;
            lblValor.Visible = false;
            cbxConta.Visible = false;

        }

       
    }
}
