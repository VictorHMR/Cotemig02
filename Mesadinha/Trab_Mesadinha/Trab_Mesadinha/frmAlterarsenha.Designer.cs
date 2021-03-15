namespace Trab_Mesadinha
{
    partial class frmAlterarsenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarsenha));
            this.txtNsenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNsenha
            // 
            this.txtNsenha.Location = new System.Drawing.Point(276, 183);
            this.txtNsenha.Name = "txtNsenha";
            this.txtNsenha.PasswordChar = '*';
            this.txtNsenha.Size = new System.Drawing.Size(254, 20);
            this.txtNsenha.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "Confirmar Nova Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(276, 105);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(254, 20);
            this.txtSenha.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Senha";
            // 
            // txtCNsenha
            // 
            this.txtCNsenha.Location = new System.Drawing.Point(276, 259);
            this.txtCNsenha.Name = "txtCNsenha";
            this.txtCNsenha.PasswordChar = '*';
            this.txtCNsenha.Size = new System.Drawing.Size(254, 20);
            this.txtCNsenha.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nova Senha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Trab_Mesadinha.Properties.Resources.iconSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(268, 297);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 51);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Trab_Mesadinha.Properties.Resources.iconVoltar;
            this.btnVoltar.Location = new System.Drawing.Point(399, 297);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 51);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox1.Location = new System.Drawing.Point(250, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlterarsenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCNsenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNsenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlterarsenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.frmAlterarsenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNsenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}