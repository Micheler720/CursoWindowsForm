using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Frm_ValidaCPF2_UC_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var cpf = Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim();
            if (cpf == "" || cpf.Length != 11)
            {
                new Frm_Aviso(
                        "Mensagem Erro", 
                        "erro", 
                        "O campo de CPF está vazio ou incompleto. Necessário inserir o CPF para prosseguir com validação"
                    ).ShowDialog();
                return;
            }

            var questao = new Frm_Questao("Mensagem","aviso","Confirma validação de CPF?");            
            var confirm = questao.ShowDialog();
            if (confirm == DialogResult.Yes)
            {
                var validacao = Cls_Uteis.ValidaCPF(cpf);
                if (validacao)
                {
                    var Mensagem = new Frm_Aviso("Mensagem Validação","sucesso", "CPF VÁLIDO");
                    Mensagem.ShowDialog();
                }
                else
                {
                    var Mensagem = new Frm_Aviso("Mensagem Validação","erro", "CPF INVÁLIDO");
                    Mensagem.ShowDialog();
                }
            }
        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
