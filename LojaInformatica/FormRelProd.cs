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
    public partial class FormRelProd : Form
    {
        public FormRelProd()
        {
            InitializeComponent();
        }

        private void FormRelProd_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Marca");
            cbTipoRel.Items.Add("Preço");
            cbTipoRel.Items.Add("Qt. em Estoque");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO DE CATEGORIA DO BANCO DE DADOS - TABELA CLIENTE
            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCategoria.DisplayMember = "nome_categ"; // EXIBIR NA COMBO (Categoria)
            cbCategoria.ValueMember = "cod_categ"; // GUARDAR NO BD (Categoria)
            cbCategoria.SelectedIndex = -1;
            this.rptvProduto.RefreshReport();

            //CARREGAR COMBO DE MARCA DO BANCO DE DADOS - TABELA CLIENTE
            classMarca cMarca = new classMarca();
            cbMarca.DataSource = cMarca.BuscarMarca(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbMarca.DisplayMember = "nome_marca"; // EXIBIR NA COMBO (Marca)
            cbMarca.ValueMember = "cod_marca"; // GUARDAR NO BD (Marca)
            cbMarca.SelectedIndex = -1;
            this.rptvProduto.RefreshReport();

            //Status Sempre Ativo
            rbtAtivo.Checked = true;


        }


        //Método de Limpeza
        private void Limpar()
        {
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            txtEstoque1.Text = "";
            txtEstoque2.Text = "";
            txtPreco1.Text = "";
            txtPreco2.Text = "";
            rptvProduto.Clear();
        }


        //Configuração combo
        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipoRel.SelectedIndex == 0) //Categoria
            {
                gbCategoria.Enabled = true;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbQtEstoque.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }


            if (cbTipoRel.SelectedIndex == 1) //Marca
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = true;
                gbPreco.Enabled = false;
                gbQtEstoque.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 2) //Preço
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = true;
                gbQtEstoque.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 3) //Qt. em Estoque
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbQtEstoque.Enabled = true;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 4) //Status
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbQtEstoque.Enabled = false;
                gbStatus.Enabled = true;
                Limpar();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //Para pegar a opção escolhida pelo usuário

            switch (pesquisa)
            {
                case "Categoria":
                    if (cbCategoria.SelectedIndex != -1)
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdCateg(Convert.ToInt32(cbCategoria.SelectedValue));
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Marca":
                    if (cbMarca.SelectedIndex != -1)
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdMarca(Convert.ToInt32(cbMarca.SelectedValue));
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Preço":
                    if (txtPreco1.Text != "" || txtPreco2.Text != "")
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdPreco(Convert.ToDecimal(txtPreco1.Text), Convert.ToDecimal(txtPreco2.Text));
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Qt. em Estoque":
                    if (txtEstoque1.Text != "" || txtEstoque2.Text != "")
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdQtEstoque(Convert.ToInt32(txtEstoque1.Text), Convert.ToInt32(txtEstoque2.Text));
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Status":
                    if (rbtAtivo.Checked == true)
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdStatus(1);
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProdStatus(0);
                        this.rptvProduto.RefreshReport();
                    }
                    break;
            }
        }

        private void txtPreco1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPreco2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

