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
using System.ComponentModel.DataAnnotations;
using Biblioteca.Modelo;
using Biblioteca.Controle;
using Microsoft.VisualBasic;


namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    public partial class Lbl_Telefone : UserControl
    {
        public Lbl_Telefone()
        {
            InitializeComponent();
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone1.Text = "Telefone";
            Grp_Codigo.Text = "Código";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Chk_TemPai.Text = "Pai Desconhecido";
            Lbl_Cidade.Text = "Cidade";
            Grp_Genero.Text = "Genero";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Indefinido.Text = "Indefinido";
            Msk_RendaFamiliar.Text = "0.00";
            Cmb_Estados.Items.Clear();
            var estados = Cls_Uteis.EstadosBrasileiros();
            foreach (var item in estados)
            {
                Cmb_Estados.Items.Add(item.SiglaEstado);
            }
            
            Tls_Principal.Items[0].ToolTipText = "Icluir na Base um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na Base";
            Tls_Principal.Items[2].ToolTipText = "Atualizar Informações";
            Tls_Principal.Items[3].ToolTipText = "Apagar Cliente Selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpar informações em formulário";
            ApagatoolStripButton.Enabled = false;
            DesabilitarHabilitarComponentes(false);
        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Frm_CadastroCliente_UC_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Msk_Estado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Lbl_Telefone1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NomePai_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
            
        }

        private void Grp_DadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            LimpartoolStripButton.Enabled = true;
            salvarToolStripButton.Enabled = true;
            abrirToolStripButton.Enabled = false;
            DesabilitarHabilitarComponentes(true);
        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {
            salvarToolStripButton.Enabled = false;
            abrirToolStripButton.Enabled = true;
            novoToolStripButton.Enabled = true;
            DesabilitarHabilitarComponentes(false);
            LimparFormulario();
        }

        private void DesabilitarHabilitarComponentes(bool valor)
        {
            Txt_Bairro.Enabled = valor;
            Txt_Cidade.Enabled = valor;
            Txt_Complemento.Enabled = valor;
            Txt_Logradouro.Enabled = valor;
            Txt_NomeCliente.Enabled = valor;
            Txt_NomeMae.Enabled = valor;
            Txt_NomePai.Enabled = valor;
            Txt_Profissao.Enabled = valor;
            Msk_RendaFamiliar.Enabled = valor;
            Msk_CEP.Enabled = valor;
            Msk_CPF.Enabled = valor;
            Msk_Telefone.Enabled = valor;
            Rdb_Feminino.Enabled = valor;
            Rdb_Indefinido.Enabled = valor;
            Rdb_Masculino.Enabled = valor;
            Chk_TemPai.Enabled = valor;
            Txt_Codigo.Enabled = true;
            Cmb_Estados.SelectedIndex = 0;
            Cmb_Estados.Enabled = valor;
            LimpartoolStripButton.Enabled = valor;
            salvarToolStripButton.Enabled = valor;
        }
        private void LimparFormulario()
        {
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Txt_Complemento.Text = "";
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Msk_RendaFamiliar.Text = "";
            Msk_CEP.Text = "";
            Msk_CPF.Text = "";
            Msk_Telefone.Text = "";
            Rdb_Feminino.Checked = false;
            Rdb_Indefinido.Checked = false;
            Rdb_Masculino.Checked = false;
            Chk_TemPai.Checked = false;
            Txt_Codigo.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Txt_Codigo.Text = "";
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            ApagatoolStripButton.Enabled = true;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var C = LeituraFormulario();               
                var controleCliente = new ClienteControle();
                controleCliente.ValidaCliente(C);
                MessageBox.Show("Classe instanciada com sucesso. Dados Gravados!","ByteBank - Cad. Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimparFormulario();
                salvarToolStripButton.Enabled = false;
                abrirToolStripButton.Enabled = true;
                novoToolStripButton.Enabled = true;
                DesabilitarHabilitarComponentes(false);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            var Mensagem = new Frm_Aviso("Aviso", "sucesso", "Dados excluídos com sucesso!");
            Mensagem.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Grp_Endereco_Enter(object sender, EventArgs e)
        {

        }
        private ClienteModelo.Unit LeituraFormulario()
        {
            var NomeCliente = Txt_NomeCliente.Text;
            var n = 0;
            int Id;
            if (int.TryParse(Txt_Codigo.Text, out n))
            {
                Id = int.Parse(Txt_Codigo.Text) < 0 ? 0 : int.Parse(Txt_Codigo.Text);
            }
            else
            {
                Id = 0;
            }
            var CPF = Msk_CPF.Text;
            var C = new ClienteModelo.Unit(Id,NomeCliente,CPF);
            C.Logradouro = Txt_Logradouro.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Estado = Cmb_Estados.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Cep = Msk_CEP.Text;
            C.NomePai = Txt_NomePai.Text;
            C.Profissao = Txt_Profissao.Text;
            MessageBox.Show(Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString());
            if (Information.IsNumeric(Msk_RendaFamiliar.Text))
            {
                var RendaFamiliar = Convert.ToDouble(Msk_RendaFamiliar.Text);
                C.RendaFamiliar = RendaFamiliar < 0 ? 0 : RendaFamiliar;
            }
            else
            {
                C.RendaFamiliar = 0;
            }
            C.Telefone = Msk_Telefone.Text;
            C.NaoTemPai = Chk_TemPai.Checked;
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }            
            C.ValidaClasse();
            return C;
        }

      

        private void Msk_CEP_KeyUp(object sender, KeyEventArgs e)
        {
            var cepFormulario = Msk_CEP.Text;
            if (cepFormulario.Length == 9)
            {
                ValidaCep(cepFormulario);

            }
            else
            {
                Txt_Bairro.Text = "";
                Txt_Cidade.Text = "";
                Txt_Complemento.Text = "";
                Txt_Logradouro.Text = "";
                Cmb_Estados.SelectedIndex = -1;
            }

        }
        private void ValidaCep(string cepFormulario)
        {
            cepFormulario = cepFormulario.Replace("-", "");
            string vJson = Cls_Uteis.GeraJSONCEP(cepFormulario);
            var Cep = new CepModelo.Unit();
            Cep = CepModelo.DesSerializedClassUnit(vJson);
            Txt_Bairro.Text = Cep.bairro;
            Txt_Cidade.Text = Cep.localidade;
            Txt_Complemento.Text = Cep.complemento;
            Txt_Logradouro.Text = Cep.logradouro;
            Cmb_Estados.SelectedItem = Cep.uf;
        }

        private void Msk_CEP_Leave(object sender, EventArgs e)
        {
            var cepFormulario = Msk_CEP.Text;
            if (cepFormulario.Length == 9)
            {
                ValidaCep(cepFormulario);

            }
            else
            {
                Txt_Bairro.Text = "";
                Txt_Cidade.Text = "";
                Txt_Complemento.Text = "";
                Txt_Logradouro.Text = "";
                Cmb_Estados.SelectedIndex = -1;
            }
        }
    }
}
