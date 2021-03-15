namespace Trab_Mesadinha
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(66, 277);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(272, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Senha";
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSize = true;
            this.btnRegistro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Image = global::Trab_Mesadinha.Properties.Resources.IconRegistro;
            this.btnRegistro.Location = new System.Drawing.Point(209, 314);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(129, 51);
            this.btnRegistro.TabIndex = 14;
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Image = global::Trab_Mesadinha.Properties.Resources.IconLogin;
            this.btnEntrar.Location = new System.Drawing.Point(66, 314);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(131, 51);
            this.btnEntrar.TabIndex = 13;
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.Logo_com_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(146, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(406, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}