
namespace WfaVendas
{
    partial class FrmCadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codproLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtCodpro = new System.Windows.Forms.TextBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.mskPrecounit = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pc_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_produtoTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_produtoTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codproLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.Location = new System.Drawing.Point(37, 64);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(43, 13);
            codproLabel.TabIndex = 2;
            codproLabel.Text = "Código:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(37, 90);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(37, 116);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 6;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(37, 142);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 8;
            precounitLabel.Text = "Preço Unitario:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvProdutos.DataSource = this.pc_produtoBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(140, 190);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(443, 143);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProdutos_CellFormatting);
            // 
            // txtCodpro
            // 
            this.txtCodpro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "codpro", true));
            this.txtCodpro.Enabled = false;
            this.txtCodpro.Location = new System.Drawing.Point(120, 61);
            this.txtCodpro.Name = "txtCodpro";
            this.txtCodpro.Size = new System.Drawing.Size(100, 20);
            this.txtCodpro.TabIndex = 3;
            // 
            // txtDescri
            // 
            this.txtDescri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "descricao", true));
            this.txtDescri.Enabled = false;
            this.txtDescri.Location = new System.Drawing.Point(120, 87);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(100, 20);
            this.txtDescri.TabIndex = 5;
            // 
            // txtQuant
            // 
            this.txtQuant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "quantidade", true));
            this.txtQuant.Enabled = false;
            this.txtQuant.Location = new System.Drawing.Point(120, 113);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 20);
            this.txtQuant.TabIndex = 7;
            // 
            // mskPrecounit
            // 
            this.mskPrecounit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "precounit", true));
            this.mskPrecounit.Enabled = false;
            this.mskPrecounit.Location = new System.Drawing.Point(120, 139);
            this.mskPrecounit.Name = "mskPrecounit";
            this.mskPrecounit.Size = new System.Drawing.Size(100, 20);
            this.mskPrecounit.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(692, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(584, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(476, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 31;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(368, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(260, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(152, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(44, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 27;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // pc_produtoBindingSource
            // 
            this.pc_produtoBindingSource.DataMember = "pc_produto";
            this.pc_produtoBindingSource.DataSource = this.lP2DataSet;
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = this.pc_produtoTableAdapter;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codpro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precounit";
            dataGridViewCellStyle1.Format = "R$ ###,###,##,0.00";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(codproLabel);
            this.Controls.Add(this.txtCodpro);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(precounitLabel);
            this.Controls.Add(this.mskPrecounit);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmCadProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_produtoBindingSource;
        private LP2DataSetTableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtCodpro;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.MaskedTextBox mskPrecounit;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}