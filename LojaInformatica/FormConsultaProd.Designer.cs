namespace LojaInformatica
{
    partial class FormConsultaProd
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
            this.cbMarcaProd = new System.Windows.Forms.ComboBox();
            this.cbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.gbPrecoCon = new System.Windows.Forms.GroupBox();
            this.lbAnd = new System.Windows.Forms.Label();
            this.txtPrecoDois = new System.Windows.Forms.TextBox();
            this.txtPrecoUm = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
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
            this.gbPrecoCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.lbPesquisar);
            this.gbCategoria.Controls.Add(this.cbMarcaProd);
            this.gbCategoria.Controls.Add(this.cbCategoriaProd);
            this.gbCategoria.Controls.Add(this.gbPrecoCon);
            this.gbCategoria.Controls.Add(this.dgvProduto);
            this.gbCategoria.Controls.Add(this.gbStatus);
            this.gbCategoria.Controls.Add(this.gbPesquisa);
            this.gbCategoria.Controls.Add(this.txtPesquisar);
            this.gbCategoria.Controls.Add(this.cbCategorias);
            this.gbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(19, 27);
            this.gbCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoria.Size = new System.Drawing.Size(594, 481);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Selecione uma Categoria:";
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(27, 29);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(70, 17);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // cbMarcaProd
            // 
            this.cbMarcaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcaProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaProd.FormattingEnabled = true;
            this.cbMarcaProd.Location = new System.Drawing.Point(402, 70);
            this.cbMarcaProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMarcaProd.Name = "cbMarcaProd";
            this.cbMarcaProd.Size = new System.Drawing.Size(170, 23);
            this.cbMarcaProd.TabIndex = 4;
            // 
            // cbCategoriaProd
            // 
            this.cbCategoriaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaProd.FormattingEnabled = true;
            this.cbCategoriaProd.Location = new System.Drawing.Point(215, 70);
            this.cbCategoriaProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategoriaProd.Name = "cbCategoriaProd";
            this.cbCategoriaProd.Size = new System.Drawing.Size(170, 23);
            this.cbCategoriaProd.TabIndex = 3;
            // 
            // gbPrecoCon
            // 
            this.gbPrecoCon.Controls.Add(this.lbAnd);
            this.gbPrecoCon.Controls.Add(this.txtPrecoDois);
            this.gbPrecoCon.Controls.Add(this.txtPrecoUm);
            this.gbPrecoCon.Location = new System.Drawing.Point(231, 99);
            this.gbPrecoCon.Name = "gbPrecoCon";
            this.gbPrecoCon.Size = new System.Drawing.Size(187, 69);
            this.gbPrecoCon.TabIndex = 6;
            this.gbPrecoCon.TabStop = false;
            this.gbPrecoCon.Text = "Preço Entre:";
            // 
            // lbAnd
            // 
            this.lbAnd.AutoSize = true;
            this.lbAnd.Location = new System.Drawing.Point(87, 31);
            this.lbAnd.Name = "lbAnd";
            this.lbAnd.Size = new System.Drawing.Size(15, 17);
            this.lbAnd.TabIndex = 1;
            this.lbAnd.Text = "e";
            // 
            // txtPrecoDois
            // 
            this.txtPrecoDois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoDois.Location = new System.Drawing.Point(117, 27);
            this.txtPrecoDois.Name = "txtPrecoDois";
            this.txtPrecoDois.Size = new System.Drawing.Size(50, 23);
            this.txtPrecoDois.TabIndex = 2;
            this.txtPrecoDois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoDois_KeyPress);
            // 
            // txtPrecoUm
            // 
            this.txtPrecoUm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUm.Location = new System.Drawing.Point(21, 26);
            this.txtPrecoUm.Name = "txtPrecoUm";
            this.txtPrecoUm.Size = new System.Drawing.Size(50, 23);
            this.txtPrecoUm.TabIndex = 0;
            this.txtPrecoUm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUm_KeyPress);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProduto.Location = new System.Drawing.Point(24, 201);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(549, 249);
            this.dgvProduto.TabIndex = 8;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(425, 99);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStatus.Size = new System.Drawing.Size(147, 69);
            this.gbStatus.TabIndex = 7;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(86, 27);
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
            this.rbAtivo.Location = new System.Drawing.Point(9, 28);
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
            this.gbPesquisa.Location = new System.Drawing.Point(23, 99);
            this.gbPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisa.Size = new System.Drawing.Size(201, 69);
            this.gbPesquisa.TabIndex = 5;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa por Caracteres:";
            // 
            // rbContem
            // 
            this.rbContem.AccessibleDescription = "Tudo que pode conter no campo";
            this.rbContem.AutoSize = true;
            this.rbContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContem.Location = new System.Drawing.Point(120, 29);
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
            this.txtPesquisar.Location = new System.Drawing.Point(101, 24);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(471, 25);
            this.txtPesquisar.TabIndex = 1;
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(24, 70);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(170, 23);
            this.cbCategorias.TabIndex = 2;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = global::LojaInformatica.Properties.Resources.Prancheta_21;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.Location = new System.Drawing.Point(386, 526);
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
            this.btSair.Location = new System.Drawing.Point(496, 526);
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
            this.btPesquisar.Location = new System.Drawing.Point(283, 526);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(95, 29);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // FormConsultaProd
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
            this.Name = "FormConsultaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.FormConsultaProd_Load);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbPrecoCon.ResumeLayout(false);
            this.gbPrecoCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.DataGridView dgvProduto;
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
        private System.Windows.Forms.GroupBox gbPrecoCon;
        private System.Windows.Forms.Label lbAnd;
        private System.Windows.Forms.TextBox txtPrecoDois;
        private System.Windows.Forms.TextBox txtPrecoUm;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.ComboBox cbMarcaProd;
        private System.Windows.Forms.ComboBox cbCategoriaProd;
    }
}