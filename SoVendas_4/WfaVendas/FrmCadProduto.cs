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
    public partial class FrmCadProduto : Form
    {
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void pc_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet.pc_produto);

        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pc_produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
