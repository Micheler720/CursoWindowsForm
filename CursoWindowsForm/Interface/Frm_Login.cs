using Biblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm.Interface
{
    public partial class Frm_Login : Form
    {
        string nomeUsuario;
        string senha;
        public Frm_Login()
        {
            InitializeComponent();
            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Txt_Password.PasswordChar = '*';
            Btn_Ok.Text = "Ok";
            Btn_Cancel.Text = "Cancelar";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            nomeUsuario = Txt_Login.Text;
            senha = Txt_Password.Text;
            var validacao = ControleUsuario.validaSenhaLogin(nomeUsuario, senha);            
            DialogResult = DialogResult.OK;
            if (validacao)
            {

                var mensagem = new Frm_Aviso("Aviso", "sucesso", "Usuário logado com sucesso!");
                mensagem.ShowDialog();
                var F = new Frm_Principal_Menu_Control();               
                F.ShowDialog();
            }
            else
            {
                var mensagem = new Frm_Aviso("Error", "erro", "Usuário ou senha incorretos. \nVerifique!");
                mensagem.ShowDialog();
            }

            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") 
            {
                Btn_Ok.Focus();
            }
        }
    }
}
