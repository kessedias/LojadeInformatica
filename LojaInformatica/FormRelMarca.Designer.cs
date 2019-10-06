namespace LojaInformatica
{
    partial class FormRelMarca
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptvMarca = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classMarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classMarcaBindingSource
            // 
            this.classMarcaBindingSource.DataSource = typeof(LojaInformatica.classMarca);
            // 
            // rptvMarca
            // 
            this.rptvMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMarca";
            reportDataSource1.Value = this.classMarcaBindingSource;
            this.rptvMarca.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvMarca.LocalReport.ReportEmbeddedResource = "LojaInformatica.rptRelMarca.rdlc";
            this.rptvMarca.Location = new System.Drawing.Point(0, 0);
            this.rptvMarca.Name = "rptvMarca";
            this.rptvMarca.Size = new System.Drawing.Size(544, 457);
            this.rptvMarca.TabIndex = 0;
            // 
            // FormRelMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 457);
            this.Controls.Add(this.rptvMarca);
            this.Name = "FormRelMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Marcas";
            this.Load += new System.EventHandler(this.FormRelMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classMarcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvMarca;
        private System.Windows.Forms.BindingSource classMarcaBindingSource;
    }
}