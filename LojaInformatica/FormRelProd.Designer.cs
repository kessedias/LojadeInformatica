namespace LojaInformatica
{
    partial class FormRelProd
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelProd));
            this.rptvProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbQtEstoque = new System.Windows.Forms.GroupBox();
            this.txtEstoque2 = new System.Windows.Forms.TextBox();
            this.txtEstoque1 = new System.Windows.Forms.TextBox();
            this.lbDe = new System.Windows.Forms.Label();
            this.lbAte = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.lbTipoRel = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.txtPreco2 = new System.Windows.Forms.TextBox();
            this.txtPreco1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbMarca.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbQtEstoque.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvProduto
            // 
            reportDataSource1.Name = "dsProdutos";
            reportDataSource1.Value = this.classProdutoBindingSource;
            this.rptvProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvProduto.LocalReport.ReportEmbeddedResource = "LojaInformatica.rptRelProduto.rdlc";
            this.rptvProduto.Location = new System.Drawing.Point(40, 187);
            this.rptvProduto.Name = "rptvProduto";
            this.rptvProduto.Size = new System.Drawing.Size(614, 333);
            this.rptvProduto.TabIndex = 95;
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.cbMarca);
            this.gbMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.Location = new System.Drawing.Point(40, 116);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(186, 54);
            this.gbMarca.TabIndex = 94;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(6, 21);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(173, 25);
            this.cbMarca.TabIndex = 66;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(40, 65);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(186, 54);
            this.gbCategoria.TabIndex = 91;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(6, 21);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(173, 25);
            this.cbCategoria.TabIndex = 76;
            // 
            // gbQtEstoque
            // 
            this.gbQtEstoque.Controls.Add(this.txtEstoque2);
            this.gbQtEstoque.Controls.Add(this.txtEstoque1);
            this.gbQtEstoque.Controls.Add(this.lbDe);
            this.gbQtEstoque.Controls.Add(this.lbAte);
            this.gbQtEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQtEstoque.Location = new System.Drawing.Point(346, 66);
            this.gbQtEstoque.Name = "gbQtEstoque";
            this.gbQtEstoque.Size = new System.Drawing.Size(100, 106);
            this.gbQtEstoque.TabIndex = 92;
            this.gbQtEstoque.TabStop = false;
            this.gbQtEstoque.Text = "Qt. Estoque:";
            // 
            // txtEstoque2
            // 
            this.txtEstoque2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque2.Location = new System.Drawing.Point(44, 70);
            this.txtEstoque2.MaxLength = 3;
            this.txtEstoque2.Name = "txtEstoque2";
            this.txtEstoque2.Size = new System.Drawing.Size(44, 23);
            this.txtEstoque2.TabIndex = 45;
            // 
            // txtEstoque1
            // 
            this.txtEstoque1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque1.Location = new System.Drawing.Point(44, 25);
            this.txtEstoque1.MaxLength = 3;
            this.txtEstoque1.Name = "txtEstoque1";
            this.txtEstoque1.Size = new System.Drawing.Size(44, 23);
            this.txtEstoque1.TabIndex = 44;
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDe.Location = new System.Drawing.Point(9, 29);
            this.lbDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(27, 17);
            this.lbDe.TabIndex = 43;
            this.lbDe.Text = "De:";
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAte.Location = new System.Drawing.Point(9, 73);
            this.lbAte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(32, 17);
            this.lbAte.TabIndex = 28;
            this.lbAte.Text = "Até:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbtInativo);
            this.gbStatus.Controls.Add(this.rbtAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(518, 65);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(136, 106);
            this.gbStatus.TabIndex = 90;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInativo.Location = new System.Drawing.Point(5, 72);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(68, 21);
            this.rbtInativo.TabIndex = 2;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAtivo.Location = new System.Drawing.Point(5, 27);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(58, 21);
            this.rbtAtivo.TabIndex = 1;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(234, 28);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(212, 25);
            this.cbTipoRel.TabIndex = 89;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // lbTipoRel
            // 
            this.lbTipoRel.AutoSize = true;
            this.lbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoRel.Location = new System.Drawing.Point(37, 33);
            this.lbTipoRel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoRel.Name = "lbTipoRel";
            this.lbTipoRel.Size = new System.Drawing.Size(193, 17);
            this.lbTipoRel.TabIndex = 88;
            this.lbTipoRel.Text = "Selecione o Tipo de Relatório:";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(518, 25);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(136, 33);
            this.btGerarRelatorio.TabIndex = 87;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbPreco
            // 
            this.gbPreco.Controls.Add(this.txtPreco2);
            this.gbPreco.Controls.Add(this.txtPreco1);
            this.gbPreco.Controls.Add(this.label1);
            this.gbPreco.Controls.Add(this.label2);
            this.gbPreco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(234, 66);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(107, 106);
            this.gbPreco.TabIndex = 92;
            this.gbPreco.TabStop = false;
            this.gbPreco.Text = "Preço:";
            // 
            // txtPreco2
            // 
            this.txtPreco2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2.Location = new System.Drawing.Point(44, 70);
            this.txtPreco2.MaxLength = 8;
            this.txtPreco2.Name = "txtPreco2";
            this.txtPreco2.Size = new System.Drawing.Size(44, 23);
            this.txtPreco2.TabIndex = 45;
            this.txtPreco2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco2_KeyPress);
            // 
            // txtPreco1
            // 
            this.txtPreco1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1.Location = new System.Drawing.Point(44, 25);
            this.txtPreco1.MaxLength = 8;
            this.txtPreco1.Name = "txtPreco1";
            this.txtPreco1.Size = new System.Drawing.Size(44, 23);
            this.txtPreco1.TabIndex = 44;
            this.txtPreco1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Até:";
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(559, 543);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 29);
            this.btSair.TabIndex = 97;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // classProdutoBindingSource
            // 
            this.classProdutoBindingSource.DataSource = typeof(LojaInformatica.classProduto);
            // 
            // FormRelProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.rptvProduto);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbPreco);
            this.Controls.Add(this.gbQtEstoque);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.lbTipoRel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRelProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.FormRelProd_Load);
            this.gbMarca.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbQtEstoque.ResumeLayout(false);
            this.gbQtEstoque.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvProduto;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gbQtEstoque;
        private System.Windows.Forms.TextBox txtEstoque2;
        private System.Windows.Forms.TextBox txtEstoque1;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.Label lbAte;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label lbTipoRel;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.TextBox txtPreco2;
        private System.Windows.Forms.TextBox txtPreco1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
        private System.Windows.Forms.Button btSair;
    }
}