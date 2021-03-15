namespace Trab_Mesadinha
{
    partial class frmCadCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCat));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadCat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Categorias";
            // 
            // txtCadCat
            // 
            this.txtCadCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCat.Location = new System.Drawing.Point(39, 197);
            this.txtCadCat.Name = "txtCadCat";
            this.txtCadCat.Size = new System.Drawing.Size(300, 29);
            this.txtCadCat.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trab_Mesadinha.Properties.Resources.fff8dc;
            this.pictureBox1.Location = new System.Drawing.Point(24, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // dtgListar
            // 
            this.dtgListar.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.Location = new System.Drawing.Point(374, 94);
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.ReadOnly = true;
            this.dtgListar.Size = new System.Drawing.Size(246, 205);
            this.dtgListar.TabIndex = 20;
            this.dtgListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListar_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Trab_Mesadinha.Properties.Resources.IconSalvarP;
            this.btnSalvar.Location = new System.Drawing.Point(36, 235);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 38);
            this.btnSalvar.TabIndex = 68;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.AutoSize = true;
            this.btnApagar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::Trab_Mesadinha.Properties.Resources.IconApagarP;
            this.btnApagar.Location = new System.Drawing.Point(138, 235);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(102, 38);
            this.btnApagar.TabIndex = 69;
            this.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Trab_Mesadinha.Properties.Resources.IconVoltarP;
            this.btnVoltar.Location = new System.Drawing.Point(240, 235);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 38);
            this.btnVoltar.TabIndex = 71;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadCat);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.frmCadCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadCat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgListar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnVoltar;
    }
}