namespace LojaInformatica
{
    partial class FormConsulta
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
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.rbRelatorio = new System.Windows.Forms.RadioButton();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbCargo = new System.Windows.Forms.RadioButton();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbCaracteres = new System.Windows.Forms.GroupBox();
            this.rbComeca = new System.Windows.Forms.RadioButton();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.gbTipoConsulta = new System.Windows.Forms.GroupBox();
            this.rbCategoriaProd = new System.Windows.Forms.RadioButton();
            this.rbMarcaProd = new System.Windows.Forms.RadioButton();
            this.rbPrecoProd = new System.Windows.Forms.RadioButton();
            this.rbSexo = new System.Windows.Forms.RadioButton();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbFuncao = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbCaracteres.SuspendLayout();
            this.gbTipoConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.rbRelatorio);
            this.gbConsulta.Controls.Add(this.rbVenda);
            this.gbConsulta.Controls.Add(this.rbCategoria);
            this.gbConsulta.Controls.Add(this.rbMarca);
            this.gbConsulta.Controls.Add(this.rbProduto);
            this.gbConsulta.Controls.Add(this.rbCliente);
            this.gbConsulta.Controls.Add(this.rbCargo);
            this.gbConsulta.Controls.Add(this.rbFuncionario);
            this.gbConsulta.Location = new System.Drawing.Point(27, 90);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(272, 155);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta:";
            // 
            // rbRelatorio
            // 
            this.rbRelatorio.AutoSize = true;
            this.rbRelatorio.Location = new System.Drawing.Point(118, 110);
            this.rbRelatorio.Name = "rbRelatorio";
            this.rbRelatorio.Size = new System.Drawing.Size(128, 19);
            this.rbRelatorio.TabIndex = 7;
            this.rbRelatorio.TabStop = true;
            this.rbRelatorio.Text = "Relatório de Vendas";
            this.rbRelatorio.UseVisualStyleBackColor = true;
            this.rbRelatorio.CheckedChanged += new System.EventHandler(this.rbRelatorio_CheckedChanged);
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(7, 110);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(57, 19);
            this.rbVenda.TabIndex = 6;
            this.rbVenda.TabStop = true;
            this.rbVenda.Text = "Venda";
            this.rbVenda.UseVisualStyleBackColor = true;
            this.rbVenda.CheckedChanged += new System.EventHandler(this.rbVenda_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(118, 85);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(76, 19);
            this.rbCategoria.TabIndex = 5;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(7, 85);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(58, 19);
            this.rbMarca.TabIndex = 4;
            this.rbMarca.TabStop = true;
            this.rbMarca.Text = "Marca";
            this.rbMarca.UseVisualStyleBackColor = true;
            this.rbMarca.CheckedChanged += new System.EventHandler(this.rbMarca_CheckedChanged);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(118, 60);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(68, 19);
            this.rbProduto.TabIndex = 3;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.rbProduto_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(7, 60);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(62, 19);
            this.rbCliente.TabIndex = 2;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbCargo
            // 
            this.rbCargo.AutoSize = true;
            this.rbCargo.Location = new System.Drawing.Point(118, 35);
            this.rbCargo.Name = "rbCargo";
            this.rbCargo.Size = new System.Drawing.Size(57, 19);
            this.rbCargo.TabIndex = 1;
            this.rbCargo.TabStop = true;
            this.rbCargo.Text = "Cargo";
            this.rbCargo.UseVisualStyleBackColor = true;
            this.rbCargo.CheckedChanged += new System.EventHandler(this.rbCargo_CheckedChanged);
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Location = new System.Drawing.Point(7, 35);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(88, 19);
            this.rbFuncionario.TabIndex = 0;
            this.rbFuncionario.TabStop = true;
            this.rbFuncionario.Text = "Funcionário";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            this.rbFuncionario.CheckedChanged += new System.EventHandler(this.rbFuncionario_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(156, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(563, 23);
            this.txtPesquisa.TabIndex = 1;
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Location = new System.Drawing.Point(94, 49);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(56, 15);
            this.lbPesquisa.TabIndex = 2;
            this.lbPesquisa.Text = "Pesquisa:";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(27, 261);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvResult.Size = new System.Drawing.Size(692, 292);
            this.dgvResult.TabIndex = 3;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(519, 90);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 75);
            this.gbStatus.TabIndex = 4;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(17, 48);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(61, 19);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(17, 23);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(53, 19);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbCaracteres
            // 
            this.gbCaracteres.Controls.Add(this.rbComeca);
            this.gbCaracteres.Controls.Add(this.rbContem);
            this.gbCaracteres.Location = new System.Drawing.Point(519, 175);
            this.gbCaracteres.Name = "gbCaracteres";
            this.gbCaracteres.Size = new System.Drawing.Size(200, 70);
            this.gbCaracteres.TabIndex = 5;
            this.gbCaracteres.TabStop = false;
            this.gbCaracteres.Text = "Pesquisa por Caracteres:";
            // 
            // rbComeca
            // 
            this.rbComeca.AutoSize = true;
            this.rbComeca.Location = new System.Drawing.Point(85, 27);
            this.rbComeca.Name = "rbComeca";
            this.rbComeca.Size = new System.Drawing.Size(96, 19);
            this.rbComeca.TabIndex = 1;
            this.rbComeca.TabStop = true;
            this.rbComeca.Text = "Começa com";
            this.rbComeca.UseVisualStyleBackColor = true;
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(7, 26);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(69, 19);
            this.rbContem.TabIndex = 0;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Pode ter";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(444, 578);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(542, 578);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(642, 578);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 9;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // gbTipoConsulta
            // 
            this.gbTipoConsulta.Controls.Add(this.rbCategoriaProd);
            this.gbTipoConsulta.Controls.Add(this.rbMarcaProd);
            this.gbTipoConsulta.Controls.Add(this.rbPrecoProd);
            this.gbTipoConsulta.Controls.Add(this.rbSexo);
            this.gbTipoConsulta.Controls.Add(this.rbStatus);
            this.gbTipoConsulta.Controls.Add(this.rbCpf);
            this.gbTipoConsulta.Controls.Add(this.rbFuncao);
            this.gbTipoConsulta.Controls.Add(this.rbNome);
            this.gbTipoConsulta.Location = new System.Drawing.Point(306, 90);
            this.gbTipoConsulta.Name = "gbTipoConsulta";
            this.gbTipoConsulta.Size = new System.Drawing.Size(200, 155);
            this.gbTipoConsulta.TabIndex = 10;
            this.gbTipoConsulta.TabStop = false;
            this.gbTipoConsulta.Text = "Tipo de Consulta:";
            // 
            // rbCategoriaProd
            // 
            this.rbCategoriaProd.AutoSize = true;
            this.rbCategoriaProd.Location = new System.Drawing.Point(100, 76);
            this.rbCategoriaProd.Name = "rbCategoriaProd";
            this.rbCategoriaProd.Size = new System.Drawing.Size(76, 19);
            this.rbCategoriaProd.TabIndex = 7;
            this.rbCategoriaProd.TabStop = true;
            this.rbCategoriaProd.Text = "Categoria";
            this.rbCategoriaProd.UseVisualStyleBackColor = true;
            this.rbCategoriaProd.CheckedChanged += new System.EventHandler(this.rbCategoriaProd_CheckedChanged);
            // 
            // rbMarcaProd
            // 
            this.rbMarcaProd.AutoSize = true;
            this.rbMarcaProd.Location = new System.Drawing.Point(100, 51);
            this.rbMarcaProd.Name = "rbMarcaProd";
            this.rbMarcaProd.Size = new System.Drawing.Size(58, 19);
            this.rbMarcaProd.TabIndex = 6;
            this.rbMarcaProd.TabStop = true;
            this.rbMarcaProd.Text = "Marca";
            this.rbMarcaProd.UseVisualStyleBackColor = true;
            this.rbMarcaProd.CheckedChanged += new System.EventHandler(this.rbMarcaProd_CheckedChanged);
            // 
            // rbPrecoProd
            // 
            this.rbPrecoProd.AutoSize = true;
            this.rbPrecoProd.Location = new System.Drawing.Point(100, 26);
            this.rbPrecoProd.Name = "rbPrecoProd";
            this.rbPrecoProd.Size = new System.Drawing.Size(55, 19);
            this.rbPrecoProd.TabIndex = 5;
            this.rbPrecoProd.TabStop = true;
            this.rbPrecoProd.Text = "Preço";
            this.rbPrecoProd.UseVisualStyleBackColor = true;
            this.rbPrecoProd.CheckedChanged += new System.EventHandler(this.rbPrecoProd_CheckedChanged);
            // 
            // rbSexo
            // 
            this.rbSexo.AutoSize = true;
            this.rbSexo.Location = new System.Drawing.Point(7, 130);
            this.rbSexo.Name = "rbSexo";
            this.rbSexo.Size = new System.Drawing.Size(49, 19);
            this.rbSexo.TabIndex = 4;
            this.rbSexo.TabStop = true;
            this.rbSexo.Text = "Sexo";
            this.rbSexo.UseVisualStyleBackColor = true;
            this.rbSexo.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Location = new System.Drawing.Point(7, 102);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(57, 19);
            this.rbStatus.TabIndex = 3;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "Status";
            this.rbStatus.UseVisualStyleBackColor = true;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(7, 76);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(46, 19);
            this.rbCpf.TabIndex = 2;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // rbFuncao
            // 
            this.rbFuncao.AutoSize = true;
            this.rbFuncao.Location = new System.Drawing.Point(7, 51);
            this.rbFuncao.Name = "rbFuncao";
            this.rbFuncao.Size = new System.Drawing.Size(57, 19);
            this.rbFuncao.TabIndex = 1;
            this.rbFuncao.TabStop = true;
            this.rbFuncao.Text = "Cargo";
            this.rbFuncao.UseVisualStyleBackColor = true;
            this.rbFuncao.CheckedChanged += new System.EventHandler(this.rbFuncao_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(7, 26);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(58, 19);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // FormConsulta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(759, 620);
            this.ControlBox = false;
            this.Controls.Add(this.gbTipoConsulta);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.gbCaracteres);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lbPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gbConsulta);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCaracteres.ResumeLayout(false);
            this.gbCaracteres.PerformLayout();
            this.gbTipoConsulta.ResumeLayout(false);
            this.gbTipoConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.RadioButton rbRelatorio;
        private System.Windows.Forms.RadioButton rbVenda;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbCargo;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lbPesquisa;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbCaracteres;
        private System.Windows.Forms.RadioButton rbComeca;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.GroupBox gbTipoConsulta;
        private System.Windows.Forms.RadioButton rbSexo;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbFuncao;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCategoriaProd;
        private System.Windows.Forms.RadioButton rbMarcaProd;
        private System.Windows.Forms.RadioButton rbPrecoProd;
    }
}