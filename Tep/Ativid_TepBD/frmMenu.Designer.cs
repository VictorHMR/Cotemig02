namespace Ativid_Tep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ptxAlunos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptxAlunos
            // 
            this.ptxAlunos.Image = ((System.Drawing.Image)(resources.GetObject("ptxAlunos.Image")));
            this.ptxAlunos.Location = new System.Drawing.Point(48, 50);
            this.ptxAlunos.Name = "ptxAlunos";
            this.ptxAlunos.Size = new System.Drawing.Size(206, 193);
            this.ptxAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxAlunos.TabIndex = 0;
            this.ptxAlunos.TabStop = false;
            this.ptxAlunos.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 411);
            this.Controls.Add(this.ptxAlunos);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ptxAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxAlunos;
    }
}