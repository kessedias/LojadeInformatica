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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

        }

        //Método Limpar
        private void Limpar()
        {
            rbNome.Checked = false;
            rbFuncao.Checked = false;
            rbCpf.Checked = false;
            rbStatus.Checked = false;
            rbSexo.Checked = false;
            rbPrecoProd.Checked = false;
            rbMarcaProd.Checked = false;
            rbCategoria.Checked = false;
        }


        //GroupBox Consultas
        private void rbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFuncionario.Checked == true) //radioButton Funcionário
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = true;
                rbCpf.Enabled = true;
                rbStatus.Enabled = true;
                rbSexo.Enabled = true;
                rbPrecoProd.Enabled = false;
                rbMarcaProd.Enabled = false;
                rbCategoriaProd.Enabled = false;                     
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFuncionario.Checked == true) //radioButton Cliente
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = true;
                rbCpf.Enabled = true;
                rbStatus.Enabled = true;
                rbSexo.Enabled = true;
                rbPrecoProd.Enabled = false;
                rbMarcaProd.Enabled = false;
                rbCategoriaProd.Enabled = false;
            }
        }

        private void rbMarca_CheckedChanged(object sender, EventArgs e) //radioButton Marca
        {
            if (rbMarca.Checked == true)
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = false;
                rbCpf.Enabled = false;
                rbStatus.Enabled = true;
                rbSexo.Enabled = false;
                rbPrecoProd.Enabled = false;
                rbMarcaProd.Enabled = false;
                rbCategoriaProd.Enabled = false;
            }
        }

        private void rbVenda_CheckedChanged(object sender, EventArgs e) //radioButton Venda
        {

        }

        private void rbCargo_CheckedChanged(object sender, EventArgs e) //radioButton Cargo
        {
            if (rbCargo.Checked == true)
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = false;
                rbCpf.Enabled = false;
                rbStatus.Enabled = true;
                rbSexo.Enabled = false;
                rbPrecoProd.Enabled = false;
                rbMarcaProd.Enabled = false;
                rbCategoriaProd.Enabled = false;
            }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e) //radioButton Produto
        {
            if (rbProduto.Checked == true)
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = false;
                rbCpf.Enabled = false;
                rbStatus.Enabled = true;
                rbSexo.Enabled = false;
                rbPrecoProd.Enabled = true;
                rbMarcaProd.Enabled = true;
                rbCategoriaProd.Enabled = true;
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e) //radioButton Categoria
        {
            if (rbCategoria.Checked == true)
            {
                //Limpar
                this.Limpar();

                rbNome.Enabled = true;
                rbFuncao.Enabled = false;
                rbCpf.Enabled = false;
                rbStatus.Enabled = true;
                rbSexo.Enabled = false;
                rbPrecoProd.Enabled = false;
                rbMarcaProd.Enabled = false;
                rbCategoriaProd.Enabled = false;
            }
        }

        private void rbRelatorio_CheckedChanged(object sender, EventArgs e) //radioButton Relatório
        {

        }

        // ---------------------------------------//--------------------------------------------------//

        
            //GroupBox Tipos de Consultas
        private void rbNome_CheckedChanged(object sender, EventArgs e) //radioButton Nome
        {
            if (rbNome.Checked == true)
            {
                gbStatus.Enabled = false;
                gbCaracteres.Enabled = true;
                txtPesquisa.Enabled = true;
                txtPesquisa.Focus();
            }
        }

        private void rbFuncao_CheckedChanged(object sender, EventArgs e) //radioButton Cargo Funcionário
        {
            if (rbFuncao.Checked == true)
            {
                gbStatus.Enabled = false;
                gbCaracteres.Enabled = false;
                txtPesquisa.Enabled = true;
                txtPesquisa.Focus();
            }
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e) //radioButton CPF
        {
            gbStatus.Enabled = false;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e) //radioButton Status
        {
            gbStatus.Enabled = true;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = false;
        }

        private void rbSexo_CheckedChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void rbPrecoProd_CheckedChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void rbMarcaProd_CheckedChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void rbCategoriaProd_CheckedChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            gbCaracteres.Enabled = false;
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
