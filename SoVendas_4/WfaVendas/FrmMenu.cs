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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmCadClientes)
                {
                    item.Focus();
                    return;
                    //return pra finalizar o método.
                }
            }
            FrmCadClientes frmClientes = new FrmCadClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar?","Atenção:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbCadClientes_Click(object sender, EventArgs e)
        {
            cadastroDeClientesToolStripMenuItem_Click(null,null);
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            sslHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }
    }
}
