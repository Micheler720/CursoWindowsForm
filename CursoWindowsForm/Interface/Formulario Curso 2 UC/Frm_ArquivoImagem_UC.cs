using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeImagem)
        {
            InitializeComponent();
            Lbl_TituloArquivoImagem.Text = nomeImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeImagem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ArquivosImagens_UC_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cor_Click(object sender, EventArgs e)
        {
            var Cdb = new ColorDialog();
            if (Cdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_TituloArquivoImagem.ForeColor = Cdb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            var Fdb = new FontDialog();
            if(Fdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_TituloArquivoImagem.Font = Fdb.Font;
            }
        }
    }
}
