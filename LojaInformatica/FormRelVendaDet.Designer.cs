namespace LojaInformatica
{
    partial class FormRelVendaDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelVendaDet));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classJuncaoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSair = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lbBusca = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lbDe3 = new System.Windows.Forms.Label();
            this.lbAte3 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.gbfuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.txtPreco2 = new System.Windows.Forms.TextBox();
            this.txtPreco1 = new System.Windows.Forms.TextBox();
            this.lbDe2 = new System.Windows.Forms.Label();
            this.lbAte2 = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.lbTipoRel = new System.Windows.Forms.Label();
            this.rptvVendaDeta = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classJuncaoVendaBindingSource)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbPagamento.SuspendLayout();
            this.gbfuncionario.SuspendLayout();
            this.gbPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // classJuncaoVendaBindingSource
            // 
            this.classJuncaoVendaBindingSource.DataSource = typeof(LojaInformatica.classJuncaoVenda);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(642, 544);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 29);
            this.btSair.TabIndex = 120;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lbBusca);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(37, 57);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCliente.Size = new System.Drawing.Size(700, 57);
            this.gbCliente.TabIndex = 119;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Nome do Cliente:";
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusca.Location = new System.Drawing.Point(11, 26);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(46, 17);
            this.lbBusca.TabIndex = 47;
            this.lbBusca.Text = "Busca:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(62, 22);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.MaxLength = 80;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(628, 23);
            this.txtCliente.TabIndex = 46;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lbDe3);
            this.gbData.Controls.Add(this.lbAte3);
            this.gbData.Controls.Add(this.dtp2);
            this.gbData.Controls.Add(this.dtp1);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(37, 178);
            this.gbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbData.Size = new System.Drawing.Size(700, 57);
            this.gbData.TabIndex = 118;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data da Venda:";
            // 
            // lbDe3
            // 
            this.lbDe3.AutoSize = true;
            this.lbDe3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDe3.Location = new System.Drawing.Point(9, 26);
            this.lbDe3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDe3.Name = "lbDe3";
            this.lbDe3.Size = new System.Drawing.Size(27, 17);
            this.lbDe3.TabIndex = 107;
            this.lbDe3.Text = "De:";
            // 
            // lbAte3
            // 
            this.lbAte3.AutoSize = true;
            this.lbAte3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAte3.Location = new System.Drawing.Point(354, 26);
            this.lbAte3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAte3.Name = "lbAte3";
            this.lbAte3.Size = new System.Drawing.Size(32, 17);
            this.lbAte3.TabIndex = 106;
            this.lbAte3.Text = "Até:";
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Location = new System.Drawing.Point(396, 22);
            this.dtp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(294, 23);
            this.dtp2.TabIndex = 105;
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(45, 22);
            this.dtp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(292, 23);
            this.dtp1.TabIndex = 105;
            // 
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.cbPagamento);
            this.gbPagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagamento.Location = new System.Drawing.Point(279, 116);
            this.gbPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPagamento.Size = new System.Drawing.Size(217, 61);
            this.gbPagamento.TabIndex = 116;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Forma de Pagamento:";
            // 
            // cbPagamento
            // 
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Location = new System.Drawing.Point(7, 24);
            this.cbPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(201, 25);
            this.cbPagamento.TabIndex = 66;
            // 
            // gbfuncionario
            // 
            this.gbfuncionario.Controls.Add(this.cbFuncionario);
            this.gbfuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfuncionario.Location = new System.Drawing.Point(37, 116);
            this.gbfuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbfuncionario.Name = "gbfuncionario";
            this.gbfuncionario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbfuncionario.Size = new System.Drawing.Size(217, 61);
            this.gbfuncionario.TabIndex = 114;
            this.gbfuncionario.TabStop = false;
            this.gbfuncionario.Text = "Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(7, 23);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(5);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(201, 25);
            this.cbFuncionario.TabIndex = 76;
            // 
            // gbPreco
            // 
            this.gbPreco.Controls.Add(this.txtPreco2);
            this.gbPreco.Controls.Add(this.txtPreco1);
            this.gbPreco.Controls.Add(this.lbDe2);
            this.gbPreco.Controls.Add(this.lbAte2);
            this.gbPreco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(519, 116);
            this.gbPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPreco.Size = new System.Drawing.Size(218, 61);
            this.gbPreco.TabIndex = 115;
            this.gbPreco.TabStop = false;
            this.gbPreco.Text = "Total da Venda:";
            // 
            // txtPreco2
            // 
            this.txtPreco2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2.Location = new System.Drawing.Point(152, 24);
            this.txtPreco2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco2.MaxLength = 8;
            this.txtPreco2.Name = "txtPreco2";
            this.txtPreco2.Size = new System.Drawing.Size(51, 23);
            this.txtPreco2.TabIndex = 45;
            this.txtPreco2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco2_KeyPress);
            // 
            // txtPreco1
            // 
            this.txtPreco1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1.Location = new System.Drawing.Point(41, 24);
            this.txtPreco1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco1.MaxLength = 8;
            this.txtPreco1.Name = "txtPreco1";
            this.txtPreco1.Size = new System.Drawing.Size(51, 23);
            this.txtPreco1.TabIndex = 44;
            this.txtPreco1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco1_KeyPress);
            // 
            // lbDe2
            // 
            this.lbDe2.AutoSize = true;
            this.lbDe2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDe2.Location = new System.Drawing.Point(10, 27);
            this.lbDe2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDe2.Name = "lbDe2";
            this.lbDe2.Size = new System.Drawing.Size(27, 17);
            this.lbDe2.TabIndex = 43;
            this.lbDe2.Text = "De:";
            // 
            // lbAte2
            // 
            this.lbAte2.AutoSize = true;
            this.lbAte2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAte2.Location = new System.Drawing.Point(116, 27);
            this.lbAte2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAte2.Name = "lbAte2";
            this.lbAte2.Size = new System.Drawing.Size(32, 17);
            this.lbAte2.TabIndex = 28;
            this.lbAte2.Text = "Até:";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(603, 21);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(134, 30);
            this.btGerarRelatorio.TabIndex = 111;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(232, 26);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(5);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(313, 25);
            this.cbTipoRel.TabIndex = 113;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // lbTipoRel
            // 
            this.lbTipoRel.AutoSize = true;
            this.lbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoRel.Location = new System.Drawing.Point(34, 31);
            this.lbTipoRel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTipoRel.Name = "lbTipoRel";
            this.lbTipoRel.Size = new System.Drawing.Size(193, 17);
            this.lbTipoRel.TabIndex = 112;
            this.lbTipoRel.Text = "Selecione o Tipo de Relatório:";
            // 
            // rptvVendaDeta
            // 
            reportDataSource1.Name = "dsJuncaoVendaDet";
            reportDataSource1.Value = this.classJuncaoVendaBindingSource;
            this.rptvVendaDeta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvVendaDeta.LocalReport.ReportEmbeddedResource = "LojaInformatica.rptRelVendaDeta.rdlc";
            this.rptvVendaDeta.Location = new System.Drawing.Point(37, 242);
            this.rptvVendaDeta.Name = "rptvVendaDeta";
            this.rptvVendaDeta.Size = new System.Drawing.Size(700, 296);
            this.rptvVendaDeta.TabIndex = 121;
            // 
            // FormRelVendaDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 595);
            this.ControlBox = false;
            this.Controls.Add(this.rptvVendaDeta);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbPagamento);
            this.Controls.Add(this.gbfuncionario);
            this.Controls.Add(this.gbPreco);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.lbTipoRel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRelVendaDet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas Detalhado";
            this.Load += new System.EventHandler(this.FormRelVendaDet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classJuncaoVendaBindingSource)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbPagamento.ResumeLayout(false);
            this.gbfuncionario.ResumeLayout(false);
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lbDe3;
        private System.Windows.Forms.Label lbAte3;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.GroupBox gbfuncionario;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.TextBox txtPreco2;
        private System.Windows.Forms.TextBox txtPreco1;
        private System.Windows.Forms.Label lbDe2;
        private System.Windows.Forms.Label lbAte2;
        private System.Windows.Forms.Button btGerarRelatorio;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label lbTipoRel;
        private System.Windows.Forms.BindingSource classJuncaoVendaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptvVendaDeta;
    }
}