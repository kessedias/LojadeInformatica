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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void tsClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Clientes já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormCliente FrmCliente = new FormCliente();
                FrmCliente.MdiParent = this;
                FrmCliente.Show();
                FrmCliente.ckbStatusAtivo.Checked = true;
                FrmCliente.MaximizeBox = false;
                FrmCliente.MinimizeBox = false;
                FrmCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsProdutos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Produtos já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormProduto FrmProduto = new FormProduto();
                FrmProduto.MdiParent = this;
                FrmProduto.Show();
                FrmProduto.MaximizeBox = false;
                FrmProduto.MinimizeBox = false;
                FrmProduto.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        //Botão Sair do FORM Principal
        private void tsSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?",
                    "Menu Principal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
                Application.Exit();
        }

        //Funcção para carregar hora e data no rodapé do FORM Principal
        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToShortDateString();
            lbHora.Text = DateTime.Now.ToShortTimeString();
        }


        private void tsMarcas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Marcas já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormMarca FrmMarca = new FormMarca();
                FrmMarca.MdiParent = this;
                FrmMarca.Show();
                FrmMarca.MaximizeBox = false;
                FrmMarca.MinimizeBox = false;
                FrmMarca.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsCateg_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Categorias já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormCategoria FrmCategoria = new FormCategoria();
                FrmCategoria.MdiParent = this;
                FrmCategoria.Show();
                FrmCategoria.MaximizeBox = false;
                FrmCategoria.MinimizeBox = false;
                FrmCategoria.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsCargos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Cargos já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormCargo FrmCargo = new FormCargo();
                FrmCargo.MdiParent = this;
                FrmCargo.Show();
                FrmCargo.MaximizeBox = false;
                FrmCargo.MinimizeBox = false;
                FrmCargo.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Funcionários já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormFuncionario FrmFuncionario = new FormFuncionario();
                FrmFuncionario.MdiParent = this;
                FrmFuncionario.Show();
                FrmFuncionario.ckbStatusAtivo.Checked = true;
                FrmFuncionario.MaximizeBox = false;
                FrmFuncionario.MinimizeBox = false;
                FrmFuncionario.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsConsultasClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Clientes já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaCli FrmConsultaCli = new FormConsultaCli();
                FrmConsultaCli.MdiParent = this;
                FrmConsultaCli.Show();
                FrmConsultaCli.MaximizeBox = false;
                FrmConsultaCli.MinimizeBox = false;
                FrmConsultaCli.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Funcionários já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaFunc FrmConsultaFunc = new FormConsultaFunc();
                FrmConsultaFunc.MdiParent = this;
                FrmConsultaFunc.Show();
                FrmConsultaFunc.MaximizeBox = false;
                FrmConsultaFunc.MinimizeBox = false;
                FrmConsultaFunc.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsConsultaCargos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Cargos já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaCargo FrmConsultaCargo = new FormConsultaCargo();
                FrmConsultaCargo.MdiParent = this;
                FrmConsultaCargo.Show();
                FrmConsultaCargo.MaximizeBox = false;
                FrmConsultaCargo.MinimizeBox = false;
                FrmConsultaCargo.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsConsultaProdutos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Produtos já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaProd FrmConsultaProd = new FormConsultaProd();
                FrmConsultaProd.MdiParent = this;
                FrmConsultaProd.Show();
                FrmConsultaProd.MaximizeBox = false;
                FrmConsultaProd.MinimizeBox = false;
                FrmConsultaProd.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsConsultaMarcas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Marcas já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaMarca FrmConsultaMarca = new FormConsultaMarca();
                FrmConsultaMarca.MdiParent = this;
                FrmConsultaMarca.Show();
                FrmConsultaMarca.MaximizeBox = false;
                FrmConsultaMarca.MinimizeBox = false;
                FrmConsultaMarca.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsConsultaCategorias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Categorias já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormConsultaCateg FrmConsultaCateg = new FormConsultaCateg();
                FrmConsultaCateg.MdiParent = this;
                FrmConsultaCateg.Show();
                FrmConsultaCateg.MaximizeBox = false;
                FrmConsultaCateg.MinimizeBox = false;
                FrmConsultaCateg.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelMarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório de Marcas já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelMarca FrmRelMarca = new FormRelMarca();
                FrmRelMarca.MdiParent = this;
                FrmRelMarca.Show();
                FrmRelMarca.MaximizeBox = false;
                FrmRelMarca.MinimizeBox = false;
                FrmRelMarca.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório de Clientes já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelCliente FrmClientes = new FormRelCliente();
                FrmClientes.MdiParent = this;
                FrmClientes.Show();
                FrmClientes.MaximizeBox = false;
                FrmClientes.MinimizeBox = false;
                FrmClientes.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelProd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório de Produtos já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelProd FrmRelProd = new FormRelProd();
                FrmRelProd.MdiParent = this;
                FrmRelProd.Show();
                FrmRelProd.MaximizeBox = false;
                FrmRelProd.MinimizeBox = false;
                FrmRelProd.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelFunc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório de Funcionários já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelFunc FrmRelFunc = new FormRelFunc();
                FrmRelFunc.MdiParent = this;
                FrmRelFunc.Show();
                FrmRelFunc.MaximizeBox = false;
                FrmRelFunc.MinimizeBox = false;
                FrmRelFunc.FormBorderStyle = FormBorderStyle.FixedSingle;

            }
        }


        private void tsCadVenda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Vendas já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormVenda FrmVenda = new FormVenda();
                FrmVenda.MdiParent = this;
                FrmVenda.Show();
                FrmVenda.MaximizeBox = false;
                FrmVenda.MinimizeBox = false;
                FrmVenda.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelSimples_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório de Vendas já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelVendaSim FrmRelVendaSim = new FormRelVendaSim();
                FrmRelVendaSim.MdiParent = this;
                FrmRelVendaSim.Show();
                FrmRelVendaSim.MaximizeBox = false;
                FrmRelVendaSim.MinimizeBox = false;
                FrmRelVendaSim.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }


        private void tsRelDetalhe_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Relatório Detalhado de Vendas  já está aberto!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormRelVendaDet FrmRelVendaDet = new FormRelVendaDet();
                FrmRelVendaDet.MdiParent = this;
                FrmRelVendaDet.Show();
                FrmRelVendaDet.MaximizeBox = false;
                FrmRelVendaDet.MinimizeBox = false;
                FrmRelVendaDet.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }
    }
}
