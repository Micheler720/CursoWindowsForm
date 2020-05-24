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
    public partial class Frm_Aviso : Form
    {
        private string Mensagem { get; set; }
        /// <summary>
        /// Criação de caixa de mensagem
        /// </summary>
        /// <param name="nomeImagem">Nome da imagem que irá aparecer com ícone. Opções:
        /// valor: aviso . Interrogação
        /// valor: erro . X vermelho
        /// valor: interrogacao . Interrogação
        /// </param>
        /// <param name="mensagem">
        /// Texto a ser exibido para o usuário
        /// </param>
        /// <param name="tituloMessagem">
        /// Valor que será inserido no ´título da tela.
        /// </param>
        public Frm_Aviso(string tituloMessagem = "Mensagem", string nomeImagem = "aviso", string mensagem = "Você deseja continuar?")
        {
            InitializeComponent();
            Mensagem = mensagem;
            Lbl_Questao.Text = mensagem;
            Image MyImage = (Image)global::CursoWindowsForm.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Icon MyIcon = (Icon)global::CursoWindowsForm.Properties.Resources.ResourceManager.GetObject($"{nomeImagem}I");
            Pic_Imagem.Image = MyImage;
            this.Icon = MyIcon;
            this.Text = tituloMessagem;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Questao_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
