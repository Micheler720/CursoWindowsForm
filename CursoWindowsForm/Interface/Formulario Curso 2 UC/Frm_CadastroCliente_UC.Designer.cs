namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    partial class Lbl_Telefone
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lbl_Telefone));
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.Lbl_Telefone1 = new System.Windows.Forms.Label();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.Grp_Codigo = new System.Windows.Forms.GroupBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Grp_Outros = new System.Windows.Forms.GroupBox();
            this.Msk_RendaFamiliar = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LimpartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grp_Codigo.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_Outros.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(6, 19);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(70, 13);
            this.Lbl_NomeCliente.TabIndex = 0;
            this.Lbl_NomeCliente.Text = "Nome Cliente";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(11, 58);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 1;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(11, 74);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(125, 20);
            this.Msk_CPF.TabIndex = 5;
            this.Msk_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_CPF_MaskInputRejected);
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(170, 58);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(59, 13);
            this.Lbl_NomeMae.TabIndex = 6;
            this.Lbl_NomeMae.Text = "Nome Mae";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(9, 35);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(775, 20);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeMae.Location = new System.Drawing.Point(171, 76);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(613, 20);
            this.Txt_NomeMae.TabIndex = 4;
            // 
            // Lbl_RendaFamiliar
            // 
            this.Lbl_RendaFamiliar.AutoSize = true;
            this.Lbl_RendaFamiliar.Location = new System.Drawing.Point(11, 70);
            this.Lbl_RendaFamiliar.Name = "Lbl_RendaFamiliar";
            this.Lbl_RendaFamiliar.Size = new System.Drawing.Size(50, 13);
            this.Lbl_RendaFamiliar.TabIndex = 13;
            this.Lbl_RendaFamiliar.Text = "Profissao";
            // 
            // Lbl_Telefone1
            // 
            this.Lbl_Telefone1.AutoSize = true;
            this.Lbl_Telefone1.Location = new System.Drawing.Point(11, 28);
            this.Lbl_Telefone1.Name = "Lbl_Telefone1";
            this.Lbl_Telefone1.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Telefone1.TabIndex = 15;
            this.Lbl_Telefone1.Text = "Profissao";
            this.Lbl_Telefone1.Click += new System.EventHandler(this.Lbl_Telefone1_Click);
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(14, 44);
            this.Msk_Telefone.Mask = "00 00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(116, 20);
            this.Msk_Telefone.TabIndex = 13;
            this.Msk_Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logradouro.Location = new System.Drawing.Point(11, 81);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(382, 20);
            this.Txt_Logradouro.TabIndex = 10;
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(9, 62);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Logradouro.TabIndex = 19;
            this.Lbl_Logradouro.Text = "Profissao";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Complemento.Location = new System.Drawing.Point(11, 130);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(773, 20);
            this.Txt_Complemento.TabIndex = 12;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(9, 111);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Complemento.TabIndex = 21;
            this.Lbl_Complemento.Text = "Profissao";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Bairro.Location = new System.Drawing.Point(403, 81);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(381, 20);
            this.Txt_Bairro.TabIndex = 11;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(401, 62);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Bairro.TabIndex = 23;
            this.Lbl_Bairro.Text = "Profissao";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(139, 15);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Estado.TabIndex = 25;
            this.Lbl_Estado.Text = "Profissao";
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(8, 16);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(50, 13);
            this.Lbl_CEP.TabIndex = 28;
            this.Lbl_CEP.Text = "Profissao";
            // 
            // Msk_CEP
            // 
            this.Msk_CEP.Location = new System.Drawing.Point(10, 32);
            this.Msk_CEP.Mask = "00000-000";
            this.Msk_CEP.Name = "Msk_CEP";
            this.Msk_CEP.Size = new System.Drawing.Size(126, 20);
            this.Msk_CEP.TabIndex = 7;
            this.Msk_CEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_CEP_KeyUp);
            this.Msk_CEP.Leave += new System.EventHandler(this.Msk_CEP_Leave);
            // 
            // Grp_Codigo
            // 
            this.Grp_Codigo.Controls.Add(this.Txt_Codigo);
            this.Grp_Codigo.Location = new System.Drawing.Point(15, 41);
            this.Grp_Codigo.Name = "Grp_Codigo";
            this.Grp_Codigo.Size = new System.Drawing.Size(212, 50);
            this.Grp_Codigo.TabIndex = 31;
            this.Grp_Codigo.TabStop = false;
            this.Grp_Codigo.Text = "groupBox1";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(6, 19);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(200, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Chk_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(13, 100);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(788, 191);
            this.Grp_DadosPessoais.TabIndex = 32;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "groupBox1";
            this.Grp_DadosPessoais.Enter += new System.EventHandler(this.Grp_DadosPessoais_Enter);
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(171, 140);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(80, 17);
            this.Chk_TemPai.TabIndex = 0;
            this.Chk_TemPai.Text = "checkBox1";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(168, 99);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(68, 13);
            this.Lbl_NomePai.TabIndex = 23;
            this.Lbl_NomePai.Text = "Nome do Pai";
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomePai.Location = new System.Drawing.Point(171, 115);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(613, 20);
            this.Txt_NomePai.TabIndex = 22;
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Indefinido);
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Location = new System.Drawing.Point(6, 99);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(130, 89);
            this.Grp_Genero.TabIndex = 21;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "groupBox1";
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(6, 62);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Indefinido.TabIndex = 2;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton3";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(6, 41);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Masculino.TabIndex = 1;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton2";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(6, 20);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Feminino.TabIndex = 0;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton1";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Msk_CEP);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Location = new System.Drawing.Point(11, 307);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(788, 172);
            this.Grp_Endereco.TabIndex = 33;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "groupBox1";
            this.Grp_Endereco.Enter += new System.EventHandler(this.Grp_Endereco_Enter);
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(142, 31);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(120, 21);
            this.Cmb_Estados.TabIndex = 31;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cidade.Location = new System.Drawing.Point(268, 32);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(516, 20);
            this.Txt_Cidade.TabIndex = 9;
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(266, 16);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Cidade.TabIndex = 30;
            this.Lbl_Cidade.Text = "Profissao";
            // 
            // Grp_Outros
            // 
            this.Grp_Outros.Controls.Add(this.Msk_RendaFamiliar);
            this.Grp_Outros.Controls.Add(this.Lbl_Profissao);
            this.Grp_Outros.Controls.Add(this.Txt_Profissao);
            this.Grp_Outros.Controls.Add(this.Lbl_Telefone1);
            this.Grp_Outros.Controls.Add(this.Msk_Telefone);
            this.Grp_Outros.Controls.Add(this.Lbl_RendaFamiliar);
            this.Grp_Outros.Location = new System.Drawing.Point(11, 485);
            this.Grp_Outros.Name = "Grp_Outros";
            this.Grp_Outros.Size = new System.Drawing.Size(788, 122);
            this.Grp_Outros.TabIndex = 31;
            this.Grp_Outros.TabStop = false;
            this.Grp_Outros.Text = "groupBox1";
            // 
            // Msk_RendaFamiliar
            // 
            this.Msk_RendaFamiliar.Location = new System.Drawing.Point(13, 86);
            this.Msk_RendaFamiliar.Name = "Msk_RendaFamiliar";
            this.Msk_RendaFamiliar.Size = new System.Drawing.Size(145, 20);
            this.Msk_RendaFamiliar.TabIndex = 20;
            this.Msk_RendaFamiliar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(135, 28);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Profissao.TabIndex = 19;
            this.Lbl_Profissao.Text = "Profissao";
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Profissao.Location = new System.Drawing.Point(137, 44);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(641, 20);
            this.Txt_Profissao.TabIndex = 14;
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.ApagatoolStripButton,
            this.LimpartoolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(806, 25);
            this.Tls_Principal.TabIndex = 34;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // ApagatoolStripButton
            // 
            this.ApagatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton.Image = global::CursoWindowsForm.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton.Name = "ApagatoolStripButton";
            this.ApagatoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton.Text = "toolStripButton2";
            this.ApagatoolStripButton.ToolTipText = "Apagar";
            this.ApagatoolStripButton.Click += new System.EventHandler(this.ApagatoolStripButton_Click);
            // 
            // LimpartoolStripButton
            // 
            this.LimpartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimpartoolStripButton.Image = global::CursoWindowsForm.Properties.Resources.LimparBarra;
            this.LimpartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpartoolStripButton.Name = "LimpartoolStripButton";
            this.LimpartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LimpartoolStripButton.Text = "toolStripButton1";
            this.LimpartoolStripButton.Click += new System.EventHandler(this.LimpartoolStripButton_Click);
            // 
            // Lbl_Telefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Grp_Outros);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_Codigo);
            this.Name = "Lbl_Telefone";
            this.Size = new System.Drawing.Size(806, 620);
            this.Load += new System.EventHandler(this.Frm_CadastroCliente_UC_Load);
            this.Grp_Codigo.ResumeLayout(false);
            this.Grp_Codigo.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_Outros.ResumeLayout(false);
            this.Grp_Outros.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.Label Lbl_RendaFamiliar;
        private System.Windows.Forms.Label Lbl_Telefone1;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.MaskedTextBox Msk_CEP;
        private System.Windows.Forms.GroupBox Grp_Codigo;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.GroupBox Grp_Outros;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.ComboBox Cmb_Estados;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton;
        private System.Windows.Forms.ToolStripButton LimpartoolStripButton;
        private System.Windows.Forms.MaskedTextBox Msk_RendaFamiliar;
    }
}
