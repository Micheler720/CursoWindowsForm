using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class Frm_HelloWord : Form
    {
        public Frm_HelloWord()
        {
            InitializeComponent();
        }

        private void HelloWord_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Altera_Label_Click(object sender, EventArgs e)
        {
            var conteudo = Txt_Informacao_Label.Text;
            if (conteudo != "")
            {
                Lbl_Titulo.Text = conteudo;
                Lbl_Retorno_Alteracao.Text = "";
            }
            else
            {
                Lbl_Retorno_Alteracao.Text = "Não é possivel alterar valor para vazio. Verifique!";
            }
        }

        private void Btn_Abrir_Frm_DemonstracaoKey_Click(object sender, EventArgs e)
        {
           // Application.Run(new Frm_DemonstracaoKey;
        }

        private void Txt_Informacao_Label_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
