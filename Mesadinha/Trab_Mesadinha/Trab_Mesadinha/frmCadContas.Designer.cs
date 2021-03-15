namespace Trab_Mesadinha
{
    partial class frmCadContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadContas));
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgListar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListar.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.Location = new System.Drawing.Point(363, 32);
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.ReadOnly = true;
            this.dtgListar.Size = new System.Drawing.Size(285, 330);
            this.dtgListar.TabIndex = 27;
            this.dtgListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListar_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cadastro de Contas";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(41, 135);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 29);
            this.txtNome.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Categoria";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.IntegralHeight = false;
            this.cbxTipo.Items.AddRange(new object[] {
            "Receitas",
            "Despesas"});
            this.cbxTipo.Location = new System.Drawing.Point(41, 190);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(300, 29);
            this.cbxTipo.TabIndex = 33;
            // 
            // cbxCat
            // 
            this.cbxCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(41, 252);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(300, 29);
            this.cbxCat.TabIndex = 35;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Trab_Mesadinha.Properties.Resources.IconVoltarP;
            this.btnVoltar.Location = new System.Drawing.Point(245, 299);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 38);
            this.btnVoltar.TabIndex = 70;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.AutoSize = true;
            this.btnApagar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::Trab_Mesadinha.Properties.Resources.IconApagarP;
            this.btnApagar.Location = new System.Drawing.Point(143, 299);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(102, 38);
            this.btnApagar.TabIndex = 68;
            this.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Trab_Mesadinha.Properties.Resources.IconSalvarP;
            this.btnSalvar.Location = new System.Drawing.Point(41, 299);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 38);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox1.Location = new System.Drawing.Point(26, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas";
            this.Load += new System.EventHandler(this.frmCadContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnVoltar;
    }
}