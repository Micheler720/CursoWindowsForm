namespace CursoWindowsForm
{
    partial class Frm_HelloWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWord));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Altera_Label = new System.Windows.Forms.Button();
            this.Txt_Informacao_Label = new System.Windows.Forms.TextBox();
            this.Lbl_Retorno_Alteracao = new System.Windows.Forms.Label();
            this.Btn_Abrir_Frm_DemonstracaoKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(193, 19);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Version .Net Atualização";
            this.Lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sair.Location = new System.Drawing.Point(317, 251);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Altera_Label
            // 
            this.Btn_Altera_Label.Location = new System.Drawing.Point(30, 78);
            this.Btn_Altera_Label.Name = "Btn_Altera_Label";
            this.Btn_Altera_Label.Size = new System.Drawing.Size(193, 23);
            this.Btn_Altera_Label.TabIndex = 2;
            this.Btn_Altera_Label.Text = "Altera Label";
            this.Btn_Altera_Label.UseVisualStyleBackColor = true;
            this.Btn_Altera_Label.Click += new System.EventHandler(this.Btn_Altera_Label_Click);
            // 
            // Txt_Informacao_Label
            // 
            this.Txt_Informacao_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Informacao_Label.Location = new System.Drawing.Point(30, 52);
            this.Txt_Informacao_Label.Name = "Txt_Informacao_Label";
            this.Txt_Informacao_Label.Size = new System.Drawing.Size(320, 20);
            this.Txt_Informacao_Label.TabIndex = 3;
            this.Txt_Informacao_Label.TextChanged += new System.EventHandler(this.Txt_Informacao_Label_TextChanged);
            // 
            // Lbl_Retorno_Alteracao
            // 
            this.Lbl_Retorno_Alteracao.AutoSize = true;
            this.Lbl_Retorno_Alteracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Retorno_Alteracao.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Retorno_Alteracao.Location = new System.Drawing.Point(30, 180);
            this.Lbl_Retorno_Alteracao.Name = "Lbl_Retorno_Alteracao";
            this.Lbl_Retorno_Alteracao.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Retorno_Alteracao.TabIndex = 4;
            // 
            // Btn_Abrir_Frm_DemonstracaoKey
            // 
            this.Btn_Abrir_Frm_DemonstracaoKey.Location = new System.Drawing.Point(34, 117);
            this.Btn_Abrir_Frm_DemonstracaoKey.Name = "Btn_Abrir_Frm_DemonstracaoKey";
            this.Btn_Abrir_Frm_DemonstracaoKey.Size = new System.Drawing.Size(180, 23);
            this.Btn_Abrir_Frm_DemonstracaoKey.TabIndex = 5;
            this.Btn_Abrir_Frm_DemonstracaoKey.Text = "Abrir Demonstracao Key";
            this.Btn_Abrir_Frm_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.Btn_Abrir_Frm_DemonstracaoKey.Click += new System.EventHandler(this.Btn_Abrir_Frm_DemonstracaoKey_Click);
            // 
            // Frm_HelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 286);
            this.Controls.Add(this.Btn_Abrir_Frm_DemonstracaoKey);
            this.Controls.Add(this.Lbl_Retorno_Alteracao);
            this.Controls.Add(this.Txt_Informacao_Label);
            this.Controls.Add(this.Btn_Altera_Label);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWord";
            this.Text = "HelloWord";
            this.Load += new System.EventHandler(this.HelloWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Altera_Label;
        private System.Windows.Forms.TextBox Txt_Informacao_Label;
        private System.Windows.Forms.Label Lbl_Retorno_Alteracao;
        private System.Windows.Forms.Button Btn_Abrir_Frm_DemonstracaoKey;
    }
}

