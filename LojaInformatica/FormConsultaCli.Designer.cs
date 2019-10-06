namespace LojaInformatica
{
    partial class FormConsultaCli
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
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculinoCon = new System.Windows.Forms.RadioButton();
            this.rbFemininoCon = new System.Windows.Forms.RadioButton();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbinicial = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbCategoria.SuspendLayout();
            this.gbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(21, 31);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(134, 23);
            this.cbCategorias.TabIndex = 0;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.lbPesquisar);
            this.gbCategoria.Controls.Add(this.gbSexo);
            this.gbCategoria.Controls.Add(this.dgvResult);
            this.gbCategoria.Controls.Add(this.gbStatus);
            this.gbCategoria.Controls.Add(this.gbPesquisa);
            this.gbCategoria.Controls.Add(this.txtPesquisar);
            this.gbCategoria.Controls.Add(this.cbCategorias);
            this.gbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(13, 13);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(594, 485);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Selecione uma Categoria:";
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(159, 35);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(70, 17);
            this.lbPesquisar.TabIndex = 1;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculinoCon);
            this.gbSexo.Controls.Add(this.rbFemininoCon);
            this.gbSexo.Location = new System.Drawing.Point(225, 84);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(184, 69);
            this.gbSexo.TabIndex = 4;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbMasculinoCon
            // 
            this.rbMasculinoCon.AutoSize = true;
            this.rbMasculinoCon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculinoCon.Location = new System.Drawing.Point(98, 25);
            this.rbMasculinoCon.Name = "rbMasculinoCon";
            this.rbMasculinoCon.Size = new System.Drawing.Size(80, 19);
            this.rbMasculinoCon.TabIndex = 1;
            this.rbMasculinoCon.TabStop = true;
            this.rbMasculinoCon.Text = "Masculino";
            this.rbMasculinoCon.UseVisualStyleBackColor = true;
            // 
            // rbFemininoCon
            // 
            this.rbFemininoCon.AutoSize = true;
            this.rbFemininoCon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemininoCon.Location = new System.Drawing.Point(7, 25);
            this.rbFemininoCon.Name = "rbFemininoCon";
            this.rbFemininoCon.Size = new System.Drawing.Size(75, 19);
            this.rbFemininoCon.TabIndex = 0;
            this.rbFemininoCon.TabStop = true;
            this.rbFemininoCon.Text = "Feminino";
            this.rbFemininoCon.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.GridColor = System.Drawing.SystemColors.Control;
            this.dgvResult.Location = new System.Drawing.Point(21, 186);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(549, 258);
            this.dgvResult.TabIndex = 6;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(424, 84);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(147, 69);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(73, 24);
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
            this.rbAtivo.Location = new System.Drawing.Point(7, 25);
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
            this.gbPesquisa.Location = new System.Drawing.Point(21, 84);
            this.gbPesquisa.Name = "gbPesquisa";
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
            this.rbContem.Location = new System.Drawing.Point(116, 25);
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
            this.rbinicial.Location = new System.Drawing.Point(6, 25);
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
            this.txtPesquisar.Location = new System.Drawing.Point(232, 31);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(339, 25);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = global::LojaInformatica.Properties.Resources.Prancheta_25;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.Location = new System.Drawing.Point(257, 522);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(95, 29);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(489, 522);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 29);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = global::LojaInformatica.Properties.Resources.Prancheta_21;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.Location = new System.Drawing.Point(372, 522);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 29);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 579);
            this.ControlBox = false;
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPesquisar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.FormConsultaCli_Load);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbinicial;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculinoCon;
        private System.Windows.Forms.RadioButton rbFemininoCon;
        private System.Windows.Forms.Label lbPesquisar;
    }
}