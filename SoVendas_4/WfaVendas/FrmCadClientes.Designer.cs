
namespace WfaVendas
{
    partial class FrmCadClientes
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codcliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_clientesTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_clientesTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskUf = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            codcliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.Location = new System.Drawing.Point(31, 61);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(43, 13);
            codcliLabel.TabIndex = 2;
            codcliLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(31, 87);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(31, 113);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 6;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(31, 139);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 8;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(31, 165);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 10;
            bairroLabel.Text = "Bairro:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(31, 191);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 12;
            ufLabel.Text = "UF:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(31, 217);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "CEP:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(31, 243);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 16;
            telefoneLabel.Text = "Telefone:";
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(31, 270);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(64, 13);
            datanascLabel.TabIndex = 18;
            datanascLabel.Text = "Data Nasc.:";
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = this.pc_clientesTableAdapter;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvClientes.DataSource = this.pc_clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(14, 326);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(938, 255);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCliente_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn6.HeaderText = "UF";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "datanasc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "Data Nasc.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(101, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(51, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(101, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(101, 110);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(101, 136);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(154, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(101, 162);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(154, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // mskUf
            // 
            this.mskUf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskUf.Enabled = false;
            this.mskUf.Location = new System.Drawing.Point(101, 188);
            this.mskUf.Mask = ">LL";
            this.mskUf.Name = "mskUf";
            this.mskUf.RejectInputOnFirstFailure = true;
            this.mskUf.Size = new System.Drawing.Size(51, 20);
            this.mskUf.TabIndex = 13;
            this.mskUf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskUf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskUf_MaskInputRejected);
            // 
            // mskCep
            // 
            this.mskCep.Enabled = false;
            this.mskCep.Location = new System.Drawing.Point(101, 214);
            this.mskCep.Mask = "99999-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.RejectInputOnFirstFailure = true;
            this.mskCep.Size = new System.Drawing.Size(90, 20);
            this.mskCep.TabIndex = 15;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCep_MaskInputRejected);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(101, 240);
            this.mskTelefone.Mask = "(00) 90000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.RejectInputOnFirstFailure = true;
            this.mskTelefone.Size = new System.Drawing.Size(90, 20);
            this.mskTelefone.TabIndex = 17;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefone_MaskInputRejected);
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasc.Enabled = false;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(101, 266);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(103, 20);
            this.dtpDataNasc.TabIndex = 19;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(34, 11);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(116, 11);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(197, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(278, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(359, 11);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(440, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(521, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 593);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(codcliLabel);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.mskUf);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(datanascLabel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Clientes.";
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private LP2DataSetTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskUf;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public System.Windows.Forms.ErrorProvider errorProvider;
    }
}

