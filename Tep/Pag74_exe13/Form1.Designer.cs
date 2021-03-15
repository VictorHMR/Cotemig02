namespace Pag74_exe13
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
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.btnQtZeros = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(23, 20);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(171, 13);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade de elementos do Vetor";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(26, 53);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(139, 20);
            this.txtTamanho.TabIndex = 1;
            this.txtTamanho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaior);
            this.panel1.Controls.Add(this.btnMedia);
            this.panel1.Controls.Add(this.btnMenor);
            this.panel1.Controls.Add(this.btnQtZeros);
            this.panel1.Controls.Add(this.btnPreencher);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Location = new System.Drawing.Point(26, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 186);
            this.panel1.TabIndex = 2;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(3, 12);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(133, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar vetor";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Enabled = false;
            this.btnPreencher.Location = new System.Drawing.Point(3, 41);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(133, 23);
            this.btnPreencher.TabIndex = 1;
            this.btnPreencher.Text = "Preencher o vetor";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnQtZeros
            // 
            this.btnQtZeros.Enabled = false;
            this.btnQtZeros.Location = new System.Drawing.Point(3, 128);
            this.btnQtZeros.Name = "btnQtZeros";
            this.btnQtZeros.Size = new System.Drawing.Size(133, 23);
            this.btnQtZeros.TabIndex = 3;
            this.btnQtZeros.Text = "Quantidade de zeros";
            this.btnQtZeros.UseVisualStyleBackColor = true;
            this.btnQtZeros.Click += new System.EventHandler(this.btnQtZeros_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Enabled = false;
            this.btnMenor.Location = new System.Drawing.Point(3, 99);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(133, 23);
            this.btnMenor.TabIndex = 4;
            this.btnMenor.Text = "Menor Valor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Enabled = false;
            this.btnMedia.Location = new System.Drawing.Point(3, 157);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(133, 23);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(171, 53);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(144, 238);
            this.lstElementos.TabIndex = 3;
            this.lstElementos.SelectedIndexChanged += new System.EventHandler(this.lstElementos_SelectedIndexChanged);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(148, 315);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(60, 13);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "Resultados";
            // 
            // btnMaior
            // 
            this.btnMaior.Enabled = false;
            this.btnMaior.Location = new System.Drawing.Point(3, 70);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(133, 23);
            this.btnMaior.TabIndex = 6;
            this.btnMaior.Text = "Maior valor";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 370);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblQuantidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnQtZeros;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnMaior;
    }
}

