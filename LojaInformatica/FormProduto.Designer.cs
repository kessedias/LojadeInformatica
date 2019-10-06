namespace LojaInformatica
{
    partial class FormProduto
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
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.btAtualizarProd = new System.Windows.Forms.Button();
            this.btFecharProd = new System.Windows.Forms.Button();
            this.btCadastrarProd = new System.Windows.Forms.Button();
            this.lbDataCadProdRes = new System.Windows.Forms.Label();
            this.ckbStatusAtivo = new System.Windows.Forms.CheckBox();
            this.lbDataCadProd = new System.Windows.Forms.Label();
            this.lbStatusProd = new System.Windows.Forms.Label();
            this.lbCodigoProd = new System.Windows.Forms.Label();
            this.gbDadosProd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.cbMarcaProd = new System.Windows.Forms.ComboBox();
            this.cbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.txtCustoProd = new System.Windows.Forms.TextBox();
            this.txtLucroProd = new System.Windows.Forms.TextBox();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.txtQtEstoque = new System.Windows.Forms.TextBox();
            this.lbPrecoProd = new System.Windows.Forms.Label();
            this.lbMarcaProd = new System.Windows.Forms.Label();
            this.lbCategoriaProd = new System.Windows.Forms.Label();
            this.lbLucroProd = new System.Windows.Forms.Label();
            this.lbDescricaoProd = new System.Windows.Forms.Label();
            this.lbCustoProd = new System.Windows.Forms.Label();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.lbQtEstoque = new System.Windows.Forms.Label();
            this.lbCamposObrig = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gbDadosProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodProd
            // 
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Location = new System.Drawing.Point(106, 38);
            this.txtCodProd.MaxLength = 4;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(34, 23);
            this.txtCodProd.TabIndex = 1;
            // 
            // btAtualizarProd
            // 
            this.btAtualizarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarProd.Image = global::LojaInformatica.Properties.Resources.Prancheta_19;
            this.btAtualizarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarProd.Location = new System.Drawing.Point(187, 386);
            this.btAtualizarProd.Name = "btAtualizarProd";
            this.btAtualizarProd.Size = new System.Drawing.Size(80, 25);
            this.btAtualizarProd.TabIndex = 9;
            this.btAtualizarProd.Text = "Atualizar";
            this.btAtualizarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarProd.UseVisualStyleBackColor = true;
            this.btAtualizarProd.Click += new System.EventHandler(this.btAtualizarProd_Click);
            // 
            // btFecharProd
            // 
            this.btFecharProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharProd.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btFecharProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFecharProd.Location = new System.Drawing.Point(376, 386);
            this.btFecharProd.Name = "btFecharProd";
            this.btFecharProd.Size = new System.Drawing.Size(80, 25);
            this.btFecharProd.TabIndex = 11;
            this.btFecharProd.Text = "Fechar";
            this.btFecharProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFecharProd.UseVisualStyleBackColor = true;
            this.btFecharProd.Click += new System.EventHandler(this.btFecharProd_Click);
            // 
            // btCadastrarProd
            // 
            this.btCadastrarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarProd.Image = global::LojaInformatica.Properties.Resources.Prancheta_14;
            this.btCadastrarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrarProd.Location = new System.Drawing.Point(94, 386);
            this.btCadastrarProd.Name = "btCadastrarProd";
            this.btCadastrarProd.Size = new System.Drawing.Size(80, 25);
            this.btCadastrarProd.TabIndex = 8;
            this.btCadastrarProd.Text = "Cadastrar";
            this.btCadastrarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarProd.UseVisualStyleBackColor = true;
            this.btCadastrarProd.Click += new System.EventHandler(this.btCadastrarProd_Click);
            // 
            // lbDataCadProdRes
            // 
            this.lbDataCadProdRes.AutoSize = true;
            this.lbDataCadProdRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadProdRes.Location = new System.Drawing.Point(265, 40);
            this.lbDataCadProdRes.Name = "lbDataCadProdRes";
            this.lbDataCadProdRes.Size = new System.Drawing.Size(65, 15);
            this.lbDataCadProdRes.TabIndex = 3;
            this.lbDataCadProdRes.Text = "13/11/2018";
            // 
            // ckbStatusAtivo
            // 
            this.ckbStatusAtivo.AutoSize = true;
            this.ckbStatusAtivo.Enabled = false;
            this.ckbStatusAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatusAtivo.Location = new System.Drawing.Point(471, 40);
            this.ckbStatusAtivo.Name = "ckbStatusAtivo";
            this.ckbStatusAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbStatusAtivo.TabIndex = 5;
            this.ckbStatusAtivo.Text = "Ativo";
            this.ckbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // lbDataCadProd
            // 
            this.lbDataCadProd.AutoSize = true;
            this.lbDataCadProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadProd.Location = new System.Drawing.Point(149, 39);
            this.lbDataCadProd.Name = "lbDataCadProd";
            this.lbDataCadProd.Size = new System.Drawing.Size(118, 17);
            this.lbDataCadProd.TabIndex = 2;
            this.lbDataCadProd.Text = "Data de Cadastro:";
            // 
            // lbStatusProd
            // 
            this.lbStatusProd.AutoSize = true;
            this.lbStatusProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusProd.Location = new System.Drawing.Point(415, 39);
            this.lbStatusProd.Name = "lbStatusProd";
            this.lbStatusProd.Size = new System.Drawing.Size(50, 17);
            this.lbStatusProd.TabIndex = 4;
            this.lbStatusProd.Text = "Status:";
            // 
            // lbCodigoProd
            // 
            this.lbCodigoProd.AutoSize = true;
            this.lbCodigoProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoProd.Location = new System.Drawing.Point(44, 38);
            this.lbCodigoProd.Name = "lbCodigoProd";
            this.lbCodigoProd.Size = new System.Drawing.Size(56, 17);
            this.lbCodigoProd.TabIndex = 0;
            this.lbCodigoProd.Text = "Código:";
            // 
            // gbDadosProd
            // 
            this.gbDadosProd.Controls.Add(this.label1);
            this.gbDadosProd.Controls.Add(this.txtMargem);
            this.gbDadosProd.Controls.Add(this.cbMarcaProd);
            this.gbDadosProd.Controls.Add(this.cbCategoriaProd);
            this.gbDadosProd.Controls.Add(this.txtCustoProd);
            this.gbDadosProd.Controls.Add(this.txtLucroProd);
            this.gbDadosProd.Controls.Add(this.txtDescricaoProd);
            this.gbDadosProd.Controls.Add(this.txtQtEstoque);
            this.gbDadosProd.Controls.Add(this.lbPrecoProd);
            this.gbDadosProd.Controls.Add(this.lbMarcaProd);
            this.gbDadosProd.Controls.Add(this.lbCategoriaProd);
            this.gbDadosProd.Controls.Add(this.lbLucroProd);
            this.gbDadosProd.Controls.Add(this.lbDescricaoProd);
            this.gbDadosProd.Controls.Add(this.lbCustoProd);
            this.gbDadosProd.Controls.Add(this.txtPrecoProd);
            this.gbDadosProd.Controls.Add(this.lbQtEstoque);
            this.gbDadosProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosProd.Location = new System.Drawing.Point(69, 117);
            this.gbDadosProd.Name = "gbDadosProd";
            this.gbDadosProd.Size = new System.Drawing.Size(423, 221);
            this.gbDadosProd.TabIndex = 6;
            this.gbDadosProd.TabStop = false;
            this.gbDadosProd.Text = "Dados do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = " Custo:";
            // 
            // txtMargem
            // 
            this.txtMargem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargem.Location = new System.Drawing.Point(259, 119);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(38, 25);
            this.txtMargem.TabIndex = 9;
            this.txtMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMargem.TextChanged += new System.EventHandler(this.txtMargem_TextChanged);
            this.txtMargem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMargem_KeyPress);
            // 
            // cbMarcaProd
            // 
            this.cbMarcaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcaProd.FormattingEnabled = true;
            this.cbMarcaProd.Location = new System.Drawing.Point(281, 29);
            this.cbMarcaProd.Name = "cbMarcaProd";
            this.cbMarcaProd.Size = new System.Drawing.Size(121, 25);
            this.cbMarcaProd.TabIndex = 3;
            // 
            // cbCategoriaProd
            // 
            this.cbCategoriaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaProd.FormattingEnabled = true;
            this.cbCategoriaProd.Location = new System.Drawing.Point(81, 28);
            this.cbCategoriaProd.Name = "cbCategoriaProd";
            this.cbCategoriaProd.Size = new System.Drawing.Size(133, 25);
            this.cbCategoriaProd.TabIndex = 1;
            // 
            // txtCustoProd
            // 
            this.txtCustoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoProd.Location = new System.Drawing.Point(57, 120);
            this.txtCustoProd.MaxLength = 7;
            this.txtCustoProd.Name = "txtCustoProd";
            this.txtCustoProd.Size = new System.Drawing.Size(55, 23);
            this.txtCustoProd.TabIndex = 7;
            this.txtCustoProd.TextChanged += new System.EventHandler(this.txtCustoProd_TextChanged);
            this.txtCustoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoProd_KeyPress);
            // 
            // txtLucroProd
            // 
            this.txtLucroProd.Enabled = false;
            this.txtLucroProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucroProd.Location = new System.Drawing.Point(353, 121);
            this.txtLucroProd.MaxLength = 7;
            this.txtLucroProd.Name = "txtLucroProd";
            this.txtLucroProd.Size = new System.Drawing.Size(49, 23);
            this.txtLucroProd.TabIndex = 11;
            this.txtLucroProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLucroProd_KeyPress);
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProd.Location = new System.Drawing.Point(81, 75);
            this.txtDescricaoProd.MaxLength = 50;
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(321, 23);
            this.txtDescricaoProd.TabIndex = 5;
            this.txtDescricaoProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoProd_KeyDown);
            // 
            // txtQtEstoque
            // 
            this.txtQtEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtEstoque.Location = new System.Drawing.Point(363, 177);
            this.txtQtEstoque.MaxLength = 4;
            this.txtQtEstoque.Name = "txtQtEstoque";
            this.txtQtEstoque.Size = new System.Drawing.Size(39, 23);
            this.txtQtEstoque.TabIndex = 15;
            this.txtQtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtEstoque_KeyPress);
            // 
            // lbPrecoProd
            // 
            this.lbPrecoProd.AutoSize = true;
            this.lbPrecoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoProd.Location = new System.Drawing.Point(8, 178);
            this.lbPrecoProd.Name = "lbPrecoProd";
            this.lbPrecoProd.Size = new System.Drawing.Size(45, 17);
            this.lbPrecoProd.TabIndex = 12;
            this.lbPrecoProd.Text = "Preço:";
            // 
            // lbMarcaProd
            // 
            this.lbMarcaProd.AutoSize = true;
            this.lbMarcaProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaProd.Location = new System.Drawing.Point(228, 35);
            this.lbMarcaProd.Name = "lbMarcaProd";
            this.lbMarcaProd.Size = new System.Drawing.Size(49, 17);
            this.lbMarcaProd.TabIndex = 2;
            this.lbMarcaProd.Text = "Marca:";
            // 
            // lbCategoriaProd
            // 
            this.lbCategoriaProd.AutoSize = true;
            this.lbCategoriaProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaProd.Location = new System.Drawing.Point(5, 33);
            this.lbCategoriaProd.Name = "lbCategoriaProd";
            this.lbCategoriaProd.Size = new System.Drawing.Size(71, 17);
            this.lbCategoriaProd.TabIndex = 0;
            this.lbCategoriaProd.Text = "Categoria:";
            // 
            // lbLucroProd
            // 
            this.lbLucroProd.AutoSize = true;
            this.lbLucroProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLucroProd.Location = new System.Drawing.Point(305, 125);
            this.lbLucroProd.Name = "lbLucroProd";
            this.lbLucroProd.Size = new System.Drawing.Size(44, 17);
            this.lbLucroProd.TabIndex = 10;
            this.lbLucroProd.Text = "Lucro:";
            // 
            // lbDescricaoProd
            // 
            this.lbDescricaoProd.AutoSize = true;
            this.lbDescricaoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoProd.Location = new System.Drawing.Point(5, 79);
            this.lbDescricaoProd.Name = "lbDescricaoProd";
            this.lbDescricaoProd.Size = new System.Drawing.Size(68, 17);
            this.lbDescricaoProd.TabIndex = 4;
            this.lbDescricaoProd.Text = "Descrição:";
            // 
            // lbCustoProd
            // 
            this.lbCustoProd.AutoSize = true;
            this.lbCustoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustoProd.Location = new System.Drawing.Point(117, 123);
            this.lbCustoProd.Name = "lbCustoProd";
            this.lbCustoProd.Size = new System.Drawing.Size(137, 17);
            this.lbCustoProd.TabIndex = 8;
            this.lbCustoProd.Text = "Margem de Lucro(%):";
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.Enabled = false;
            this.txtPrecoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoProd.Location = new System.Drawing.Point(55, 175);
            this.txtPrecoProd.MaxLength = 7;
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(55, 23);
            this.txtPrecoProd.TabIndex = 13;
            this.txtPrecoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoProd_KeyPress);
            // 
            // lbQtEstoque
            // 
            this.lbQtEstoque.AutoSize = true;
            this.lbQtEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtEstoque.Location = new System.Drawing.Point(199, 181);
            this.lbQtEstoque.Name = "lbQtEstoque";
            this.lbQtEstoque.Size = new System.Drawing.Size(158, 17);
            this.lbQtEstoque.TabIndex = 14;
            this.lbQtEstoque.Text = "Quantidade em Estoque:";
            // 
            // lbCamposObrig
            // 
            this.lbCamposObrig.AutoSize = true;
            this.lbCamposObrig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamposObrig.Location = new System.Drawing.Point(74, 341);
            this.lbCamposObrig.Name = "lbCamposObrig";
            this.lbCamposObrig.Size = new System.Drawing.Size(263, 17);
            this.lbCamposObrig.TabIndex = 7;
            this.lbCamposObrig.Text = "Campos com o símbolo \"*\" são obrigatórios.";
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = global::LojaInformatica.Properties.Resources.Prancheta_17;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.Location = new System.Drawing.Point(280, 386);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 25);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbCamposObrig);
            this.Controls.Add(this.gbDadosProd);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.btAtualizarProd);
            this.Controls.Add(this.btFecharProd);
            this.Controls.Add(this.btCadastrarProd);
            this.Controls.Add(this.lbDataCadProdRes);
            this.Controls.Add(this.ckbStatusAtivo);
            this.Controls.Add(this.lbDataCadProd);
            this.Controls.Add(this.lbStatusProd);
            this.Controls.Add(this.lbCodigoProd);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.gbDadosProd.ResumeLayout(false);
            this.gbDadosProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAtualizarProd;
        private System.Windows.Forms.Button btFecharProd;
        private System.Windows.Forms.Button btCadastrarProd;
        private System.Windows.Forms.Label lbDataCadProd;
        private System.Windows.Forms.Label lbStatusProd;
        private System.Windows.Forms.Label lbCodigoProd;
        private System.Windows.Forms.GroupBox gbDadosProd;
        private System.Windows.Forms.Label lbPrecoProd;
        private System.Windows.Forms.Label lbMarcaProd;
        private System.Windows.Forms.Label lbCategoriaProd;
        private System.Windows.Forms.Label lbQtEstoque;
        private System.Windows.Forms.Label lbCustoProd;
        private System.Windows.Forms.Label lbDescricaoProd;
        private System.Windows.Forms.Label lbLucroProd;
        private System.Windows.Forms.Label lbCamposObrig;
        private System.Windows.Forms.Button btExcluir;
        public System.Windows.Forms.TextBox txtCodProd;
        public System.Windows.Forms.Label lbDataCadProdRes;
        public System.Windows.Forms.CheckBox ckbStatusAtivo;
        public System.Windows.Forms.TextBox txtCustoProd;
        public System.Windows.Forms.TextBox txtQtEstoque;
        public System.Windows.Forms.TextBox txtLucroProd;
        public System.Windows.Forms.TextBox txtDescricaoProd;
        public System.Windows.Forms.TextBox txtPrecoProd;
        public System.Windows.Forms.ComboBox cbMarcaProd;
        public System.Windows.Forms.ComboBox cbCategoriaProd;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Label label1;
    }
}