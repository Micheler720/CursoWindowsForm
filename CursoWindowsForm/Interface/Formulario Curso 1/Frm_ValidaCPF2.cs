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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var cpf = Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim();
            if (cpf == "" || cpf.Length != 11)
            {
                MessageBox.Show(
                    "O campo de CPF está vazio ou incompleto. Necessário inserir o CPF para prosseguir com validação",
                    "Mensagem Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            var confirm = MessageBox.Show(
                    "Deseja validar o CPF?",
                    "Messagem de Validação",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                    );
            if (confirm == DialogResult.Yes)
            {                
                var validacao = Cls_Uteis.ValidaCPF(cpf);
                if (validacao)
                {
                    MessageBox.Show("CPF VÁLIDO", 
                        "Mensagem de validação", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("CPF INVÁLIDO", 
                        "Mensagem de validação", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_ValidaCPF2_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
