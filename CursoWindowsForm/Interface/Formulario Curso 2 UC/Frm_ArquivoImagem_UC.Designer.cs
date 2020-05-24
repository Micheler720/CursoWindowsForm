namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    partial class Frm_ArquivoImagem_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_TituloArquivoImagem = new System.Windows.Forms.Label();
            this.Pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            this.Btn_cor = new System.Windows.Forms.Button();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TituloArquivoImagem
            // 
            this.Lbl_TituloArquivoImagem.AutoSize = true;
            this.Lbl_TituloArquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.Lbl_TituloArquivoImagem.Name = "Lbl_TituloArquivoImagem";
            this.Lbl_TituloArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TituloArquivoImagem.TabIndex = 0;
            this.Lbl_TituloArquivoImagem.Text = "label1";
            this.Lbl_TituloArquivoImagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_ArquivoImagem
            // 
            this.Pic_ArquivoImagem.Location = new System.Drawing.Point(20, 67);
            this.Pic_ArquivoImagem.Name = "Pic_ArquivoImagem";
            this.Pic_ArquivoImagem.Size = new System.Drawing.Size(209, 156);
            this.Pic_ArquivoImagem.TabIndex = 1;
            this.Pic_ArquivoImagem.TabStop = false;
            // 
            // Btn_cor
            // 
            this.Btn_cor.Location = new System.Drawing.Point(20, 10);
            this.Btn_cor.Name = "Btn_cor";
            this.Btn_cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_cor.TabIndex = 2;
            this.Btn_cor.Text = "Cor";
            this.Btn_cor.UseVisualStyleBackColor = true;
            this.Btn_cor.Click += new System.EventHandler(this.Btn_cor_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Location = new System.Drawing.Point(101, 10);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fonte.TabIndex = 3;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Btn_cor);
            this.Controls.Add(this.Pic_ArquivoImagem);
            this.Controls.Add(this.Lbl_TituloArquivoImagem);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(512, 352);
            this.Load += new System.EventHandler(this.Frm_ArquivosImagens_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloArquivoImagem;
        private System.Windows.Forms.PictureBox Pic_ArquivoImagem;
        private System.Windows.Forms.Button Btn_cor;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}
