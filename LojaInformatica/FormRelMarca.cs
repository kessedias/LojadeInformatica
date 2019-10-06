using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica
{
    public partial class FormRelMarca : Form
    {
        public FormRelMarca()
        {
            InitializeComponent();
        }

        private void FormRelMarca_Load(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();
            classMarcaBindingSource.DataSource = cMarca.RelMarca();
            this.rptvMarca.RefreshReport();
        }
    }
}
