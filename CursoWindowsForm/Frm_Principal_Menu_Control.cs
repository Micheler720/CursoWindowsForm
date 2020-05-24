using CursoWindowsForm.Interface;
using CursoWindowsForm.Interface.Formulario_Curso_2_UC;
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
    public partial class Frm_Principal_Menu_Control : Form
    {
        int controleHelloWorld = 0;
        int controleDemonstracaoKey = 0;
        int controleMascara = 0;
        int controleValidaCPF = 0;
        int controleValidaCPF2 = 0;
        int controleValidaSenha = 0;
        int controleArquivoImagem = 0;
        private bool Logado = false;
        int controleCadastroCliente = 0;
        public Frm_Principal_Menu_Control()
        {
            InitializeComponent();
            var Fl = new Frm_Login();
            Fl.Close();
        }


        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleDemonstracaoKey++;
            var U = new Frm_DemonstracaoKey_UC();
            abrirTabPageFormulario("Demonstracao Key", controleDemonstracaoKey, U, 1);

        }

        private void progToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleHelloWorld++;
            var U = new Frm_HelloWorld_UC();
            abrirTabPageFormulario("Hello World", controleHelloWorld, U, 1);

        }

        private void mascáraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleMascara++;
            var U = new Frm_Mascara_UC();
            abrirTabPageFormulario("Macara", controleMascara, U, 2);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF++;
            var U = new Frm_ValidaCPF_UC();
            abrirTabPageFormulario("Valida CPF", controleValidaCPF, U, 3);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF2++;
            var U = new Frm_ValidaCPF2_UC();
            abrirTabPageFormulario("Valida CPF 2", controleValidaCPF2, U, 4);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaSenha++;
            var U = new Frm_ValidaSenha_UC();
            abrirTabPageFormulario("Valida Senha", controleValidaSenha, U, 5);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {
                ApagarAba(Tbc_Aplicacoes.SelectedTab);

            }
        }
        private void ApagarAba(TabPage TB)
        {

            var nomeTag = TB.Name.ToString();
            if (nomeTag == "Cadastro de Cliente 1")
            {
                controleCadastroCliente--;
            }
            var confirm = MessageBox.Show("Deseja Realmente fechar a aba?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == confirm)
            {
                Tbc_Aplicacoes.TabPages.Remove(TB);
            }
            else
            {
                MessageBox.Show("Operação cancelada pelo usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Função que exibe TabPage Menu
        /// </summary>
        /// <param name="nomeTabPage">Recebe como Parâmetro nome da Tab Página</param>
        /// <param name="valorControle">Valor de Controle de Páginas Abertas</param>
        /// <param name="indexImage"> Indíce da imagem para TabPage</param>
        /// <param name="U"> Página User COntrol para abrir</param>
        private void abrirTabPageFormulario(string nomeTabPage, int valorControle, UserControl U, int indexImage )
        {
            U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = $"{nomeTabPage} {valorControle}";
            TB.Text = $"{nomeTabPage} {valorControle}";
            TB.ImageIndex = indexImage;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void Tbc_Aplicacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DB = new OpenFileDialog();
            DB.Filter = "PNG|*.PNG";
            DB.InitialDirectory = "C:\\Users\\Admin\\source\\repos\\CursoWindowsForm\\CursoWindowsForm\\Imagens";
            DB.Title = "Escolha uma imagem:";
            if (DB.ShowDialog() == DialogResult.OK)
            {
                var nomeImagem = DB.FileName;
                controleArquivoImagem++;
                var U = new Frm_ArquivoImagem_UC(nomeImagem);
                abrirTabPageFormulario("Arquivo Imagem", controleArquivoImagem, U, 6);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new Frm_Login();
            if(F.ShowDialog() == DialogResult.OK)
            {
                Logado = true;
            }
            else
            {
                Logado = false;
            }
            
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;
                //MessageBox.Show($"A posição X: {PosicaoX}, posição Y: {PosicaoY}.", "teste");
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = IncluirItemMenu("Fechar Aba", "DeleteTab");
                var vToolTip002 = IncluirItemMenu("Fechar a esquerda", "DeleteLeft");
                var vToolTip003 = IncluirItemMenu("Fechar a direita", "DeleteRight");
                var vToolTip004 = IncluirItemMenu("Fechar todas menos esta", "DeleteAll");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
                vToolTip003.Click += new EventHandler(vToolTip003_Click);
                vToolTip004.Click += new EventHandler(vToolTip004_Click);
            }
        }
        private void vToolTip001_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {
                ApagarAba(Tbc_Aplicacoes.SelectedTab);                
            }
        }
        private void vToolTip002_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {

                FecharTabEsquerda();
            }
        }
        private void vToolTip003_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {
                FecharTabDireita();
            }
        }
        private void vToolTip004_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {
                FecharTabEsquerda();
                FecharTabDireita();
            }

        }
        private void FecharTabEsquerda()
        {
            var indice = Tbc_Aplicacoes.SelectedIndex;
            for (var i = --indice; i >= 0; i--)
            {
                
                ApagarAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private void FecharTabDireita()
        {
            var indiceTabSelecionada = Tbc_Aplicacoes.TabPages.Count;
            var indice = Tbc_Aplicacoes.SelectedIndex;
            for (var i = --indiceTabSelecionada; i > indice; i--)
            {
                ApagarAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private ToolStripMenuItem IncluirItemMenu(string texto, string nomeImagem, params string[] menuDropDown)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = texto;
            Image MyImage = (Image)global::CursoWindowsForm.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            foreach (string menu in menuDropDown)
            {
                vToolTip.DropDownItems.Add(menu);
            }
            return vToolTip;
        }

        private void Frm_MenuFlutuante_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Lbl_Telefone();
            if (controleCadastroCliente >= 1)
            {
                MessageBox.Show("Não é possível abrir mais de uma aba de cadastro de cliente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controleCadastroCliente++;
                abrirTabPageFormulario("Cadastro de Cliente", controleCadastroCliente, U, 7);                
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

