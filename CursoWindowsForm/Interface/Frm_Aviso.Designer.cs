namespace CursoWindowsForm
{
    partial class Frm_Aviso
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
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.Location = new System.Drawing.Point(18, 9);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(199, 18);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você deseja validar a senha?";
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Image = global::CursoWindowsForm.Properties.Resources.Interrogacao;
            this.Pic_Imagem.Location = new System.Drawing.Point(22, 67);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(80, 61);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Imagem.TabIndex = 3;
            this.Pic_Imagem.TabStop = false;
            this.Pic_Imagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(147, 105);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(115, 23);
            this.Btn_Ok.TabIndex = 4;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click_1);
            // 
            // Frm_Aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Lbl_Questao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Aviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            this.Load += new System.EventHandler(this.Frm_Questao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questao;
        private System.Windows.Forms.PictureBox Pic_Imagem;
        private System.Windows.Forms.Button Btn_Ok;
    }
}