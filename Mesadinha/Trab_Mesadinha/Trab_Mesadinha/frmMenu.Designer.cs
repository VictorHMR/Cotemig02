namespace Trab_Mesadinha
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUsuario = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLancamentos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtReceitas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLM = new System.Windows.Forms.Label();
            this.cbxConta = new System.Windows.Forms.ComboBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.MaskedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.picLM = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerenciar = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastroDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuario,
            this.toolStripSeparator1,
            this.btnGerenciar,
            this.toolStripSeparator2,
            this.btnLancamentos,
            this.toolStripSeparator3,
            this.sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(723, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUsuario
            // 
            this.btnUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.alterarSenhaToolStripMenuItem});
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(81, 25);
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(180, 26);
            this.btnPerfil.Text = "Editar Perfil";
            this.btnPerfil.Click += new System.EventHandler(this.usuario_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btnLancamentos
            // 
            this.btnLancamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLancamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLancamentos.Name = "btnLancamentos";
            this.btnLancamentos.Size = new System.Drawing.Size(113, 25);
            this.btnLancamentos.Text = "Lançamentos";
            this.btnLancamentos.Click += new System.EventHandler(this.btnLancamentos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // txtReceitas
            // 
            this.txtReceitas.Enabled = false;
            this.txtReceitas.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceitas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReceitas.Location = new System.Drawing.Point(23, 127);
            this.txtReceitas.Name = "txtReceitas";
            this.txtReceitas.Size = new System.Drawing.Size(200, 39);
            this.txtReceitas.TabIndex = 3;
            this.txtReceitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Despesas";
            // 
            // txtDespesas
            // 
            this.txtDespesas.Enabled = false;
            this.txtDespesas.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDespesas.Location = new System.Drawing.Point(261, 127);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(200, 39);
            this.txtDespesas.TabIndex = 6;
            this.txtDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(495, 127);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(200, 39);
            this.txtSaldo.TabIndex = 9;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Receitas";
            // 
            // lblLM
            // 
            this.lblLM.AutoSize = true;
            this.lblLM.BackColor = System.Drawing.Color.Cornsilk;
            this.lblLM.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLM.Location = new System.Drawing.Point(38, 206);
            this.lblLM.Name = "lblLM";
            this.lblLM.Size = new System.Drawing.Size(257, 31);
            this.lblLM.TabIndex = 13;
            this.lblLM.Text = "Lançar Movimentação";
            this.lblLM.Visible = false;
            // 
            // cbxConta
            // 
            this.cbxConta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConta.FormattingEnabled = true;
            this.cbxConta.Location = new System.Drawing.Point(44, 286);
            this.cbxConta.Name = "cbxConta";
            this.cbxConta.Size = new System.Drawing.Size(266, 29);
            this.cbxConta.TabIndex = 16;
            this.cbxConta.Visible = false;
            this.cbxConta.SelectedIndexChanged += new System.EventHandler(this.cbxConta_SelectedIndexChanged);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.BackColor = System.Drawing.Color.Cornsilk;
            this.lblConta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(44, 252);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(46, 19);
            this.lblConta.TabIndex = 17;
            this.lblConta.Text = "Conta";
            this.lblConta.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Cornsilk;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(41, 330);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 19);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            this.lblValor.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 61;
            this.label3.Text = "Saldo";
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.Location = new System.Drawing.Point(44, 360);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(265, 29);
            this.txtVal.TabIndex = 62;
            this.txtVal.Visible = false;
            this.txtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVal_KeyPress);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(29, 504);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 15);
            this.lblUser.TabIndex = 63;
            // 
            // dtgListar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgListar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListar.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.Location = new System.Drawing.Point(353, 198);
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.ReadOnly = true;
            this.dtgListar.Size = new System.Drawing.Size(342, 343);
            this.dtgListar.TabIndex = 67;
            this.dtgListar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Trab_Mesadinha.Properties.Resources.iconSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(44, 407);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 51);
            this.btnSalvar.TabIndex = 66;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.AutoSize = true;
            this.btnApagar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::Trab_Mesadinha.Properties.Resources.iconApagar;
            this.btnApagar.Location = new System.Drawing.Point(179, 407);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(131, 51);
            this.btnApagar.TabIndex = 64;
            this.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Visible = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // picLM
            // 
            this.picLM.BackColor = System.Drawing.Color.LemonChiffon;
            this.picLM.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.picLM.Location = new System.Drawing.Point(23, 198);
            this.picLM.Name = "picLM";
            this.picLM.Size = new System.Drawing.Size(303, 343);
            this.picLM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLM.TabIndex = 11;
            this.picLM.TabStop = false;
            this.picLM.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox3.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox3.Location = new System.Drawing.Point(495, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox2.Location = new System.Drawing.Point(261, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox1.Location = new System.Drawing.Point(23, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCategoriasToolStripMenuItem,
            this.cadastroDeContasToolStripMenuItem});
            this.btnGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.Image")));
            this.btnGerenciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(176, 25);
            this.btnGerenciar.Text = "Gerenciar Cadastros";
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // cadastroDeCategoriasToolStripMenuItem
            // 
            this.cadastroDeCategoriasToolStripMenuItem.Name = "cadastroDeCategoriasToolStripMenuItem";
            this.cadastroDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.cadastroDeCategoriasToolStripMenuItem.Text = "Cadastro de Categorias";
            this.cadastroDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriasToolStripMenuItem_Click);
            // 
            // cadastroDeContasToolStripMenuItem
            // 
            this.cadastroDeContasToolStripMenuItem.Name = "cadastroDeContasToolStripMenuItem";
            this.cadastroDeContasToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.cadastroDeContasToolStripMenuItem.Text = "Cadastro de Contas";
            this.cadastroDeContasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeContasToolStripMenuItem_Click);
            // 
            // sair
            // 
            this.sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(43, 25);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(723, 562);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.cbxConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLM);
            this.Controls.Add(this.picLM);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtReceitas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripButton sair;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtReceitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripDropDownButton btnGerenciar;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeContasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLM;
        private System.Windows.Forms.Label lblLM;
        private System.Windows.Forms.ComboBox cbxConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnLancamentos;
        private System.Windows.Forms.MaskedTextBox txtVal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgListar;
    }
}