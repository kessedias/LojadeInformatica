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
    public partial class FormConsultaProd : Form
    {
        public FormConsultaProd()
        {
            InitializeComponent();
        }
             

        private void FormConsultaProd_Load(object sender, EventArgs e)
        {

            cbCategorias.Items.Add("Nome");
            cbCategorias.Items.Add("Marca");
            cbCategorias.Items.Add("Categoria");
            cbCategorias.Items.Add("Status");
            cbCategorias.Items.Add("Preço");

            cbCategorias.SelectedItem = "Nome";

            rbContem.Checked = true;

            //Carregar Combo Categoria
            classCategoria cCategoria = new classCategoria();
            cbCategoriaProd.DataSource = cCategoria.BuscarCategoria();//Executar Met. na classe categoria
            cbCategoriaProd.DisplayMember = "nome_categ";//Exibir na combo(Nome)
            cbCategoriaProd.ValueMember = "cod_categ"; //guardar no bd(código)
            cbCategoriaProd.SelectedIndex = -1; //Limpar a combo(não selecionar nada)


            //Carregar Combo Marca
            classMarca cMarca = new classMarca();
            cbMarcaProd.DataSource = cMarca.BuscarMarca();
            cbMarcaProd.DisplayMember = "nome_marca";
            cbMarcaProd.ValueMember = "cod_marca";
            cbMarcaProd.SelectedIndex = -1;
          

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCategorias.SelectedIndex == 0) //Nome
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                gbPrecoCon.Enabled = false;
                cbCategoriaProd.Enabled = false;
                cbMarcaProd.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 1) //Marca
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbPrecoCon.Enabled = false;
                cbMarcaProd.Enabled = true;
                cbCategoriaProd.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 2) //Categoria
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbPrecoCon.Enabled = false;
                cbCategoriaProd.Enabled = true;
                cbMarcaProd.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 3) //Status
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                gbPrecoCon.Enabled = false;
                cbCategoriaProd.Enabled = false;
                cbMarcaProd.Enabled = false;
            }

            if (cbCategorias.SelectedIndex == 4) //Preço
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbPrecoCon.Enabled = true;
                cbCategoriaProd.Enabled = false;
                cbMarcaProd.Enabled = false;
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = null;
            txtPesquisar.Text = "";
            txtPrecoUm.Text = "";
            txtPrecoDois.Text = "";
            cbMarcaProd.SelectedIndex = -1;
            cbCategoriaProd.SelectedIndex = -1;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbCategorias.SelectedItem.ToString();
            classProduto cProduto = new classProduto();

            switch (Consulta)
            {
                case "Nome":
                    //INicial
                    if (txtPesquisar.Text != "")
                    {
                        if (rbinicial.Checked == true)
                        {
                            dgvProduto.DataSource = cProduto.BuscarProdutoNomeInicial(txtPesquisar.Text);
                            this.dgvProduto.Columns[0].Visible = false;
                        }
                        //Contém
                        else
                        {
                            dgvProduto.DataSource = cProduto.BuscarProdutoNomeContem(txtPesquisar.Text);
                            this.dgvProduto.Columns[0].Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Favor informar um Produto válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                //Marca
                 case "Marca":
                     if (cbMarcaProd.SelectedIndex == -1)
                     {
                         MessageBox.Show("Favor selecionar uma Marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     }
                     else
                     {
                        dgvProduto.DataSource = cProduto.BuscarProdutoMarca(Convert.ToInt32(cbMarcaProd.SelectedValue));
                        this.dgvProduto.Columns[0].Visible = false;
                    }
                     break;
                     

                //Categoria
                 case "Categoria":
                     if (cbCategoriaProd.SelectedIndex == -1)
                     {
                         MessageBox.Show("Favor selecionar uma Categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     }
                     else
                     {                      
                        dgvProduto.DataSource = cProduto.BuscarProdutoCategoria(Convert.ToInt32(cbCategoriaProd.SelectedValue));
                        this.dgvProduto.Columns[0].Visible = false;
                    }
                     break;
                     

                //Status
                case "Status":
                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        MessageBox.Show("Favor selecionar uma das Opções.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (rbAtivo.Checked == true)
                        {
                            dgvProduto.DataSource = cProduto.BuscarProdutoStatus(1);
                            this.dgvProduto.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvProduto.DataSource = cProduto.BuscarProdutoStatus(0);
                            this.dgvProduto.Columns[0].Visible = false;
                        }
                    }
                    break;

                //Preço
                case "Preço":                  
                    if(txtPrecoUm.Text == "" || txtPrecoDois.Text == "")
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvProduto.DataSource = cProduto.BuscarProdutoPreco(Convert.ToDecimal(txtPrecoUm.Text),(Convert.ToDecimal(txtPrecoDois.Text)));
                        this.dgvProduto.Columns[0].Visible = false;

                    }
                    break;
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o Produto selecionado?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar a classe Produto
                classProduto cProduto = new classProduto();

                //Instanciar o form de cadastro/atualização de Produto
                FormProduto fProduto = new FormProduto();

                //Atualização = Título
                fProduto.Text = "Atualização de Produto";

                //Pegar o código do Produto selecionado pelo usuário na grid
                cProduto.ConsultarProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

                //Passar os dados do BD para os Controles do Form de Produto
                fProduto.txtCodProd.Text = cProduto.cod_prod.ToString();
                fProduto.datacad = cProduto.data_cad_prod;
                fProduto.txtDescricaoProd.Text = cProduto.descricao_prod.ToString();
                fProduto.txtCustoProd.Text = cProduto.custo_prod.ToString();
                fProduto.txtLucroProd.Text = cProduto.lucro_prod.ToString();
                fProduto.txtPrecoProd.Text = cProduto.preco_prod.ToString();
                fProduto.txtQtEstoque.Text = cProduto.qt_estoque_prod.ToString();
                fProduto.categ = cProduto.cod_categ.ToString();
                fProduto.marca = cProduto.cod_marca.ToString();
                


                if (cProduto.status_prod == 1)
                {
                    fProduto.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fProduto.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fProduto.tipo = "Atualização";
                //Depois de Atualizar fecha o Formulário
                fProduto.ShowDialog();
                //Chamar Método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void txtPrecoUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtPrecoUm.Focus();
            }
        }

        private void txtPrecoDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtPrecoDois.Focus();
            }
        }
    }
}
