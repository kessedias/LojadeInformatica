namespace LojaInformatica
{
    partial class FormMarca
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
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.ckbStatusAtivo = new System.Windows.Forms.CheckBox();
            this.lbDataCadMarca = new System.Windows.Forms.Label();
            this.lbStatusMarca = new System.Windows.Forms.Label();
            this.lbCodigoMarca = new System.Windows.Forms.Label();
            this.lbDataCadMarcaRes = new System.Windows.Forms.Label();
            this.gbCadMarca = new System.Windows.Forms.GroupBox();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.lbNomeMarca = new System.Windows.Forms.Label();
            this.btAtualizarMarca = new System.Windows.Forms.Button();
            this.btFecharMarca = new System.Windows.Forms.Button();
            this.btCadastrarMarca = new System.Windows.Forms.Button();
            this.btExcluirMarca = new System.Windows.Forms.Button();
            this.gbCadMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Enabled = false;
            this.txtCodMarca.Location = new System.Drawing.Point(84, 26);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(30, 23);
            this.txtCodMarca.TabIndex = 8;
            // 
            // ckbStatusAtivo
            // 
            this.ckbStatusAtivo.AutoSize = true;
            this.ckbStatusAtivo.Enabled = false;
            this.ckbStatusAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatusAtivo.Location = new System.Drawing.Point(413, 32);
            this.ckbStatusAtivo.Name = "ckbStatusAtivo";
            this.ckbStatusAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbStatusAtivo.TabIndex = 11;
            this.ckbStatusAtivo.Text = "Ativo";
            this.ckbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // lbDataCadMarca
            // 
            this.lbDataCadMarca.AutoSize = true;
            this.lbDataCadMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadMarca.Location = new System.Drawing.Point(120, 32);
            this.lbDataCadMarca.Name = "lbDataCadMarca";
            this.lbDataCadMarca.Size = new System.Drawing.Size(118, 17);
            this.lbDataCadMarca.TabIndex = 9;
            this.lbDataCadMarca.Text = "Data de Cadastro:";
            // 
            // lbStatusMarca
            // 
            this.lbStatusMarca.AutoSize = true;
            this.lbStatusMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusMarca.Location = new System.Drawing.Point(354, 31);
            this.lbStatusMarca.Name = "lbStatusMarca";
            this.lbStatusMarca.Size = new System.Drawing.Size(50, 17);
            this.lbStatusMarca.TabIndex = 10;
            this.lbStatusMarca.Text = "Status:";
            // 
            // lbCodigoMarca
            // 
            this.lbCodigoMarca.AutoSize = true;
            this.lbCodigoMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoMarca.Location = new System.Drawing.Point(22, 32);
            this.lbCodigoMarca.Name = "lbCodigoMarca";
            this.lbCodigoMarca.Size = new System.Drawing.Size(56, 17);
            this.lbCodigoMarca.TabIndex = 7;
            this.lbCodigoMarca.Text = "Código:";
            // 
            // lbDataCadMarcaRes
            // 
            this.lbDataCadMarcaRes.AutoSize = true;
            this.lbDataCadMarcaRes.Location = new System.Drawing.Point(235, 33);
            this.lbDataCadMarcaRes.Name = "lbDataCadMarcaRes";
            this.lbDataCadMarcaRes.Size = new System.Drawing.Size(65, 15);
            this.lbDataCadMarcaRes.TabIndex = 13;
            this.lbDataCadMarcaRes.Text = "13/11/2018";
            // 
            // gbCadMarca
            // 
            this.gbCadMarca.Controls.Add(this.txtNomeMarca);
            this.gbCadMarca.Controls.Add(this.lbNomeMarca);
            this.gbCadMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadMarca.Location = new System.Drawing.Point(25, 102);
            this.gbCadMarca.Name = "gbCadMarca";
            this.gbCadMarca.Size = new System.Drawing.Size(284, 80);
            this.gbCadMarca.TabIndex = 14;
            this.gbCadMarca.TabStop = false;
            this.gbCadMarca.Text = "Inserção de Dados";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMarca.Location = new System.Drawing.Point(107, 35);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(137, 23);
            this.txtNomeMarca.TabIndex = 1;
            this.txtNomeMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeMarca_KeyDown);
            this.txtNomeMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeMarca_KeyPress);
            // 
            // lbNomeMarca
            // 
            this.lbNomeMarca.AutoSize = true;
            this.lbNomeMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeMarca.Location = new System.Drawing.Point(6, 38);
            this.lbNomeMarca.Name = "lbNomeMarca";
            this.lbNomeMarca.Size = new System.Drawing.Size(95, 15);
            this.lbNomeMarca.TabIndex = 0;
            this.lbNomeMarca.Text = "Nome da Marca:";
            // 
            // btAtualizarMarca
            // 
            this.btAtualizarMarca.Enabled = false;
            this.btAtualizarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarMarca.Image = global::LojaInformatica.Properties.Resources.Prancheta_19;
            this.btAtualizarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarMarca.Location = new System.Drawing.Point(392, 101);
            this.btAtualizarMarca.Name = "btAtualizarMarca";
            this.btAtualizarMarca.Size = new System.Drawing.Size(80, 25);
            this.btAtualizarMarca.TabIndex = 16;
            this.btAtualizarMarca.Text = "Atualizar";
            this.btAtualizarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarMarca.UseVisualStyleBackColor = true;
            this.btAtualizarMarca.Click += new System.EventHandler(this.btAtualizarMarca_Click);
            // 
            // btFecharMarca
            // 
            this.btFecharMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharMarca.Image = global::LojaInformatica.Properties.Resources.Prancheta_23;
            this.btFecharMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFecharMarca.Location = new System.Drawing.Point(392, 159);
            this.btFecharMarca.Name = "btFecharMarca";
            this.btFecharMarca.Size = new System.Drawing.Size(80, 25);
            this.btFecharMarca.TabIndex = 17;
            this.btFecharMarca.Text = "Fechar";
            this.btFecharMarca.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btFecharMarca.UseVisualStyleBackColor = true;
            this.btFecharMarca.Click += new System.EventHandler(this.btFecharMarca_Click);
            // 
            // btCadastrarMarca
            // 
            this.btCadastrarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMarca.Image = global::LojaInformatica.Properties.Resources.Prancheta_14;
            this.btCadastrarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrarMarca.Location = new System.Drawing.Point(392, 72);
            this.btCadastrarMarca.Name = "btCadastrarMarca";
            this.btCadastrarMarca.Size = new System.Drawing.Size(80, 25);
            this.btCadastrarMarca.TabIndex = 15;
            this.btCadastrarMarca.Text = "Cadastrar";
            this.btCadastrarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarMarca.UseVisualStyleBackColor = true;
            this.btCadastrarMarca.Click += new System.EventHandler(this.btCadastrarMarca_Click);
            // 
            // btExcluirMarca
            // 
            this.btExcluirMarca.Enabled = false;
            this.btExcluirMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirMarca.Image = global::LojaInformatica.Properties.Resources.Prancheta_17;
            this.btExcluirMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirMarca.Location = new System.Drawing.Point(392, 130);
            this.btExcluirMarca.Name = "btExcluirMarca";
            this.btExcluirMarca.Size = new System.Drawing.Size(80, 25);
            this.btExcluirMarca.TabIndex = 18;
            this.btExcluirMarca.Text = "Excluir";
            this.btExcluirMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirMarca.UseVisualStyleBackColor = true;
            this.btExcluirMarca.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btExcluirMarca);
            this.Controls.Add(this.btAtualizarMarca);
            this.Controls.Add(this.btFecharMarca);
            this.Controls.Add(this.btCadastrarMarca);
            this.Controls.Add(this.gbCadMarca);
            this.Controls.Add(this.lbDataCadMarcaRes);
            this.Controls.Add(this.txtCodMarca);
            this.Controls.Add(this.ckbStatusAtivo);
            this.Controls.Add(this.lbDataCadMarca);
            this.Controls.Add(this.lbStatusMarca);
            this.Controls.Add(this.lbCodigoMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Marca";
            this.Load += new System.EventHandler(this.FormMarca_Load);
            this.gbCadMarca.ResumeLayout(false);
            this.gbCadMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDataCadMarca;
        private System.Windows.Forms.Label lbStatusMarca;
        private System.Windows.Forms.Label lbCodigoMarca;
        private System.Windows.Forms.GroupBox gbCadMarca;
        private System.Windows.Forms.Label lbNomeMarca;
        private System.Windows.Forms.Button btAtualizarMarca;
        private System.Windows.Forms.Button btFecharMarca;
        private System.Windows.Forms.Button btCadastrarMarca;
        private System.Windows.Forms.Button btExcluirMarca;
        public System.Windows.Forms.TextBox txtCodMarca;
        public System.Windows.Forms.CheckBox ckbStatusAtivo;
        public System.Windows.Forms.Label lbDataCadMarcaRes;
        public System.Windows.Forms.TextBox txtNomeMarca;
    }
}