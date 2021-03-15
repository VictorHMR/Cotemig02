namespace Trab_Mesadinha
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCsenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(62, 166);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(243, 20);
            this.txtEnd.TabIndex = 18;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(343, 166);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(243, 20);
            this.txtSenha.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(343, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-mail";
            // 
            // txtCsenha
            // 
            this.txtCsenha.Location = new System.Drawing.Point(343, 241);
            this.txtCsenha.Name = "txtCsenha";
            this.txtCsenha.PasswordChar = '*';
            this.txtCsenha.Size = new System.Drawing.Size(243, 20);
            this.txtCsenha.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(62, 241);
            this.txtTel.Mask = "(00) 99000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(243, 20);
            this.txtTel.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Endereço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Trab_Mesadinha.Properties.Resources.iconSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(198, 302);
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
            this.btnVoltar.Location = new System.Drawing.Point(329, 302);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 51);
            this.btnVoltar.TabIndex = 69;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox1.Location = new System.Drawing.Point(34, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCsenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCsenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}