namespace LojaInformatica
{
    partial class FormRelFunc
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelFunc));
            this.rptvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbBairro = new System.Windows.Forms.GroupBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.gbCargo = new System.Windows.Forms.GroupBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.gbSalario = new System.Windows.Forms.GroupBox();
            this.txtSal2 = new System.Windows.Forms.TextBox();
            this.txtSal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.lbTipoRel = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.classFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbBairro.SuspendLayout();
            this.gbCargo.SuspendLayout();
            this.gbSalario.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvFuncionario
            // 
            reportDataSource2.Name = "dsFuncionario";
            reportDataSource2.Value = this.classFuncionarioBindingSource;
            this.rptvFuncionario.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvFuncionario.LocalReport.ReportEmbeddedResource = "LojaInformatica.rptRelFuncionario.rdlc";
            this.rptvFuncionario.Location = new System.Drawing.Point(38, 187);
            this.rptvFuncionario.Name = "rptvFuncionario";
            this.rptvFuncionario.Size = new System.Drawing.Size(614, 332);
            this.rptvFuncionario.TabIndex = 104;
            // 
            // gbBairro
            // 
            this.gbBairro.Controls.Add(this.cbBairro);
            this.gbBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBairro.Location = new System.Drawing.Point(38, 116);
            this.gbBairro.Name = "gbBairro";
            this.gbBairro.Size = new System.Drawing.Size(186, 54);
            this.gbBairro.TabIndex = 103;
            this.gbBairro.TabStop = false;
            this.gbBairro.Text = "Bairro:";
            // 
            // cbBairro
            // 
            this.cbBairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(6, 21);
            this.cbBairro.Margin = new System.Windows.Forms.Padding(4);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(173, 25);
            this.cbBairro.TabIndex = 66;
            // 
            // gbCargo
            // 
            this.gbCargo.Controls.Add(this.cbCargo);
            this.gbCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargo.Location = new System.Drawing.Point(38, 65);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Size = new System.Drawing.Size(186, 54);
            this.gbCargo.TabIndex = 100;
            this.gbCargo.TabStop = false;
            this.gbCargo.Text = "Cargo:";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(6, 21);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(173, 25);
            this.cbCargo.TabIndex = 76;
            // 
            // gbSalario
            // 
            this.gbSalario.Controls.Add(this.txtSal2);
            this.gbSalario.Controls.Add(this.txtSal1);
            this.gbSalario.Controls.Add(this.label1);
            this.gbSalario.Controls.Add(this.label2);
            this.gbSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalario.Location = new System.Drawing.Point(232, 66);
            this.gbSalario.Name = "gbSalario";
            this.gbSalario.Size = new System.Drawing.Size(107, 106);
            this.gbSalario.TabIndex = 101;
            this.gbSalario.TabStop = false;
            this.gbSalario.Text = "Salário:";
            // 
            // txtSal2
            // 
            this.txtSal2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal2.Location = new System.Drawing.Point(44, 70);
            this.txtSal2.MaxLength = 8;
            this.txtSal2.Name = "txtSal2";
            this.txtSal2.Size = new System.Drawing.Size(44, 23);
            this.txtSal2.TabIndex = 45;
            this.txtSal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal2_KeyPress);
            // 
            // txtSal1
            // 
            this.txtSal1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal1.Location = new System.Drawing.Point(44, 25);
            this.txtSal1.MaxLength = 8;
            this.txtSal1.Name = "txtSal1";
            this.txtSal1.Size = new System.Drawing.Size(44, 23);
            this.txtSal1.TabIndex = 44;
            this.txtSal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal1_KeyPress);
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
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(344, 66);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(100, 106);
            this.gbSexo.TabIndex = 102;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(6, 69);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(82, 21);
            this.rbFeminino.TabIndex = 4;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(7, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(87, 21);
            this.rbMasculino.TabIndex = 3;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(516, 25);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(136, 33);
            this.btGerarRelatorio.TabIndex = 96;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbtInativo);
            this.gbStatus.Controls.Add(this.rbtAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(516, 65);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(136, 106);
            this.gbStatus.TabIndex = 99;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInativo.Location = new System.Drawing.Point(6, 70);
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
            this.rbtAtivo.Location = new System.Drawing.Point(6, 27);
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
            this.cbTipoRel.Location = new System.Drawing.Point(232, 28);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(212, 25);
            this.cbTipoRel.TabIndex = 98;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // lbTipoRel
            // 
            this.lbTipoRel.AutoSize = true;
            this.lbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoRel.Location = new System.Drawing.Point(35, 33);
            this.lbTipoRel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoRel.Name = "lbTipoRel";
            this.lbTipoRel.Size = new System.Drawing.Size(193, 17);
            this.lbTipoRel.TabIndex = 97;
            this.lbTipoRel.Text = "Selecione o Tipo de Relatório:";
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(557, 538);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 29);
            this.btSair.TabIndex = 106;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // classFuncionarioBindingSource
            // 
            this.classFuncionarioBindingSource.DataSource = typeof(LojaInformatica.classFuncionario);
            // 
            // FormRelFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 590);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.rptvFuncionario);
            this.Controls.Add(this.gbBairro);
            this.Controls.Add(this.gbCargo);
            this.Controls.Add(this.gbSalario);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.lbTipoRel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRelFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Funcionários";
            this.Load += new System.EventHandler(this.FormRelFunc_Load);
            this.gbBairro.ResumeLayout(false);
            this.gbCargo.ResumeLayout(false);
            this.gbSalario.ResumeLayout(false);
            this.gbSalario.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvFuncionario;
        private System.Windows.Forms.GroupBox gbBairro;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.GroupBox gbCargo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.GroupBox gbSalario;
        private System.Windows.Forms.TextBox txtSal2;
        private System.Windows.Forms.TextBox txtSal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label lbTipoRel;
        private System.Windows.Forms.BindingSource classFuncionarioBindingSource;
        private System.Windows.Forms.Button btSair;
    }
}