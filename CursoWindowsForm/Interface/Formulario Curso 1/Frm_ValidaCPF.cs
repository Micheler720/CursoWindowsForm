using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca; 

namespace CursoWindowsForm
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";

        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var cpf = Msk_CPF.Text;
            var validacao = Cls_Uteis.ValidaCPF(cpf);
            if (validacao)
            {
                Lbl_Resultado.Text = "CPF ok!";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF incorreto!";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }

        private void Frm_ValidaCPF_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
