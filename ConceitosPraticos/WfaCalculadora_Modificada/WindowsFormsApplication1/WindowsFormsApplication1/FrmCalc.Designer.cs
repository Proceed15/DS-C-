namespace WfaCalculadora_Melhorada
{
    partial class FrmCalc
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
            this.groupOper = new System.Windows.Forms.GroupBox();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.numlabel2 = new System.Windows.Forms.Label();
            this.numlabel1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.rdbPotenciar = new System.Windows.Forms.RadioButton();
            this.groupOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOper
            // 
            this.groupOper.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupOper.Controls.Add(this.rdbPotenciar);
            this.groupOper.Controls.Add(this.rdbDivisao);
            this.groupOper.Controls.Add(this.rdbMultiplicacao);
            this.groupOper.Controls.Add(this.rdbSubtracao);
            this.groupOper.Controls.Add(this.rdbAdicao);
            this.groupOper.Location = new System.Drawing.Point(19, 104);
            this.groupOper.Name = "groupOper";
            this.groupOper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupOper.Size = new System.Drawing.Size(208, 148);
            this.groupOper.TabIndex = 2;
            this.groupOper.TabStop = false;
            this.groupOper.Text = "Operações";
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(6, 92);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(60, 17);
            this.rdbDivisao.TabIndex = 5;
            this.rdbDivisao.Text = "&Divisão";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            this.rdbDivisao.CheckedChanged += new System.EventHandler(this.rdbDivisao_CheckedChanged);
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(6, 69);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rdbMultiplicacao.TabIndex = 4;
            this.rdbMultiplicacao.Text = "&Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            this.rdbMultiplicacao.CheckedChanged += new System.EventHandler(this.rdbMultiplicacao_CheckedChanged);
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(6, 46);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(74, 17);
            this.rdbSubtracao.TabIndex = 3;
            this.rdbSubtracao.Text = "&Subtração";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            this.rdbSubtracao.CheckedChanged += new System.EventHandler(this.rdbSubtracao_CheckedChanged);
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Checked = true;
            this.rdbAdicao.Location = new System.Drawing.Point(6, 23);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(58, 17);
            this.rdbAdicao.TabIndex = 2;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "&Adição";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            this.rdbAdicao.CheckedChanged += new System.EventHandler(this.rdbAdicao_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(274, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(187, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(274, 163);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(187, 42);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFechar.Location = new System.Drawing.Point(274, 211);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(187, 41);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // numlabel2
            // 
            this.numlabel2.AutoSize = true;
            this.numlabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numlabel2.Location = new System.Drawing.Point(271, 11);
            this.numlabel2.Name = "numlabel2";
            this.numlabel2.Size = new System.Drawing.Size(56, 13);
            this.numlabel2.TabIndex = 4;
            this.numlabel2.Text = "Número 2:";
            // 
            // numlabel1
            // 
            this.numlabel1.AutoSize = true;
            this.numlabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numlabel1.Location = new System.Drawing.Point(24, 11);
            this.numlabel1.Name = "numlabel1";
            this.numlabel1.Size = new System.Drawing.Size(56, 13);
            this.numlabel1.TabIndex = 5;
            this.numlabel1.Text = "Número 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(19, 37);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(178, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(274, 37);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(177, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(224, 33);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(22, 24);
            this.lblOper.TabIndex = 9;
            this.lblOper.Text = "+";
            this.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbPotenciar
            // 
            this.rdbPotenciar.AutoSize = true;
            this.rdbPotenciar.Location = new System.Drawing.Point(6, 115);
            this.rdbPotenciar.Name = "rdbPotenciar";
            this.rdbPotenciar.Size = new System.Drawing.Size(85, 17);
            this.rdbPotenciar.TabIndex = 6;
            this.rdbPotenciar.Text = "&Potenciação";
            this.rdbPotenciar.UseVisualStyleBackColor = true;
            this.rdbPotenciar.CheckedChanged += new System.EventHandler(this.rdbPotenciar_CheckedChanged);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 287);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.numlabel1);
            this.Controls.Add(this.numlabel2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupOper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalc_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupOper.ResumeLayout(false);
            this.groupOper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOper;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label numlabel2;
        private System.Windows.Forms.Label numlabel1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.RadioButton rdbPotenciar;
    }
}

