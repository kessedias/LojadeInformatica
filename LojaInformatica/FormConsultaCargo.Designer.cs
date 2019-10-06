namespace LojaInformatica
{
    partial class FormConsultaCargo
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
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.gbDataCon = new System.Windows.Forms.GroupBox();
            this.lbEntre = new System.Windows.Forms.Label();
            this.mtxtDataCon2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataCon1 = new System.Windows.Forms.MaskedTextBox();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbinicial = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbCategoria.SuspendLayout();
            this.gbDataCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.lbPesquisar);
            this.gbCategoria.Controls.Add(this.gbDataCon);
            this.gbCategoria.Controls.Add(this.dgvCargo);
            this.gbCategoria.Controls.Add(this.gbStatus);
            this.gbCategoria.Controls.Add(this.gbPesquisa);
            this.gbCategoria.Controls.Add(this.txtPesquisar);
            this.gbCategoria.Controls.Add(this.cbCategorias);
            this.gbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(13, 12);
            this.gbCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoria.Size = new System.Drawing.Size(594, 485);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Selecione uma Categoria:";
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(197, 39);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(70, 17);
            this.lbPesquisar.TabIndex = 1;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // gbDataCon
            // 
            this.gbDataCon.Controls.Add(this.lbEntre);
            this.gbDataCon.Controls.Add(this.mtxtDataCon2);
            this.gbDataCon.Controls.Add(this.mtxtDataCon1);
            this.gbDataCon.Location = new System.Drawing.Point(386, 77);
            this.gbDataCon.Name = "gbDataCon";
            this.gbDataCon.Size = new System.Drawing.Size(200, 69);
            this.gbDataCon.TabIndex = 5;
            this.gbDataCon.TabStop = false;
            this.gbDataCon.Text = "Data entre:";
            // 
            // lbEntre
            // 
            this.lbEntre.AutoSize = true;
            this.lbEntre.Location = new System.Drawing.Point(89, 31);
            this.lbEntre.Name = "lbEntre";
            this.lbEntre.Size = new System.Drawing.Size(15, 17);
            this.lbEntre.TabIndex = 1;
            this.lbEntre.Text = "e";
            // 
            // mtxtDataCon2
            // 
            this.mtxtDataCon2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataCon2.Location = new System.Drawing.Point(109, 28);
            this.mtxtDataCon2.Mask = "00/00/0000";
            this.mtxtDataCon2.Name = "mtxtDataCon2";
            this.mtxtDataCon2.Size = new System.Drawing.Size(72, 23);
            this.mtxtDataCon2.TabIndex = 2;
            this.mtxtDataCon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataCon2.ValidatingType = typeof(System.DateTime);
            this.mtxtDataCon2.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDataCon2_TypeValidationCompleted);
            // 
            // mtxtDataCon1
            // 
            this.mtxtDataCon1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataCon1.Location = new System.Drawing.Point(11, 28);
            this.mtxtDataCon1.Mask = "00/00/0000";
            this.mtxtDataCon1.Name = "mtxtDataCon1";
            this.mtxtDataCon1.Size = new System.Drawing.Size(72, 23);
            this.mtxtDataCon1.TabIndex = 0;
            this.mtxtDataCon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataCon1.ValidatingType = typeof(System.DateTime);
            this.mtxtDataCon1.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDataCon1_TypeValidationCompleted);
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.AllowUserToDeleteRows = false;
            this.dgvCargo.AllowUserToResizeColumns = false;
            this.dgvCargo.AllowUserToResizeRows = false;
            this.dgvCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargo.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCargo.Location = new System.Drawing.Point(37, 169);
            this.dgvCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCargo.MultiSelect = false;
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.ReadOnly = true;
            this.dgvCargo.RowHeadersVisible = false;
            this.dgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargo.Size = new System.Drawing.Size(549, 258);
            this.dgvCargo.TabIndex = 6;
            this.dgvCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargo_CellClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(235, 77);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Size = new System.Drawing.Size(157, 69);
            this.gbStatus.TabIndex = 4;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(82, 28);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(62, 19);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.Location = new System.Drawing.Point(21, 28);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(53, 19);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.rbContem);
            this.gbPesquisa.Controls.Add(this.rbinicial);
            this.gbPesquisa.Location = new System.Drawing.Point(37, 77);
            this.gbPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisa.Size = new System.Drawing.Size(198, 69);
            this.gbPesquisa.TabIndex = 3;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa por Caracteres:";
            // 
            // rbContem
            // 
            this.rbContem.AccessibleDescription = "Tudo que pode conter no campo";
            this.rbContem.AutoSize = true;
            this.rbContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContem.Location = new System.Drawing.Point(121, 28);
            this.rbContem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(69, 19);
            this.rbContem.TabIndex = 1;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Pode ter";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbinicial
            // 
            this.rbinicial.AccessibleDescription = "Procurar uma letra ou palavra inicial";
            this.rbinicial.AutoSize = true;
            this.rbinicial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbinicial.Location = new System.Drawing.Point(7, 28);
            this.rbinicial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbinicial.Name = "rbinicial";
            this.rbinicial.Size = new System.Drawing.Size(104, 19);
            this.rbinicial.TabIndex = 0;
            this.rbinicial.TabStop = true;
            this.rbinicial.Text = "Primeiro nome";
            this.rbinicial.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(269, 35);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(317, 25);
            this.txtPesquisar.TabIndex = 2;
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(37, 36);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(156, 23);
            this.cbCategorias.TabIndex = 0;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = global::LojaInformatica.Properties.Resources.Prancheta_21;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.Location = new System.Drawing.Point(394, 515);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 29);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(504, 515);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 29);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = global::LojaInformatica.Properties.Resources.Prancheta_25;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.Location = new System.Drawing.Point(282, 515);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(95, 29);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // FormConsultaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 579);
            this.ControlBox = false;
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPesquisar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultaCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cargos";
            this.Load += new System.EventHandler(this.FormConsultaCargo_Load);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbDataCon.ResumeLayout(false);
            this.gbDataCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbinicial;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbDataCon;
        private System.Windows.Forms.MaskedTextBox mtxtDataCon1;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Label lbEntre;
        private System.Windows.Forms.MaskedTextBox mtxtDataCon2;
    }
}