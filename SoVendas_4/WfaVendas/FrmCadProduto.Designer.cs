
namespace WfaVendas
{
    partial class FrmCadProduto
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
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_produtoTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_produtoTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.pc_produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.precounitTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            codproLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.Location = new System.Drawing.Point(148, 75);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(43, 13);
            codproLabel.TabIndex = 2;
            codproLabel.Text = "Código:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(148, 101);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(148, 127);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 6;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(148, 153);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 8;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_produtoBindingSource
            // 
            this.pc_produtoBindingSource.DataMember = "pc_produto";
            this.pc_produtoBindingSource.DataSource = this.lP2DataSet;
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
            // pc_produtoDataGridView
            // 
            this.pc_produtoDataGridView.AllowUserToAddRows = false;
            this.pc_produtoDataGridView.AllowUserToDeleteRows = false;
            this.pc_produtoDataGridView.AutoGenerateColumns = false;
            this.pc_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pc_produtoDataGridView.DataSource = this.pc_produtoBindingSource;
            this.pc_produtoDataGridView.Location = new System.Drawing.Point(12, 204);
            this.pc_produtoDataGridView.Name = "pc_produtoDataGridView";
            this.pc_produtoDataGridView.ReadOnly = true;
            this.pc_produtoDataGridView.Size = new System.Drawing.Size(562, 234);
            this.pc_produtoDataGridView.TabIndex = 1;
            this.pc_produtoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_produtoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codpro";
            this.dataGridViewTextBoxColumn1.HeaderText = "codpro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precounit";
            dataGridViewCellStyle1.Format = "R$ ###,###,##0.00";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // codproTextBox
            // 
            this.codproTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "codpro", true));
            this.codproTextBox.Location = new System.Drawing.Point(231, 72);
            this.codproTextBox.Name = "codproTextBox";
            this.codproTextBox.Size = new System.Drawing.Size(100, 20);
            this.codproTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(231, 98);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(231, 124);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 7;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            // 
            // precounitTextBox
            // 
            this.precounitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "precounit", true));
            this.precounitTextBox.Location = new System.Drawing.Point(231, 150);
            this.precounitTextBox.Name = "precounitTextBox";
            this.precounitTextBox.Size = new System.Drawing.Size(100, 20);
            this.precounitTextBox.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(499, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(418, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(337, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 31;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(256, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(175, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(94, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 27;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(codproLabel);
            this.Controls.Add(this.codproTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(precounitLabel);
            this.Controls.Add(this.precounitTextBox);
            this.Controls.Add(this.pc_produtoDataGridView);
            this.Name = "FrmCadProduto";
            this.Text = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_produtoBindingSource;
        private LP2DataSetTableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pc_produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox codproTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox precounitTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
    }
}