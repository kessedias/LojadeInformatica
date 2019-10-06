namespace LojaInformatica
{
    partial class FormCategoria
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
            this.btAtualizarCateg = new System.Windows.Forms.Button();
            this.btFecharCateg = new System.Windows.Forms.Button();
            this.btCadastrarCateg = new System.Windows.Forms.Button();
            this.gbCadCateg = new System.Windows.Forms.GroupBox();
            this.txtNomeCateg = new System.Windows.Forms.TextBox();
            this.lbNomeCateg = new System.Windows.Forms.Label();
            this.lbDataCadCategRes = new System.Windows.Forms.Label();
            this.ckbStatusAtivo = new System.Windows.Forms.CheckBox();
            this.lbDataCadMarca = new System.Windows.Forms.Label();
            this.lbStatusCateg = new System.Windows.Forms.Label();
            this.lbCodigoCateg = new System.Windows.Forms.Label();
            this.txtCodCateg = new System.Windows.Forms.TextBox();
            this.btExcluirCateg = new System.Windows.Forms.Button();
            this.gbCadCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAtualizarCateg
            // 
            this.btAtualizarCateg.Enabled = false;
            this.btAtualizarCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCateg.Image = global::LojaInformatica.Properties.Resources.Prancheta_19;
            this.btAtualizarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarCateg.Location = new System.Drawing.Point(382, 109);
            this.btAtualizarCateg.Name = "btAtualizarCateg";
            this.btAtualizarCateg.Size = new System.Drawing.Size(80, 25);
            this.btAtualizarCateg.TabIndex = 27;
            this.btAtualizarCateg.Text = "Atualizar";
            this.btAtualizarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarCateg.UseVisualStyleBackColor = true;
            this.btAtualizarCateg.Click += new System.EventHandler(this.btAtualizarCateg_Click);
            // 
            // btFecharCateg
            // 
            this.btFecharCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCateg.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btFecharCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFecharCateg.Location = new System.Drawing.Point(382, 167);
            this.btFecharCateg.Name = "btFecharCateg";
            this.btFecharCateg.Size = new System.Drawing.Size(80, 25);
            this.btFecharCateg.TabIndex = 28;
            this.btFecharCateg.Text = "Fechar";
            this.btFecharCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFecharCateg.UseVisualStyleBackColor = true;
            this.btFecharCateg.Click += new System.EventHandler(this.btFecharCateg_Click);
            // 
            // btCadastrarCateg
            // 
            this.btCadastrarCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCateg.Image = global::LojaInformatica.Properties.Resources.Prancheta_14;
            this.btCadastrarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrarCateg.Location = new System.Drawing.Point(382, 80);
            this.btCadastrarCateg.Name = "btCadastrarCateg";
            this.btCadastrarCateg.Size = new System.Drawing.Size(80, 25);
            this.btCadastrarCateg.TabIndex = 26;
            this.btCadastrarCateg.Text = "Cadastrar";
            this.btCadastrarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarCateg.UseVisualStyleBackColor = true;
            this.btCadastrarCateg.Click += new System.EventHandler(this.btCadastrarCateg_Click);
            // 
            // gbCadCateg
            // 
            this.gbCadCateg.Controls.Add(this.txtNomeCateg);
            this.gbCadCateg.Controls.Add(this.lbNomeCateg);
            this.gbCadCateg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadCateg.Location = new System.Drawing.Point(26, 108);
            this.gbCadCateg.Name = "gbCadCateg";
            this.gbCadCateg.Size = new System.Drawing.Size(284, 80);
            this.gbCadCateg.TabIndex = 25;
            this.gbCadCateg.TabStop = false;
            this.gbCadCateg.Text = "Inserção de Dados";
            // 
            // txtNomeCateg
            // 
            this.txtNomeCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCateg.Location = new System.Drawing.Point(127, 35);
            this.txtNomeCateg.Name = "txtNomeCateg";
            this.txtNomeCateg.Size = new System.Drawing.Size(137, 23);
            this.txtNomeCateg.TabIndex = 1;
            this.txtNomeCateg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCateg_KeyDown);
            this.txtNomeCateg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCateg_KeyPress);
            // 
            // lbNomeCateg
            // 
            this.lbNomeCateg.AutoSize = true;
            this.lbNomeCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCateg.Location = new System.Drawing.Point(6, 38);
            this.lbNomeCateg.Name = "lbNomeCateg";
            this.lbNomeCateg.Size = new System.Drawing.Size(115, 15);
            this.lbNomeCateg.TabIndex = 0;
            this.lbNomeCateg.Text = "Nome da  Categoria:";
            // 
            // lbDataCadCategRes
            // 
            this.lbDataCadCategRes.AutoSize = true;
            this.lbDataCadCategRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadCategRes.Location = new System.Drawing.Point(236, 40);
            this.lbDataCadCategRes.Name = "lbDataCadCategRes";
            this.lbDataCadCategRes.Size = new System.Drawing.Size(65, 15);
            this.lbDataCadCategRes.TabIndex = 24;
            this.lbDataCadCategRes.Text = "13/11/2018";
            // 
            // ckbStatusAtivo
            // 
            this.ckbStatusAtivo.AutoSize = true;
            this.ckbStatusAtivo.Enabled = false;
            this.ckbStatusAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatusAtivo.Location = new System.Drawing.Point(412, 40);
            this.ckbStatusAtivo.Name = "ckbStatusAtivo";
            this.ckbStatusAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbStatusAtivo.TabIndex = 22;
            this.ckbStatusAtivo.Text = "Ativo";
            this.ckbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // lbDataCadMarca
            // 
            this.lbDataCadMarca.AutoSize = true;
            this.lbDataCadMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadMarca.Location = new System.Drawing.Point(121, 39);
            this.lbDataCadMarca.Name = "lbDataCadMarca";
            this.lbDataCadMarca.Size = new System.Drawing.Size(118, 17);
            this.lbDataCadMarca.TabIndex = 20;
            this.lbDataCadMarca.Text = "Data de Cadastro:";
            // 
            // lbStatusCateg
            // 
            this.lbStatusCateg.AutoSize = true;
            this.lbStatusCateg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusCateg.Location = new System.Drawing.Point(356, 39);
            this.lbStatusCateg.Name = "lbStatusCateg";
            this.lbStatusCateg.Size = new System.Drawing.Size(50, 17);
            this.lbStatusCateg.TabIndex = 21;
            this.lbStatusCateg.Text = "Status:";
            // 
            // lbCodigoCateg
            // 
            this.lbCodigoCateg.AutoSize = true;
            this.lbCodigoCateg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCateg.Location = new System.Drawing.Point(23, 38);
            this.lbCodigoCateg.Name = "lbCodigoCateg";
            this.lbCodigoCateg.Size = new System.Drawing.Size(56, 17);
            this.lbCodigoCateg.TabIndex = 18;
            this.lbCodigoCateg.Text = "Código:";
            // 
            // txtCodCateg
            // 
            this.txtCodCateg.Enabled = false;
            this.txtCodCateg.Location = new System.Drawing.Point(85, 35);
            this.txtCodCateg.Name = "txtCodCateg";
            this.txtCodCateg.Size = new System.Drawing.Size(30, 20);
            this.txtCodCateg.TabIndex = 29;
            // 
            // btExcluirCateg
            // 
            this.btExcluirCateg.Enabled = false;
            this.btExcluirCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCateg.Image = global::LojaInformatica.Properties.Resources.Prancheta_17;
            this.btExcluirCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirCateg.Location = new System.Drawing.Point(382, 138);
            this.btExcluirCateg.Name = "btExcluirCateg";
            this.btExcluirCateg.Size = new System.Drawing.Size(80, 25);
            this.btExcluirCateg.TabIndex = 30;
            this.btExcluirCateg.Text = "Excluir";
            this.btExcluirCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirCateg.UseVisualStyleBackColor = true;
            this.btExcluirCateg.Click += new System.EventHandler(this.btExcluirCateg_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btExcluirCateg);
            this.Controls.Add(this.txtCodCateg);
            this.Controls.Add(this.btAtualizarCateg);
            this.Controls.Add(this.btFecharCateg);
            this.Controls.Add(this.btCadastrarCateg);
            this.Controls.Add(this.gbCadCateg);
            this.Controls.Add(this.lbDataCadCategRes);
            this.Controls.Add(this.ckbStatusAtivo);
            this.Controls.Add(this.lbDataCadMarca);
            this.Controls.Add(this.lbStatusCateg);
            this.Controls.Add(this.lbCodigoCateg);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.gbCadCateg.ResumeLayout(false);
            this.gbCadCateg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtualizarCateg;
        private System.Windows.Forms.Button btFecharCateg;
        private System.Windows.Forms.Button btCadastrarCateg;
        private System.Windows.Forms.GroupBox gbCadCateg;
        private System.Windows.Forms.Label lbNomeCateg;
        private System.Windows.Forms.Label lbDataCadMarca;
        private System.Windows.Forms.Label lbStatusCateg;
        private System.Windows.Forms.Label lbCodigoCateg;
        private System.Windows.Forms.Button btExcluirCateg;
        public System.Windows.Forms.TextBox txtNomeCateg;
        public System.Windows.Forms.Label lbDataCadCategRes;
        public System.Windows.Forms.CheckBox ckbStatusAtivo;
        public System.Windows.Forms.TextBox txtCodCateg;
    }
}