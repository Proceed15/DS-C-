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
    public partial class FrmCadClientes : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadClientes()
        {
            InitializeComponent();
        }
        //public Boolean Validar
        //{
        //    set;
        //    get;
        //}
        //public static Boolean ValidarCamposUFCEPTelefone(Control Objeto, ErrorProvider ErrorProvider)
        //{
        //    Boolean TemErros = false;

        //    foreach (Control Item in Objeto.Controls)
        //    {
        //        if (Item is FrmCadClientes)
        //        {
        //            FrmCadClientes Obj = (FrmCadClientes)Item;

        //            if (Obj.Validar == true)
        //            {
        //                if (string.IsNullOrEmpty(Obj.Text.Trim()))
        //                {
        //                    ErrorProvider.SetError(Obj, "Não pode estar vazio");
        //                    TemErros = true;
        //                }
        //            }
        //            else
        //            {
        //                ErrorProvider.SetError(Obj, "");
        //            }
        //        }
        //    }
        //    return TemErros;
        //}

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //if (ValidarCamposUFCEPTelefone(this, errorProvider) == false)
            //{
                habilitaBotoes(false);
                habilitaCampos(true);
                limpaCampos();
                incluir = true;
                txtCodigo.Focus();
            //}
            //else
            //{
            //   incluir = false;
            //}
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
            txtCodigo.Enabled = false;
            txtNome.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mskUf.Enabled = hab;
            mskCep.Enabled = hab;
            mskTelefone.Enabled = hab;
            dtpDataNasc.Enabled = hab;
            //foreach (Control item in this.Controls)
            //{
            //    if ((item is TextBox))
            //    {
            //        item.Enabled = hab;
            //    }
            //    if (item is MaskedTextBox)
            //    {
            //        item.Enabled = hab;
            //    }
            //    if (item is DateTimePicker)
            //    {
            //        item.Enabled = hab;
            //    }
            //}
            ////Método novo.
        }

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    //((TextBox)item).Clear();
                    ((TextBox)item).Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    //((MaskedTextBox)item).Clear();
                    ((MaskedTextBox)item).Text = "";
                }
                else if (item is DateTimePicker)
                {
                    //((DateTimePicker)item).Value = DateTime.Now;
                    ((DateTimePicker)item).Value=DateTime.Now;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);

                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskUf.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCep.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();                
                mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?",
                    "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    //System.Windows.Forms.DialogResult.Yes 
                    //Método antigo, não precisa do System.Windows.Forms pq já foi declarado antes.
                    {
                        pc_clientesTableAdapter.Delete(Convert.ToInt32(
                        dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmCadClientes_Load(null, null);
                        MessageBox.Show("Cliente excluído com sucesso!", "Excluir:",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro ao excluir:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou" +
                "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else
            {
                pc_clientesTableAdapter.FillByNome(this.lP2DataSet.pc_clientes,
                    "%" + txtNome.Text + "%");
                btnCancelar_Click(null, null);
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_clientesTableAdapter.Insert(//Convert.ToInt32(txtCodigo.Text),
                    txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                    mskUf.Text, mskCep.Text, mskTelefone.Text, dtpDataNasc.Value);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Incluir:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_clientesTableAdapter.Update(txtNome.Text, txtEndereco.Text,
                    txtCidade.Text, txtBairro.Text, mskUf.Text, mskCep.Text,
                    mskTelefone.Text, dtpDataNasc.Value, Int32.Parse(txtCodigo.Text));
                    MessageBox.Show("Cliente alterado com sucesso!", "Alterar:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Convert.ToInt32(txtCodigo.Text)
                    //Método antigo.
                }
                FrmCadClientes_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        //stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                        //    + "-" + stringValue.Substring(7, 4);
                        //e.Value = stringValue;
                        //Método antigo.
                        e.Value = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);                       
                    }

                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "CEP")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        //stringValue = stringValue.Substring(0, 5) + "-"
                        //    + stringValue.Substring(5, 3);
                        //e.Value = stringValue;
                        //Método antigo.
                        e.Value = stringValue.Substring(0, 5) + "-"
                            + stringValue.Substring(5, 3);
                    }
                }
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //AlterColumn("dvgCliente", "", c => c.String(maxLength: 60));
            //AlterColumn("dvgCliente", "Genre", c => c.String(nullable: false, maxLength: 30));
            //AlterColumn("dvgCliente", "Rating", c => c.String(maxLength: 5));

            //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            //public DateTime EnrollmentDate { get; set; }

            //errorProvider.Clear();
        }

        private void mskUf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //errorProvider.Clear();
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //errorProvider.Clear();
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            //errorProvider.Clear();
        }
    }
}