using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCalculadora_Melhorada
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                ==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rdbAdicao_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void rdbSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void rdbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "*";
        }

        private void rdbDivisao_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }
        private void rdbPotenciar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "^";
        }

        contas Contas = new contas();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Contas.Num1 = double.Parse(txtNum1.Text);
                Contas.Num2 = double.Parse(txtNum2.Text);

                if (rdbAdicao.Checked)
                {
                    MessageBox.Show(Contas.Somar(), "RESULTADO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbSubtracao.Checked)
                {
                    MessageBox.Show(Contas.Subtrair(), "RESULTADO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbMultiplicacao.Checked)
                {
                    MessageBox.Show(Contas.Multiplicar(), "RESULTADO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbDivisao.Checked)
                {
                    MessageBox.Show(Contas.Dividir(), "Resultado:",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show(Contas.Potenciar(), "Resultado:",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            rdbAdicao.Checked = true;
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();
        }
    }
}