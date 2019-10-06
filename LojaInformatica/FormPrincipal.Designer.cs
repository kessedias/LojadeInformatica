namespace LojaInformatica
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCateg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCadVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultasClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultaCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultaMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsultaCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRelDetalhe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.vsDark = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsDark)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadastros,
            this.tsVendas,
            this.tsConsultas,
            this.tsRelatorios,
            this.tsSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1004, 40);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsCadastros
            // 
            this.tsCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClientes,
            this.tsProdutos,
            this.tsMarcas,
            this.tsCateg,
            this.tsCargos,
            this.funcionáriosToolStripMenuItem});
            this.tsCadastros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCadastros.Image = ((System.Drawing.Image)(resources.GetObject("tsCadastros.Image")));
            this.tsCadastros.Name = "tsCadastros";
            this.tsCadastros.Size = new System.Drawing.Size(112, 36);
            this.tsCadastros.Text = "Cadastros";
            this.tsCadastros.ToolTipText = "Cadastros Variados";
            // 
            // tsClientes
            // 
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsClientes.Size = new System.Drawing.Size(177, 22);
            this.tsClientes.Text = "Clientes";
            this.tsClientes.ToolTipText = "Cadastro de Clientes";
            this.tsClientes.Click += new System.EventHandler(this.tsClientes_Click);
            // 
            // tsProdutos
            // 
            this.tsProdutos.Name = "tsProdutos";
            this.tsProdutos.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsProdutos.Size = new System.Drawing.Size(177, 22);
            this.tsProdutos.Text = "Produtos";
            this.tsProdutos.ToolTipText = "Cadastro de Produtos";
            this.tsProdutos.Click += new System.EventHandler(this.tsProdutos_Click);
            // 
            // tsMarcas
            // 
            this.tsMarcas.Name = "tsMarcas";
            this.tsMarcas.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsMarcas.Size = new System.Drawing.Size(177, 22);
            this.tsMarcas.Text = "Marcas";
            this.tsMarcas.ToolTipText = "Cadastro de Marcas";
            this.tsMarcas.Click += new System.EventHandler(this.tsMarcas_Click);
            // 
            // tsCateg
            // 
            this.tsCateg.Name = "tsCateg";
            this.tsCateg.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsCateg.Size = new System.Drawing.Size(177, 22);
            this.tsCateg.Text = "Categorias";
            this.tsCateg.ToolTipText = "Cadastro de Categorias";
            this.tsCateg.Click += new System.EventHandler(this.tsCateg_Click);
            // 
            // tsCargos
            // 
            this.tsCargos.Name = "tsCargos";
            this.tsCargos.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsCargos.Size = new System.Drawing.Size(177, 22);
            this.tsCargos.Text = "Cargos";
            this.tsCargos.ToolTipText = "Cadastro de Cargos";
            this.tsCargos.Click += new System.EventHandler(this.tsCargos_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.ToolTipText = "Cadastro de Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // tsVendas
            // 
            this.tsVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadVenda});
            this.tsVendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVendas.Image = ((System.Drawing.Image)(resources.GetObject("tsVendas.Image")));
            this.tsVendas.Name = "tsVendas";
            this.tsVendas.Size = new System.Drawing.Size(96, 36);
            this.tsVendas.Text = "Vendas";
            this.tsVendas.ToolTipText = "Execução da Venda";
            // 
            // tsCadVenda
            // 
            this.tsCadVenda.Name = "tsCadVenda";
            this.tsCadVenda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.tsCadVenda.Size = new System.Drawing.Size(180, 22);
            this.tsCadVenda.Text = "Vendas";
            this.tsCadVenda.ToolTipText = "Cadastro de Vendas";
            this.tsCadVenda.Click += new System.EventHandler(this.tsCadVenda_Click);
            // 
            // tsConsultas
            // 
            this.tsConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConsultasClientes,
            this.funcionáriosToolStripMenuItem1,
            this.tsConsultaCargos,
            this.tsConsultaProdutos,
            this.tsConsultaMarcas,
            this.tsConsultaCategorias});
            this.tsConsultas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsConsultas.Image = ((System.Drawing.Image)(resources.GetObject("tsConsultas.Image")));
            this.tsConsultas.Name = "tsConsultas";
            this.tsConsultas.Size = new System.Drawing.Size(112, 36);
            this.tsConsultas.Text = "Consultas";
            this.tsConsultas.ToolTipText = "Consultas Variadas";
            // 
            // tsConsultasClientes
            // 
            this.tsConsultasClientes.Name = "tsConsultasClientes";
            this.tsConsultasClientes.Size = new System.Drawing.Size(155, 22);
            this.tsConsultasClientes.Text = "Clientes";
            this.tsConsultasClientes.ToolTipText = "Consulta de Clientes";
            this.tsConsultasClientes.Click += new System.EventHandler(this.tsConsultasClientes_Click);
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.funcionáriosToolStripMenuItem1.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem1.ToolTipText = "Consulta de Funcionários";
            this.funcionáriosToolStripMenuItem1.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem1_Click);
            // 
            // tsConsultaCargos
            // 
            this.tsConsultaCargos.Name = "tsConsultaCargos";
            this.tsConsultaCargos.Size = new System.Drawing.Size(155, 22);
            this.tsConsultaCargos.Text = "Cargos";
            this.tsConsultaCargos.ToolTipText = "Consulta de Cargos";
            this.tsConsultaCargos.Click += new System.EventHandler(this.tsConsultaCargos_Click);
            // 
            // tsConsultaProdutos
            // 
            this.tsConsultaProdutos.Name = "tsConsultaProdutos";
            this.tsConsultaProdutos.Size = new System.Drawing.Size(155, 22);
            this.tsConsultaProdutos.Text = "Produtos";
            this.tsConsultaProdutos.ToolTipText = "Consulta de Produtos";
            this.tsConsultaProdutos.Click += new System.EventHandler(this.tsConsultaProdutos_Click);
            // 
            // tsConsultaMarcas
            // 
            this.tsConsultaMarcas.Name = "tsConsultaMarcas";
            this.tsConsultaMarcas.Size = new System.Drawing.Size(155, 22);
            this.tsConsultaMarcas.Text = "Marcas";
            this.tsConsultaMarcas.ToolTipText = "Consulta de Marcas";
            this.tsConsultaMarcas.Click += new System.EventHandler(this.tsConsultaMarcas_Click);
            // 
            // tsConsultaCategorias
            // 
            this.tsConsultaCategorias.Name = "tsConsultaCategorias";
            this.tsConsultaCategorias.Size = new System.Drawing.Size(155, 22);
            this.tsConsultaCategorias.Text = "Categorias";
            this.tsConsultaCategorias.ToolTipText = "Consulta de Categorias";
            this.tsConsultaCategorias.Click += new System.EventHandler(this.tsConsultaCategorias_Click);
            // 
            // tsRelatorios
            // 
            this.tsRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRelMarca,
            this.tsRelClientes,
            this.tsRelFunc,
            this.tsRelProd,
            this.tsRelVenda});
            this.tsRelatorios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("tsRelatorios.Image")));
            this.tsRelatorios.Name = "tsRelatorios";
            this.tsRelatorios.Size = new System.Drawing.Size(114, 36);
            this.tsRelatorios.Text = "Relatórios";
            this.tsRelatorios.ToolTipText = "Relatórios de Busca";
            // 
            // tsRelMarca
            // 
            this.tsRelMarca.Name = "tsRelMarca";
            this.tsRelMarca.Size = new System.Drawing.Size(155, 22);
            this.tsRelMarca.Text = "Marcas";
            this.tsRelMarca.ToolTipText = "Relatório de Marcas";
            this.tsRelMarca.Click += new System.EventHandler(this.tsRelMarca_Click);
            // 
            // tsRelClientes
            // 
            this.tsRelClientes.Name = "tsRelClientes";
            this.tsRelClientes.Size = new System.Drawing.Size(155, 22);
            this.tsRelClientes.Text = "Clientes";
            this.tsRelClientes.ToolTipText = "Relatório de Clientes";
            this.tsRelClientes.Click += new System.EventHandler(this.tsRelClientes_Click);
            // 
            // tsRelFunc
            // 
            this.tsRelFunc.Name = "tsRelFunc";
            this.tsRelFunc.Size = new System.Drawing.Size(155, 22);
            this.tsRelFunc.Text = "Funcionários";
            this.tsRelFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsRelFunc.ToolTipText = "Relatório de Funcionários";
            this.tsRelFunc.Click += new System.EventHandler(this.tsRelFunc_Click);
            // 
            // tsRelProd
            // 
            this.tsRelProd.Name = "tsRelProd";
            this.tsRelProd.Size = new System.Drawing.Size(155, 22);
            this.tsRelProd.Text = "Produtos";
            this.tsRelProd.ToolTipText = "Relatório de Produtos";
            this.tsRelProd.Click += new System.EventHandler(this.tsRelProd_Click);
            // 
            // tsRelVenda
            // 
            this.tsRelVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRelSimples,
            this.tsRelDetalhe});
            this.tsRelVenda.Name = "tsRelVenda";
            this.tsRelVenda.Size = new System.Drawing.Size(155, 22);
            this.tsRelVenda.Text = "Vendas";
            this.tsRelVenda.ToolTipText = "Relatório de Vendas";
            // 
            // tsRelSimples
            // 
            this.tsRelSimples.Name = "tsRelSimples";
            this.tsRelSimples.Size = new System.Drawing.Size(140, 22);
            this.tsRelSimples.Text = "Simples";
            this.tsRelSimples.ToolTipText = "Relatório Simples";
            this.tsRelSimples.Click += new System.EventHandler(this.tsRelSimples_Click);
            // 
            // tsRelDetalhe
            // 
            this.tsRelDetalhe.Name = "tsRelDetalhe";
            this.tsRelDetalhe.Size = new System.Drawing.Size(140, 22);
            this.tsRelDetalhe.Text = "Detalhado";
            this.tsRelDetalhe.ToolTipText = "Relatório Detalhado";
            this.tsRelDetalhe.Click += new System.EventHandler(this.tsRelDetalhe_Click);
            // 
            // tsSair
            // 
            this.tsSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSair.Image = ((System.Drawing.Image)(resources.GetObject("tsSair.Image")));
            this.tsSair.Name = "tsSair";
            this.tsSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsSair.Size = new System.Drawing.Size(75, 36);
            this.tsSair.Text = "Sair";
            this.tsSair.ToolTipText = "Sair do Sistema";
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbstatus,
            this.lbData,
            this.lbHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbstatus
            // 
            this.lbstatus.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(139, 17);
            this.lbstatus.Text = "Bem vindo ao Sistema";
            // 
            // lbData
            // 
            this.lbData.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Name = "lbData";
            this.lbData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbData.Size = new System.Drawing.Size(35, 17);
            this.lbData.Text = "Data";
            // 
            // lbHora
            // 
            this.lbHora.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(37, 17);
            this.lbHora.Text = "Hora";
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // vsDark
            // 
            this.vsDark.HostForm = this;
            this.vsDark.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("vsDark.License")));
            this.vsDark.ShadowStyle = SkinSoft.VisualStyler.ShadowStyle.Medium;
            this.vsDark.LoadVisualStyle(null, "Hydrangea Dark (Normal).vssf");
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 692);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsDark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsClientes;
        private System.Windows.Forms.ToolStripMenuItem tsProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsVendas;
        private System.Windows.Forms.ToolStripMenuItem tsCadVenda;
        private System.Windows.Forms.ToolStripMenuItem tsConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbstatus;
        private System.Windows.Forms.ToolStripStatusLabel lbData;
        private System.Windows.Forms.ToolStripStatusLabel lbHora;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsCateg;
        private System.Windows.Forms.ToolStripMenuItem tsCargos;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsConsultasClientes;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsConsultaCargos;
        private System.Windows.Forms.ToolStripMenuItem tsConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsConsultaMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsConsultaCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsRelMarca;
        private System.Windows.Forms.ToolStripMenuItem tsRelClientes;
        private System.Windows.Forms.ToolStripMenuItem tsRelFunc;
        private System.Windows.Forms.ToolStripMenuItem tsRelProd;
        private System.Windows.Forms.ToolStripMenuItem tsRelVenda;
        private System.Windows.Forms.ToolStripMenuItem tsRelSimples;
        private System.Windows.Forms.ToolStripMenuItem tsRelDetalhe;
        private SkinSoft.VisualStyler.VisualStyler vsDark;
    }
}

