namespace LojaInformatica
{
    partial class FormCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            this.btAtualizarCargo = new System.Windows.Forms.Button();
            this.btFecharCargo = new System.Windows.Forms.Button();
            this.btCadastrarCargo = new System.Windows.Forms.Button();
            this.gbCadCargo = new System.Windows.Forms.GroupBox();
            this.txtNomeCargo = new System.Windows.Forms.TextBox();
            this.lbNomeCargo = new System.Windows.Forms.Label();
            this.lbDataCadCargoRes = new System.Windows.Forms.Label();
            this.ckbStatusAtivo = new System.Windows.Forms.CheckBox();
            this.lbDataCadCargo = new System.Windows.Forms.Label();
            this.lbStatusCargo = new System.Windows.Forms.Label();
            this.lbCodigoCargo = new System.Windows.Forms.Label();
            this.btExcluirCargo = new System.Windows.Forms.Button();
            this.gbCadCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Enabled = false;
            this.txtCodCargo.Location = new System.Drawing.Point(85, 34);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(30, 20);
            this.txtCodCargo.TabIndex = 40;
            // 
            // btAtualizarCargo
            // 
            this.btAtualizarCargo.Enabled = false;
            this.btAtualizarCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCargo.Image = global::LojaInformatica.Properties.Resources.Prancheta_19;
            this.btAtualizarCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarCargo.Location = new System.Drawing.Point(393, 105);
            this.btAtualizarCargo.Name = "btAtualizarCargo";
            this.btAtualizarCargo.Size = new System.Drawing.Size(80, 25);
            this.btAtualizarCargo.TabIndex = 38;
            this.btAtualizarCargo.Text = "Atualizar";
            this.btAtualizarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarCargo.UseVisualStyleBackColor = true;
            this.btAtualizarCargo.Click += new System.EventHandler(this.btAtualizarCargo_Click);
            // 
            // btFecharCargo
            // 
            this.btFecharCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCargo.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btFecharCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFecharCargo.Location = new System.Drawing.Point(393, 163);
            this.btFecharCargo.Name = "btFecharCargo";
            this.btFecharCargo.Size = new System.Drawing.Size(80, 25);
            this.btFecharCargo.TabIndex = 39;
            this.btFecharCargo.Text = "Fechar";
            this.btFecharCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFecharCargo.UseVisualStyleBackColor = true;
            this.btFecharCargo.Click += new System.EventHandler(this.btFecharCargo_Click);
            // 
            // btCadastrarCargo
            // 
            this.btCadastrarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadastrarCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCargo.Image = global::LojaInformatica.Properties.Resources.Prancheta_14;
            this.btCadastrarCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrarCargo.Location = new System.Drawing.Point(393, 76);
            this.btCadastrarCargo.Name = "btCadastrarCargo";
            this.btCadastrarCargo.Size = new System.Drawing.Size(80, 25);
            this.btCadastrarCargo.TabIndex = 37;
            this.btCadastrarCargo.Text = "Cadastrar";
            this.btCadastrarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarCargo.UseVisualStyleBackColor = true;
            this.btCadastrarCargo.Click += new System.EventHandler(this.btCadastrarCargo_Click);
            // 
            // gbCadCargo
            // 
            this.gbCadCargo.Controls.Add(this.txtNomeCargo);
            this.gbCadCargo.Controls.Add(this.lbNomeCargo);
            this.gbCadCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadCargo.Location = new System.Drawing.Point(26, 107);
            this.gbCadCargo.Name = "gbCadCargo";
            this.gbCadCargo.Size = new System.Drawing.Size(284, 80);
            this.gbCadCargo.TabIndex = 36;
            this.gbCadCargo.TabStop = false;
            this.gbCadCargo.Text = "Inserção de Dados";
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCargo.Location = new System.Drawing.Point(127, 35);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(137, 23);
            this.txtNomeCargo.TabIndex = 1;
            this.txtNomeCargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCargo_KeyDown);
            this.txtNomeCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCargo_KeyPress);
            // 
            // lbNomeCargo
            // 
            this.lbNomeCargo.AutoSize = true;
            this.lbNomeCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCargo.Location = new System.Drawing.Point(6, 38);
            this.lbNomeCargo.Name = "lbNomeCargo";
            this.lbNomeCargo.Size = new System.Drawing.Size(115, 15);
            this.lbNomeCargo.TabIndex = 0;
            this.lbNomeCargo.Text = "Nome da  Categoria:";
            // 
            // lbDataCadCargoRes
            // 
            this.lbDataCadCargoRes.AutoSize = true;
            this.lbDataCadCargoRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadCargoRes.Location = new System.Drawing.Point(236, 38);
            this.lbDataCadCargoRes.Name = "lbDataCadCargoRes";
            this.lbDataCadCargoRes.Size = new System.Drawing.Size(65, 15);
            this.lbDataCadCargoRes.TabIndex = 35;
            this.lbDataCadCargoRes.Text = "13/11/2018";
            // 
            // ckbStatusAtivo
            // 
            this.ckbStatusAtivo.AutoSize = true;
            this.ckbStatusAtivo.Enabled = false;
            this.ckbStatusAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatusAtivo.Location = new System.Drawing.Point(414, 34);
            this.ckbStatusAtivo.Name = "ckbStatusAtivo";
            this.ckbStatusAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbStatusAtivo.TabIndex = 33;
            this.ckbStatusAtivo.Text = "Ativo";
            this.ckbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // lbDataCadCargo
            // 
            this.lbDataCadCargo.AutoSize = true;
            this.lbDataCadCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadCargo.Location = new System.Drawing.Point(121, 37);
            this.lbDataCadCargo.Name = "lbDataCadCargo";
            this.lbDataCadCargo.Size = new System.Drawing.Size(118, 17);
            this.lbDataCadCargo.TabIndex = 31;
            this.lbDataCadCargo.Text = "Data de Cadastro:";
            // 
            // lbStatusCargo
            // 
            this.lbStatusCargo.AutoSize = true;
            this.lbStatusCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusCargo.Location = new System.Drawing.Point(358, 34);
            this.lbStatusCargo.Name = "lbStatusCargo";
            this.lbStatusCargo.Size = new System.Drawing.Size(50, 17);
            this.lbStatusCargo.TabIndex = 32;
            this.lbStatusCargo.Text = "Status:";
            // 
            // lbCodigoCargo
            // 
            this.lbCodigoCargo.AutoSize = true;
            this.lbCodigoCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCargo.Location = new System.Drawing.Point(23, 37);
            this.lbCodigoCargo.Name = "lbCodigoCargo";
            this.lbCodigoCargo.Size = new System.Drawing.Size(56, 17);
            this.lbCodigoCargo.TabIndex = 30;
            this.lbCodigoCargo.Text = "Código:";
            // 
            // btExcluirCargo
            // 
            this.btExcluirCargo.Enabled = false;
            this.btExcluirCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCargo.Image = global::LojaInformatica.Properties.Resources.Prancheta_17;
            this.btExcluirCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirCargo.Location = new System.Drawing.Point(393, 134);
            this.btExcluirCargo.Name = "btExcluirCargo";
            this.btExcluirCargo.Size = new System.Drawing.Size(80, 25);
            this.btExcluirCargo.TabIndex = 41;
            this.btExcluirCargo.Text = "Excluir";
            this.btExcluirCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirCargo.UseVisualStyleBackColor = true;
            this.btExcluirCargo.Click += new System.EventHandler(this.btExcluirCargo_Click);
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btExcluirCargo);
            this.Controls.Add(this.txtCodCargo);
            this.Controls.Add(this.btAtualizarCargo);
            this.Controls.Add(this.btFecharCargo);
            this.Controls.Add(this.btCadastrarCargo);
            this.Controls.Add(this.gbCadCargo);
            this.Controls.Add(this.lbDataCadCargoRes);
            this.Controls.Add(this.ckbStatusAtivo);
            this.Controls.Add(this.lbDataCadCargo);
            this.Controls.Add(this.lbStatusCargo);
            this.Controls.Add(this.lbCodigoCargo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            this.gbCadCargo.ResumeLayout(false);
            this.gbCadCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAtualizarCargo;
        private System.Windows.Forms.Button btFecharCargo;
        private System.Windows.Forms.Button btCadastrarCargo;
        private System.Windows.Forms.GroupBox gbCadCargo;
        private System.Windows.Forms.Label lbNomeCargo;
        private System.Windows.Forms.Label lbDataCadCargo;
        private System.Windows.Forms.Label lbStatusCargo;
        private System.Windows.Forms.Label lbCodigoCargo;
        private System.Windows.Forms.Button btExcluirCargo;
        public System.Windows.Forms.TextBox txtCodCargo;
        public System.Windows.Forms.TextBox txtNomeCargo;
        public System.Windows.Forms.Label lbDataCadCargoRes;
        public System.Windows.Forms.CheckBox ckbStatusAtivo;
    }
}