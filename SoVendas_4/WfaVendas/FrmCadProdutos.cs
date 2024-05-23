using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmCadProdutos : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadProdutos()
        {
            InitializeComponent();
        }

        private void pc_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            //TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet.pc_produto);

        }



        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProdutos.Columns[e.ColumnIndex].DataPropertyName == "Telefone" ||
               this.dgvProdutos.Columns[e.ColumnIndex].DataPropertyName == "Telefone2")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvProdutos.Columns[e.ColumnIndex].DataPropertyName == "CEP")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-"
                            + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txtCodpro.Focus();
        }
        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;

        }
        private void habilitaCampos(bool hab)
        {
            txtCodpro.Enabled = hab;
            txtDescri.Enabled = hab;
            txtQuant.Enabled = hab;
            mskPrecounit.Enabled = hab;
            
        }
        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                else if ((item is MaskedTextBox))
                {
                    ((MaskedTextBox)item).Clear();
                }
                else if ((item is DateTimePicker))
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodpro.Enabled = false;
                txtCodpro.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
                txtDescri.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
                txtQuant.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
                mskPrecounit.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
               
            }

            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_produtoTableAdapter.Insert(//Convert.ToInt32(txtCodcli.Text),
                    txtQuant.Text, Int32.Parse(txtDescri.Text), Int32.Parse(mskPrecounit.Text));

                    MessageBox.Show("Incluido com Sucesso!", "incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                  /*int v = pc_produtoTableAdapter.Update(txtDescri.Text, Int32.Parse(txtQuant.Text), Int32.Parse(mskPrecounit.Text), Int32.Parse(txtCodpro.Text));
                    MessageBox.Show("Alterado com Sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
                Produtos_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_produtoTableAdapter.Delete(Convert.ToInt32(
                            dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString()));
                        Produtos_Load(null, null);
                        MessageBox.Show(null, "Apagado com Sucesso!", "Excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione em Cliente Primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Occoreu um erro:\n" + ex.Message, "Erro:",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescri.Enabled == false)
            {
                txtDescri.Enabled = true;
                txtDescri.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou" + "\nparte dele.", "Pesquisa ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pc_produtoTableAdapter.FillByDescricao(lP2DataSet.pc_produto, "%" +
                    txtDescri.Text + "%");
                btnCancelar_Click(null, null);
            }
        }
    }
}
