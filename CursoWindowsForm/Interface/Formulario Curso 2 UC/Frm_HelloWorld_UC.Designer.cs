namespace CursoWindowsForm
{
    partial class Frm_HelloWorld_UC
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
            this.Btn_Abrir_Frm_DemonstracaoKey = new System.Windows.Forms.Button();
            this.Txt_Informacao_Label = new System.Windows.Forms.TextBox();
            this.Btn_Altera_Label = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Abrir_Frm_DemonstracaoKey
            // 
            this.Btn_Abrir_Frm_DemonstracaoKey.Location = new System.Drawing.Point(20, 112);
            this.Btn_Abrir_Frm_DemonstracaoKey.Name = "Btn_Abrir_Frm_DemonstracaoKey";
            this.Btn_Abrir_Frm_DemonstracaoKey.Size = new System.Drawing.Size(180, 23);
            this.Btn_Abrir_Frm_DemonstracaoKey.TabIndex = 9;
            this.Btn_Abrir_Frm_DemonstracaoKey.Text = "Abrir Demonstracao Key";
            this.Btn_Abrir_Frm_DemonstracaoKey.UseVisualStyleBackColor = true;
            // 
            // Txt_Informacao_Label
            // 
            this.Txt_Informacao_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Informacao_Label.Location = new System.Drawing.Point(16, 47);
            this.Txt_Informacao_Label.Name = "Txt_Informacao_Label";
            this.Txt_Informacao_Label.Size = new System.Drawing.Size(505, 20);
            this.Txt_Informacao_Label.TabIndex = 8;
            this.Txt_Informacao_Label.TextChanged += new System.EventHandler(this.Txt_Informacao_Label_TextChanged);
            // 
            // Btn_Altera_Label
            // 
            this.Btn_Altera_Label.Location = new System.Drawing.Point(16, 73);
            this.Btn_Altera_Label.Name = "Btn_Altera_Label";
            this.Btn_Altera_Label.Size = new System.Drawing.Size(193, 23);
            this.Btn_Altera_Label.TabIndex = 7;
            this.Btn_Altera_Label.Text = "Altera Label";
            this.Btn_Altera_Label.UseVisualStyleBackColor = true;
            this.Btn_Altera_Label.Click += new System.EventHandler(this.Btn_Altera_Label_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(16, 25);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(193, 19);
            this.Lbl_Titulo.TabIndex = 6;
            this.Lbl_Titulo.Text = "Version .Net Atualização";
            // 
            // Frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Abrir_Frm_DemonstracaoKey);
            this.Controls.Add(this.Txt_Informacao_Label);
            this.Controls.Add(this.Btn_Altera_Label);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(537, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Abrir_Frm_DemonstracaoKey;
        private System.Windows.Forms.TextBox Txt_Informacao_Label;
        private System.Windows.Forms.Button Btn_Altera_Label;
        private System.Windows.Forms.Label Lbl_Titulo;
    }
}
