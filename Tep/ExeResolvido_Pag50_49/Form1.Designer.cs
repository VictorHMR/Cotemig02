namespace ExeResolvido_Pag50_49
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_UF = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.lbl_Tresid = new System.Windows.Forms.Label();
            this.lbl_cell = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_telresid = new System.Windows.Forms.MaskedTextBox();
            this.txt_telcell = new System.Windows.Forms.MaskedTextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_obrigatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(24, 13);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(31, 13);
            this.lbl_Cpf.TabIndex = 1;
            this.lbl_Cpf.Text = "*CPF";
            this.lbl_Cpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(27, 29);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 2;
            this.txt_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(24, 63);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(85, 13);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "*Nome completo";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(24, 123);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_endereco.TabIndex = 5;
            this.lbl_endereco.Text = "Endereço:";
            this.lbl_endereco.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(27, 89);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(671, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(27, 150);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(671, 20);
            this.txt_endereco.TabIndex = 7;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(24, 188);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_bairro.TabIndex = 8;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(27, 220);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(332, 20);
            this.txt_bairro.TabIndex = 9;
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.Location = new System.Drawing.Point(24, 258);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(24, 13);
            this.lbl_UF.TabIndex = 10;
            this.lbl_UF.Text = "UF:";
            this.lbl_UF.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(27, 365);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(671, 20);
            this.txt_email.TabIndex = 13;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(24, 330);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(39, 13);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "*E-mail";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(388, 220);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(310, 20);
            this.txt_cidade.TabIndex = 15;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(385, 188);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(43, 13);
            this.lbl_cidade.TabIndex = 14;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Location = new System.Drawing.Point(102, 258);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(31, 13);
            this.lbl_Cep.TabIndex = 17;
            this.lbl_Cep.Text = "CEP:";
            // 
            // lbl_Tresid
            // 
            this.lbl_Tresid.AutoSize = true;
            this.lbl_Tresid.Location = new System.Drawing.Point(248, 258);
            this.lbl_Tresid.Name = "lbl_Tresid";
            this.lbl_Tresid.Size = new System.Drawing.Size(107, 13);
            this.lbl_Tresid.TabIndex = 19;
            this.lbl_Tresid.Text = "Telefone Residencial";
            // 
            // lbl_cell
            // 
            this.lbl_cell.AutoSize = true;
            this.lbl_cell.Location = new System.Drawing.Point(474, 258);
            this.lbl_cell.Name = "lbl_cell";
            this.lbl_cell.Size = new System.Drawing.Size(88, 13);
            this.lbl_cell.TabIndex = 21;
            this.lbl_cell.Text = "*Telefone Celular";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(27, 288);
            this.txt_uf.Mask = "AA";
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(21, 20);
            this.txt_uf.TabIndex = 23;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(105, 288);
            this.txt_cep.Mask = "00.000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 24;
            // 
            // txt_telresid
            // 
            this.txt_telresid.Location = new System.Drawing.Point(251, 288);
            this.txt_telresid.Mask = "(99)9999-9999";
            this.txt_telresid.Name = "txt_telresid";
            this.txt_telresid.Size = new System.Drawing.Size(220, 20);
            this.txt_telresid.TabIndex = 25;
            // 
            // txt_telcell
            // 
            this.txt_telcell.Location = new System.Drawing.Point(477, 288);
            this.txt_telcell.Mask = "(99)99999-9999";
            this.txt_telcell.Name = "txt_telcell";
            this.txt_telcell.Size = new System.Drawing.Size(221, 20);
            this.txt_telcell.TabIndex = 26;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(23, 409);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(332, 59);
            this.btn_confirmar.TabIndex = 27;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(365, 409);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(332, 59);
            this.btn_cancelar.TabIndex = 28;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_obrigatorio
            // 
            this.lbl_obrigatorio.AutoSize = true;
            this.lbl_obrigatorio.Location = new System.Drawing.Point(346, 29);
            this.lbl_obrigatorio.Name = "lbl_obrigatorio";
            this.lbl_obrigatorio.Size = new System.Drawing.Size(189, 13);
            this.lbl_obrigatorio.TabIndex = 29;
            this.lbl_obrigatorio.Text = "*Campos de preenchimento obrigatorio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 480);
            this.Controls.Add(this.lbl_obrigatorio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_telcell);
            this.Controls.Add(this.txt_telresid);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.lbl_cell);
            this.Controls.Add(this.lbl_Tresid);
            this.Controls.Add(this.lbl_Cep);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_Cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_UF;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.Label lbl_Tresid;
        private System.Windows.Forms.Label lbl_cell;
        private System.Windows.Forms.MaskedTextBox txt_uf;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_telresid;
        private System.Windows.Forms.MaskedTextBox txt_telcell;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_obrigatorio;
    }
}

