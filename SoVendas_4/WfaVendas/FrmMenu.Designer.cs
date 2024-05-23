
namespace WfaVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.controleDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.toolStripSeparator1,
            this.SairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // controleDeVendasToolStripMenuItem
            // 
            this.controleDeVendasToolStripMenuItem.Name = "controleDeVendasToolStripMenuItem";
            this.controleDeVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.controleDeVendasToolStripMenuItem.Text = "Controle de Vendas";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // sstStatus
            // 
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.sstStatus.Location = new System.Drawing.Point(0, 428);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Size = new System.Drawing.Size(800, 22);
            this.sstStatus.TabIndex = 3;
            this.sstStatus.Text = "statusStrip1";
            // 
            // sslTexto
            // 
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(554, 17);
            this.sslTexto.Spring = true;
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(200, 17);
            this.sslHora.Text = "toolStripStatusLabel2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadClientes,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadClientes
            // 
            this.tsbCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadClientes.Image")));
            this.tsbCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadClientes.Name = "tsbCadClientes";
            this.tsbCadClientes.Size = new System.Drawing.Size(23, 22);
            this.tsbCadClientes.Text = "Cadastro de Clientes";
            this.tsbCadClientes.Click += new System.EventHandler(this.tsbCadClientes_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
    }
}