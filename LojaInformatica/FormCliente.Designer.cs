namespace LojaInformatica
{
    partial class FormCliente
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
            this.lbCodigoCli = new System.Windows.Forms.Label();
            this.lbNomeCli = new System.Windows.Forms.Label();
            this.lbStatusCli = new System.Windows.Forms.Label();
            this.lbSexoCli = new System.Windows.Forms.Label();
            this.lbCpfCli = new System.Windows.Forms.Label();
            this.lbRuaCli = new System.Windows.Forms.Label();
            this.lbNumeroCli = new System.Windows.Forms.Label();
            this.lbComplementoCli = new System.Windows.Forms.Label();
            this.lbBairroCli = new System.Windows.Forms.Label();
            this.lbCidadeCli = new System.Windows.Forms.Label();
            this.lbEstadoCli = new System.Windows.Forms.Label();
            this.lbDataCadCli = new System.Windows.Forms.Label();
            this.lbTelComCli = new System.Windows.Forms.Label();
            this.lbTelResCli = new System.Windows.Forms.Label();
            this.lbCelCli = new System.Windows.Forms.Label();
            this.lbDataNascCli = new System.Windows.Forms.Label();
            this.lbSobrenomeCli = new System.Windows.Forms.Label();
            this.gbDadosPessoaisCli = new System.Windows.Forms.GroupBox();
            this.mtxtDataNascCli = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpfCli = new System.Windows.Forms.MaskedTextBox();
            this.rbMasculinoCli = new System.Windows.Forms.RadioButton();
            this.rbFemininoCli = new System.Windows.Forms.RadioButton();
            this.txtSobrenomeCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.gbEnderecoCli = new System.Windows.Forms.GroupBox();
            this.mtxtCepCli = new System.Windows.Forms.MaskedTextBox();
            this.lbCepCli = new System.Windows.Forms.Label();
            this.cbEstadoCli = new System.Windows.Forms.ComboBox();
            this.btConsultaCEP = new System.Windows.Forms.Button();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtCidadeCli = new System.Windows.Forms.TextBox();
            this.txtComplementoCli = new System.Windows.Forms.TextBox();
            this.txtNumeroCli = new System.Windows.Forms.TextBox();
            this.txtRuaCli = new System.Windows.Forms.TextBox();
            this.lbEmailCli = new System.Windows.Forms.Label();
            this.gbContatoCli = new System.Windows.Forms.GroupBox();
            this.lbTelAtencao = new System.Windows.Forms.Label();
            this.mtxtTelComCli = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelCli = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.mtxtTelResCli = new System.Windows.Forms.MaskedTextBox();
            this.btCadastrarCli = new System.Windows.Forms.Button();
            this.btFecharCli = new System.Windows.Forms.Button();
            this.ckbStatusAtivo = new System.Windows.Forms.CheckBox();
            this.btAtualizarCli = new System.Windows.Forms.Button();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lbDataCadCliRes = new System.Windows.Forms.Label();
            this.lbCamposObrig = new System.Windows.Forms.Label();
            this.btExcluirCli = new System.Windows.Forms.Button();
            this.gbDadosPessoaisCli.SuspendLayout();
            this.gbEnderecoCli.SuspendLayout();
            this.gbContatoCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigoCli
            // 
            this.lbCodigoCli.AutoSize = true;
            this.lbCodigoCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCli.Location = new System.Drawing.Point(36, 25);
            this.lbCodigoCli.Name = "lbCodigoCli";
            this.lbCodigoCli.Size = new System.Drawing.Size(56, 17);
            this.lbCodigoCli.TabIndex = 0;
            this.lbCodigoCli.Text = "Código:";
            // 
            // lbNomeCli
            // 
            this.lbNomeCli.AutoSize = true;
            this.lbNomeCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCli.Location = new System.Drawing.Point(8, 32);
            this.lbNomeCli.Name = "lbNomeCli";
            this.lbNomeCli.Size = new System.Drawing.Size(48, 15);
            this.lbNomeCli.TabIndex = 0;
            this.lbNomeCli.Text = "Nome:*";
            // 
            // lbStatusCli
            // 
            this.lbStatusCli.AutoSize = true;
            this.lbStatusCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusCli.Location = new System.Drawing.Point(555, 21);
            this.lbStatusCli.Name = "lbStatusCli";
            this.lbStatusCli.Size = new System.Drawing.Size(50, 17);
            this.lbStatusCli.TabIndex = 4;
            this.lbStatusCli.Text = "Status:";
            // 
            // lbSexoCli
            // 
            this.lbSexoCli.AutoSize = true;
            this.lbSexoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexoCli.Location = new System.Drawing.Point(419, 71);
            this.lbSexoCli.Name = "lbSexoCli";
            this.lbSexoCli.Size = new System.Drawing.Size(41, 15);
            this.lbSexoCli.TabIndex = 4;
            this.lbSexoCli.Text = "Sexo:*";
            // 
            // lbCpfCli
            // 
            this.lbCpfCli.AutoSize = true;
            this.lbCpfCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfCli.Location = new System.Drawing.Point(249, 70);
            this.lbCpfCli.Name = "lbCpfCli";
            this.lbCpfCli.Size = new System.Drawing.Size(35, 15);
            this.lbCpfCli.TabIndex = 9;
            this.lbCpfCli.Text = "CPF:*";
            // 
            // lbRuaCli
            // 
            this.lbRuaCli.AutoSize = true;
            this.lbRuaCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuaCli.Location = new System.Drawing.Point(143, 32);
            this.lbRuaCli.Name = "lbRuaCli";
            this.lbRuaCli.Size = new System.Drawing.Size(35, 15);
            this.lbRuaCli.TabIndex = 2;
            this.lbRuaCli.Text = "Rua:*";
            // 
            // lbNumeroCli
            // 
            this.lbNumeroCli.AutoSize = true;
            this.lbNumeroCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCli.Location = new System.Drawing.Point(499, 33);
            this.lbNumeroCli.Name = "lbNumeroCli";
            this.lbNumeroCli.Size = new System.Drawing.Size(59, 15);
            this.lbNumeroCli.TabIndex = 4;
            this.lbNumeroCli.Text = "Número:*";
            // 
            // lbComplementoCli
            // 
            this.lbComplementoCli.AutoSize = true;
            this.lbComplementoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplementoCli.Location = new System.Drawing.Point(10, 98);
            this.lbComplementoCli.Name = "lbComplementoCli";
            this.lbComplementoCli.Size = new System.Drawing.Size(86, 15);
            this.lbComplementoCli.TabIndex = 6;
            this.lbComplementoCli.Text = "Complemento:";
            // 
            // lbBairroCli
            // 
            this.lbBairroCli.AutoSize = true;
            this.lbBairroCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairroCli.Location = new System.Drawing.Point(189, 98);
            this.lbBairroCli.Name = "lbBairroCli";
            this.lbBairroCli.Size = new System.Drawing.Size(46, 15);
            this.lbBairroCli.TabIndex = 8;
            this.lbBairroCli.Text = "Bairro:*";
            // 
            // lbCidadeCli
            // 
            this.lbCidadeCli.AutoSize = true;
            this.lbCidadeCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidadeCli.Location = new System.Drawing.Point(344, 98);
            this.lbCidadeCli.Name = "lbCidadeCli";
            this.lbCidadeCli.Size = new System.Drawing.Size(51, 15);
            this.lbCidadeCli.TabIndex = 10;
            this.lbCidadeCli.Text = "Cidade:*";
            // 
            // lbEstadoCli
            // 
            this.lbEstadoCli.AutoSize = true;
            this.lbEstadoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCli.Location = new System.Drawing.Point(526, 98);
            this.lbEstadoCli.Name = "lbEstadoCli";
            this.lbEstadoCli.Size = new System.Drawing.Size(50, 15);
            this.lbEstadoCli.TabIndex = 12;
            this.lbEstadoCli.Text = "Estado:*";
            // 
            // lbDataCadCli
            // 
            this.lbDataCadCli.AutoSize = true;
            this.lbDataCadCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadCli.Location = new System.Drawing.Point(255, 22);
            this.lbDataCadCli.Name = "lbDataCadCli";
            this.lbDataCadCli.Size = new System.Drawing.Size(118, 17);
            this.lbDataCadCli.TabIndex = 2;
            this.lbDataCadCli.Text = "Data de Cadastro:";
            // 
            // lbTelComCli
            // 
            this.lbTelComCli.AutoSize = true;
            this.lbTelComCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelComCli.Location = new System.Drawing.Point(237, 33);
            this.lbTelComCli.Name = "lbTelComCli";
            this.lbTelComCli.Size = new System.Drawing.Size(111, 15);
            this.lbTelComCli.TabIndex = 2;
            this.lbTelComCli.Text = "Telefone Comercial:";
            // 
            // lbTelResCli
            // 
            this.lbTelResCli.AutoSize = true;
            this.lbTelResCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelResCli.Location = new System.Drawing.Point(6, 31);
            this.lbTelResCli.Name = "lbTelResCli";
            this.lbTelResCli.Size = new System.Drawing.Size(117, 15);
            this.lbTelResCli.TabIndex = 0;
            this.lbTelResCli.Text = "Telefone Residencial:";
            // 
            // lbCelCli
            // 
            this.lbCelCli.AutoSize = true;
            this.lbCelCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelCli.Location = new System.Drawing.Point(481, 31);
            this.lbCelCli.Name = "lbCelCli";
            this.lbCelCli.Size = new System.Drawing.Size(46, 15);
            this.lbCelCli.TabIndex = 4;
            this.lbCelCli.Text = "Celular:";
            // 
            // lbDataNascCli
            // 
            this.lbDataNascCli.AutoSize = true;
            this.lbDataNascCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascCli.Location = new System.Drawing.Point(9, 72);
            this.lbDataNascCli.Name = "lbDataNascCli";
            this.lbDataNascCli.Size = new System.Drawing.Size(123, 15);
            this.lbDataNascCli.TabIndex = 7;
            this.lbDataNascCli.Text = "Data de Nascimento:*";
            // 
            // lbSobrenomeCli
            // 
            this.lbSobrenomeCli.AutoSize = true;
            this.lbSobrenomeCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenomeCli.Location = new System.Drawing.Point(207, 32);
            this.lbSobrenomeCli.Name = "lbSobrenomeCli";
            this.lbSobrenomeCli.Size = new System.Drawing.Size(77, 15);
            this.lbSobrenomeCli.TabIndex = 2;
            this.lbSobrenomeCli.Text = "Sobrenome:*";
            // 
            // gbDadosPessoaisCli
            // 
            this.gbDadosPessoaisCli.Controls.Add(this.mtxtDataNascCli);
            this.gbDadosPessoaisCli.Controls.Add(this.mtxtCpfCli);
            this.gbDadosPessoaisCli.Controls.Add(this.rbMasculinoCli);
            this.gbDadosPessoaisCli.Controls.Add(this.rbFemininoCli);
            this.gbDadosPessoaisCli.Controls.Add(this.txtSobrenomeCli);
            this.gbDadosPessoaisCli.Controls.Add(this.lbSobrenomeCli);
            this.gbDadosPessoaisCli.Controls.Add(this.txtNomeCli);
            this.gbDadosPessoaisCli.Controls.Add(this.lbNomeCli);
            this.gbDadosPessoaisCli.Controls.Add(this.lbDataNascCli);
            this.gbDadosPessoaisCli.Controls.Add(this.lbCpfCli);
            this.gbDadosPessoaisCli.Controls.Add(this.lbSexoCli);
            this.gbDadosPessoaisCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoaisCli.Location = new System.Drawing.Point(27, 63);
            this.gbDadosPessoaisCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDadosPessoaisCli.Name = "gbDadosPessoaisCli";
            this.gbDadosPessoaisCli.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDadosPessoaisCli.Size = new System.Drawing.Size(650, 101);
            this.gbDadosPessoaisCli.TabIndex = 7;
            this.gbDadosPessoaisCli.TabStop = false;
            this.gbDadosPessoaisCli.Text = "Dados Pessoais:";
            // 
            // mtxtDataNascCli
            // 
            this.mtxtDataNascCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNascCli.Location = new System.Drawing.Point(134, 68);
            this.mtxtDataNascCli.Mask = "00/00/0000";
            this.mtxtDataNascCli.Name = "mtxtDataNascCli";
            this.mtxtDataNascCli.Size = new System.Drawing.Size(67, 23);
            this.mtxtDataNascCli.TabIndex = 8;
            this.mtxtDataNascCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataNascCli.ValidatingType = typeof(System.DateTime);
            this.mtxtDataNascCli.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDataNascCli_TypeValidationCompleted);
            // 
            // mtxtCpfCli
            // 
            this.mtxtCpfCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCpfCli.Location = new System.Drawing.Point(288, 65);
            this.mtxtCpfCli.Mask = "000,000,000-00";
            this.mtxtCpfCli.Name = "mtxtCpfCli";
            this.mtxtCpfCli.Size = new System.Drawing.Size(95, 23);
            this.mtxtCpfCli.TabIndex = 10;
            this.mtxtCpfCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtCpfCli.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtCpfCli_Validating);
            // 
            // rbMasculinoCli
            // 
            this.rbMasculinoCli.AutoSize = true;
            this.rbMasculinoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculinoCli.Location = new System.Drawing.Point(467, 68);
            this.rbMasculinoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMasculinoCli.Name = "rbMasculinoCli";
            this.rbMasculinoCli.Size = new System.Drawing.Size(80, 19);
            this.rbMasculinoCli.TabIndex = 5;
            this.rbMasculinoCli.TabStop = true;
            this.rbMasculinoCli.Text = "Masculino";
            this.rbMasculinoCli.UseVisualStyleBackColor = true;
            // 
            // rbFemininoCli
            // 
            this.rbFemininoCli.AutoSize = true;
            this.rbFemininoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemininoCli.Location = new System.Drawing.Point(553, 69);
            this.rbFemininoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemininoCli.Name = "rbFemininoCli";
            this.rbFemininoCli.Size = new System.Drawing.Size(75, 19);
            this.rbFemininoCli.TabIndex = 6;
            this.rbFemininoCli.TabStop = true;
            this.rbFemininoCli.Text = "Feminino";
            this.rbFemininoCli.UseVisualStyleBackColor = true;
            // 
            // txtSobrenomeCli
            // 
            this.txtSobrenomeCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeCli.Location = new System.Drawing.Point(288, 27);
            this.txtSobrenomeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSobrenomeCli.MaxLength = 40;
            this.txtSobrenomeCli.Name = "txtSobrenomeCli";
            this.txtSobrenomeCli.Size = new System.Drawing.Size(340, 23);
            this.txtSobrenomeCli.TabIndex = 3;
            this.txtSobrenomeCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSobrenomeCli_KeyDown);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(57, 27);
            this.txtNomeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeCli.MaxLength = 30;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(144, 23);
            this.txtNomeCli.TabIndex = 1;
            this.txtNomeCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCli_KeyDown);
            // 
            // gbEnderecoCli
            // 
            this.gbEnderecoCli.Controls.Add(this.mtxtCepCli);
            this.gbEnderecoCli.Controls.Add(this.lbCepCli);
            this.gbEnderecoCli.Controls.Add(this.cbEstadoCli);
            this.gbEnderecoCli.Controls.Add(this.btConsultaCEP);
            this.gbEnderecoCli.Controls.Add(this.txtBairroCli);
            this.gbEnderecoCli.Controls.Add(this.txtCidadeCli);
            this.gbEnderecoCli.Controls.Add(this.txtComplementoCli);
            this.gbEnderecoCli.Controls.Add(this.txtNumeroCli);
            this.gbEnderecoCli.Controls.Add(this.txtRuaCli);
            this.gbEnderecoCli.Controls.Add(this.lbRuaCli);
            this.gbEnderecoCli.Controls.Add(this.lbNumeroCli);
            this.gbEnderecoCli.Controls.Add(this.lbCidadeCli);
            this.gbEnderecoCli.Controls.Add(this.lbComplementoCli);
            this.gbEnderecoCli.Controls.Add(this.lbEstadoCli);
            this.gbEnderecoCli.Controls.Add(this.lbBairroCli);
            this.gbEnderecoCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnderecoCli.Location = new System.Drawing.Point(27, 169);
            this.gbEnderecoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEnderecoCli.Name = "gbEnderecoCli";
            this.gbEnderecoCli.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEnderecoCli.Size = new System.Drawing.Size(650, 138);
            this.gbEnderecoCli.TabIndex = 8;
            this.gbEnderecoCli.TabStop = false;
            this.gbEnderecoCli.Text = "Endereço:";
            // 
            // mtxtCepCli
            // 
            this.mtxtCepCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCepCli.Location = new System.Drawing.Point(56, 28);
            this.mtxtCepCli.Mask = "00000-000";
            this.mtxtCepCli.Name = "mtxtCepCli";
            this.mtxtCepCli.Size = new System.Drawing.Size(83, 23);
            this.mtxtCepCli.TabIndex = 1;
            this.mtxtCepCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCepCli
            // 
            this.lbCepCli.AutoSize = true;
            this.lbCepCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCepCli.Location = new System.Drawing.Point(13, 33);
            this.lbCepCli.Name = "lbCepCli";
            this.lbCepCli.Size = new System.Drawing.Size(40, 17);
            this.lbCepCli.TabIndex = 0;
            this.lbCepCli.Text = "CEP:*";
            // 
            // cbEstadoCli
            // 
            this.cbEstadoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCli.FormattingEnabled = true;
            this.cbEstadoCli.Location = new System.Drawing.Point(580, 94);
            this.cbEstadoCli.Name = "cbEstadoCli";
            this.cbEstadoCli.Size = new System.Drawing.Size(46, 23);
            this.cbEstadoCli.TabIndex = 13;
            // 
            // btConsultaCEP
            // 
            this.btConsultaCEP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaCEP.Image = global::LojaInformatica.Properties.Resources.Prancheta_10;
            this.btConsultaCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsultaCEP.Location = new System.Drawing.Point(12, 57);
            this.btConsultaCEP.Name = "btConsultaCEP";
            this.btConsultaCEP.Size = new System.Drawing.Size(127, 23);
            this.btConsultaCEP.TabIndex = 12;
            this.btConsultaCEP.Text = "Consultar CEP";
            this.btConsultaCEP.UseVisualStyleBackColor = true;
            this.btConsultaCEP.Click += new System.EventHandler(this.btConsultaCEP_Click);
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCli.Location = new System.Drawing.Point(238, 94);
            this.txtBairroCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairroCli.MaxLength = 30;
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(95, 23);
            this.txtBairroCli.TabIndex = 9;
            // 
            // txtCidadeCli
            // 
            this.txtCidadeCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCli.Location = new System.Drawing.Point(398, 94);
            this.txtCidadeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidadeCli.MaxLength = 40;
            this.txtCidadeCli.Name = "txtCidadeCli";
            this.txtCidadeCli.Size = new System.Drawing.Size(95, 23);
            this.txtCidadeCli.TabIndex = 11;
            // 
            // txtComplementoCli
            // 
            this.txtComplementoCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoCli.Location = new System.Drawing.Point(99, 94);
            this.txtComplementoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplementoCli.MaxLength = 15;
            this.txtComplementoCli.Name = "txtComplementoCli";
            this.txtComplementoCli.Size = new System.Drawing.Size(79, 23);
            this.txtComplementoCli.TabIndex = 7;
            // 
            // txtNumeroCli
            // 
            this.txtNumeroCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCli.Location = new System.Drawing.Point(559, 28);
            this.txtNumeroCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroCli.MaxLength = 5;
            this.txtNumeroCli.Name = "txtNumeroCli";
            this.txtNumeroCli.Size = new System.Drawing.Size(69, 23);
            this.txtNumeroCli.TabIndex = 5;
            this.txtNumeroCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCli_KeyPress);
            // 
            // txtRuaCli
            // 
            this.txtRuaCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCli.Location = new System.Drawing.Point(180, 28);
            this.txtRuaCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuaCli.MaxLength = 60;
            this.txtRuaCli.Name = "txtRuaCli";
            this.txtRuaCli.Size = new System.Drawing.Size(315, 23);
            this.txtRuaCli.TabIndex = 3;
            // 
            // lbEmailCli
            // 
            this.lbEmailCli.AutoSize = true;
            this.lbEmailCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailCli.Location = new System.Drawing.Point(10, 94);
            this.lbEmailCli.Name = "lbEmailCli";
            this.lbEmailCli.Size = new System.Drawing.Size(44, 15);
            this.lbEmailCli.TabIndex = 7;
            this.lbEmailCli.Text = "E-mail:";
            // 
            // gbContatoCli
            // 
            this.gbContatoCli.Controls.Add(this.lbTelAtencao);
            this.gbContatoCli.Controls.Add(this.mtxtTelComCli);
            this.gbContatoCli.Controls.Add(this.lbEmailCli);
            this.gbContatoCli.Controls.Add(this.lbCelCli);
            this.gbContatoCli.Controls.Add(this.mtxtCelCli);
            this.gbContatoCli.Controls.Add(this.txtEmailCli);
            this.gbContatoCli.Controls.Add(this.mtxtTelResCli);
            this.gbContatoCli.Controls.Add(this.lbTelResCli);
            this.gbContatoCli.Controls.Add(this.lbTelComCli);
            this.gbContatoCli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContatoCli.Location = new System.Drawing.Point(27, 324);
            this.gbContatoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbContatoCli.Name = "gbContatoCli";
            this.gbContatoCli.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbContatoCli.Size = new System.Drawing.Size(652, 125);
            this.gbContatoCli.TabIndex = 9;
            this.gbContatoCli.TabStop = false;
            this.gbContatoCli.Text = "Contato:";
            // 
            // lbTelAtencao
            // 
            this.lbTelAtencao.AutoSize = true;
            this.lbTelAtencao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelAtencao.Location = new System.Drawing.Point(6, 57);
            this.lbTelAtencao.Name = "lbTelAtencao";
            this.lbTelAtencao.Size = new System.Drawing.Size(287, 17);
            this.lbTelAtencao.TabIndex = 6;
            this.lbTelAtencao.Text = "Preencher pelo menos um número de telefone.";
            // 
            // mtxtTelComCli
            // 
            this.mtxtTelComCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelComCli.Location = new System.Drawing.Point(352, 29);
            this.mtxtTelComCli.Mask = "(00) 0000-0000";
            this.mtxtTelComCli.Name = "mtxtTelComCli";
            this.mtxtTelComCli.Size = new System.Drawing.Size(84, 23);
            this.mtxtTelComCli.TabIndex = 3;
            // 
            // mtxtCelCli
            // 
            this.mtxtCelCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCelCli.Location = new System.Drawing.Point(530, 26);
            this.mtxtCelCli.Mask = "(00) 00000-0000";
            this.mtxtCelCli.Name = "mtxtCelCli";
            this.mtxtCelCli.Size = new System.Drawing.Size(96, 23);
            this.mtxtCelCli.TabIndex = 5;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCli.Location = new System.Drawing.Point(57, 90);
            this.txtEmailCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailCli.MaxLength = 40;
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(569, 23);
            this.txtEmailCli.TabIndex = 8;
            // 
            // mtxtTelResCli
            // 
            this.mtxtTelResCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelResCli.Location = new System.Drawing.Point(126, 26);
            this.mtxtTelResCli.Mask = "(00) 0000-0000";
            this.mtxtTelResCli.Name = "mtxtTelResCli";
            this.mtxtTelResCli.Size = new System.Drawing.Size(84, 23);
            this.mtxtTelResCli.TabIndex = 1;
            // 
            // btCadastrarCli
            // 
            this.btCadastrarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCli.Image = global::LojaInformatica.Properties.Resources.Prancheta_14;
            this.btCadastrarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrarCli.Location = new System.Drawing.Point(161, 486);
            this.btCadastrarCli.Name = "btCadastrarCli";
            this.btCadastrarCli.Size = new System.Drawing.Size(80, 25);
            this.btCadastrarCli.TabIndex = 11;
            this.btCadastrarCli.Text = "Cadastrar";
            this.btCadastrarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarCli.UseVisualStyleBackColor = true;
            this.btCadastrarCli.Click += new System.EventHandler(this.btCadastrarCli_Click);
            // 
            // btFecharCli
            // 
            this.btFecharCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCli.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btFecharCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFecharCli.Location = new System.Drawing.Point(425, 486);
            this.btFecharCli.Name = "btFecharCli";
            this.btFecharCli.Size = new System.Drawing.Size(80, 25);
            this.btFecharCli.TabIndex = 13;
            this.btFecharCli.Text = "Fechar";
            this.btFecharCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFecharCli.UseVisualStyleBackColor = true;
            this.btFecharCli.Click += new System.EventHandler(this.btFecharCli_Click);
            // 
            // ckbStatusAtivo
            // 
            this.ckbStatusAtivo.AutoSize = true;
            this.ckbStatusAtivo.Enabled = false;
            this.ckbStatusAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatusAtivo.Location = new System.Drawing.Point(614, 22);
            this.ckbStatusAtivo.Name = "ckbStatusAtivo";
            this.ckbStatusAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbStatusAtivo.TabIndex = 5;
            this.ckbStatusAtivo.Text = "Ativo";
            this.ckbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // btAtualizarCli
            // 
            this.btAtualizarCli.Enabled = false;
            this.btAtualizarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCli.Image = global::LojaInformatica.Properties.Resources.Prancheta_19;
            this.btAtualizarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarCli.Location = new System.Drawing.Point(335, 486);
            this.btAtualizarCli.Name = "btAtualizarCli";
            this.btAtualizarCli.Size = new System.Drawing.Size(80, 25);
            this.btAtualizarCli.TabIndex = 12;
            this.btAtualizarCli.Text = "Atualizar";
            this.btAtualizarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarCli.UseVisualStyleBackColor = true;
            this.btAtualizarCli.Click += new System.EventHandler(this.btAtualizarCli_Click);
            // 
            // txtCodCli
            // 
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Location = new System.Drawing.Point(98, 19);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(30, 23);
            this.txtCodCli.TabIndex = 1;
            // 
            // lbDataCadCliRes
            // 
            this.lbDataCadCliRes.AutoSize = true;
            this.lbDataCadCliRes.Enabled = false;
            this.lbDataCadCliRes.Location = new System.Drawing.Point(373, 24);
            this.lbDataCadCliRes.Name = "lbDataCadCliRes";
            this.lbDataCadCliRes.Size = new System.Drawing.Size(0, 15);
            this.lbDataCadCliRes.TabIndex = 3;
            // 
            // lbCamposObrig
            // 
            this.lbCamposObrig.AutoSize = true;
            this.lbCamposObrig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamposObrig.Location = new System.Drawing.Point(33, 453);
            this.lbCamposObrig.Name = "lbCamposObrig";
            this.lbCamposObrig.Size = new System.Drawing.Size(263, 17);
            this.lbCamposObrig.TabIndex = 10;
            this.lbCamposObrig.Text = "Campos com o símbolo \"*\" são obrigatórios.";
            // 
            // btExcluirCli
            // 
            this.btExcluirCli.Enabled = false;
            this.btExcluirCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCli.Image = global::LojaInformatica.Properties.Resources.Prancheta_17;
            this.btExcluirCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirCli.Location = new System.Drawing.Point(248, 486);
            this.btExcluirCli.Name = "btExcluirCli";
            this.btExcluirCli.Size = new System.Drawing.Size(80, 25);
            this.btExcluirCli.TabIndex = 14;
            this.btExcluirCli.Text = "Excluir";
            this.btExcluirCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirCli.UseVisualStyleBackColor = true;
            this.btExcluirCli.Click += new System.EventHandler(this.btExcluirCli_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btExcluirCli);
            this.Controls.Add(this.lbCamposObrig);
            this.Controls.Add(this.lbDataCadCliRes);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.btAtualizarCli);
            this.Controls.Add(this.ckbStatusAtivo);
            this.Controls.Add(this.btFecharCli);
            this.Controls.Add(this.btCadastrarCli);
            this.Controls.Add(this.lbDataCadCli);
            this.Controls.Add(this.lbStatusCli);
            this.Controls.Add(this.lbCodigoCli);
            this.Controls.Add(this.gbDadosPessoaisCli);
            this.Controls.Add(this.gbEnderecoCli);
            this.Controls.Add(this.gbContatoCli);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCliente_KeyDown);
            this.gbDadosPessoaisCli.ResumeLayout(false);
            this.gbDadosPessoaisCli.PerformLayout();
            this.gbEnderecoCli.ResumeLayout(false);
            this.gbEnderecoCli.PerformLayout();
            this.gbContatoCli.ResumeLayout(false);
            this.gbContatoCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoCli;
        private System.Windows.Forms.Label lbNomeCli;
        private System.Windows.Forms.Label lbStatusCli;
        private System.Windows.Forms.Label lbSexoCli;
        private System.Windows.Forms.Label lbCpfCli;
        private System.Windows.Forms.Label lbRuaCli;
        private System.Windows.Forms.Label lbNumeroCli;
        private System.Windows.Forms.Label lbComplementoCli;
        private System.Windows.Forms.Label lbBairroCli;
        private System.Windows.Forms.Label lbCidadeCli;
        private System.Windows.Forms.Label lbEstadoCli;
        private System.Windows.Forms.Label lbDataCadCli;
        private System.Windows.Forms.Label lbTelComCli;
        private System.Windows.Forms.Label lbTelResCli;
        private System.Windows.Forms.Label lbCelCli;
        private System.Windows.Forms.Label lbDataNascCli;
        private System.Windows.Forms.Label lbSobrenomeCli;
        private System.Windows.Forms.GroupBox gbDadosPessoaisCli;
        private System.Windows.Forms.GroupBox gbEnderecoCli;
        private System.Windows.Forms.Label lbEmailCli;
        private System.Windows.Forms.GroupBox gbContatoCli;
        private System.Windows.Forms.Button btCadastrarCli;
        private System.Windows.Forms.Button btFecharCli;
        private System.Windows.Forms.Label lbCepCli;
        private System.Windows.Forms.Button btAtualizarCli;
        private System.Windows.Forms.Label lbTelAtencao;
        private System.Windows.Forms.Label lbCamposObrig;
        private System.Windows.Forms.Button btConsultaCEP;
        public System.Windows.Forms.TextBox txtSobrenomeCli;
        public System.Windows.Forms.TextBox txtNomeCli;
        public System.Windows.Forms.TextBox txtBairroCli;
        public System.Windows.Forms.TextBox txtCidadeCli;
        public System.Windows.Forms.TextBox txtComplementoCli;
        public System.Windows.Forms.TextBox txtNumeroCli;
        public System.Windows.Forms.TextBox txtRuaCli;
        public System.Windows.Forms.TextBox txtEmailCli;
        public System.Windows.Forms.RadioButton rbMasculinoCli;
        public System.Windows.Forms.RadioButton rbFemininoCli;
        public System.Windows.Forms.ComboBox cbEstadoCli;
        public System.Windows.Forms.CheckBox ckbStatusAtivo;
        public System.Windows.Forms.MaskedTextBox mtxtDataNascCli;
        public System.Windows.Forms.MaskedTextBox mtxtCpfCli;
        public System.Windows.Forms.MaskedTextBox mtxtTelComCli;
        public System.Windows.Forms.MaskedTextBox mtxtCelCli;
        public System.Windows.Forms.MaskedTextBox mtxtTelResCli;
        public System.Windows.Forms.TextBox txtCodCli;
        public System.Windows.Forms.Label lbDataCadCliRes;
        public System.Windows.Forms.MaskedTextBox mtxtCepCli;
        private System.Windows.Forms.Button btExcluirCli;
    }
}