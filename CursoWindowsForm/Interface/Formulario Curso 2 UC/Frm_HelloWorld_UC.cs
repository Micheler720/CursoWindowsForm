using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class Frm_HelloWorld_UC : UserControl
    {
        public Frm_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void HelloWord_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Altera_Label_Click(object sender, EventArgs e)
        {
            var conteudo = Txt_Informacao_Label.Text;
            if (conteudo == "")
            {
                MessageBox.Show("Não é possível alterar o título para vazio. Verifique!", "Caixa de Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Lbl_Titulo.Text = conteudo;
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
