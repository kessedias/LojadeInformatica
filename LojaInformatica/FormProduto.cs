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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        public string tipo, marca, categ;
        public DateTime datacad;

        private void btFecharProd_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Método Limpar
        private void LimparProduto()
        {
            //dentro dos campos
            txtCustoProd.BackColor = Color.White;
            txtDescricaoProd.BackColor = Color.White;
            txtLucroProd.BackColor = Color.White;
            txtPrecoProd.BackColor = Color.White;
            txtQtEstoque.BackColor = Color.White;
            cbCategoriaProd.BackColor = Color.White;
            cbMarcaProd.BackColor = Color.White;
            txtMargem.BackColor = Color.White;

            //campos
            txtDescricaoProd.Text = "";
            txtCustoProd.Text = "";
            txtLucroProd.Text = "";
            txtPrecoProd.Text = "";
            txtQtEstoque.Text = "";
            txtMargem.Text = "";
            cbCategoriaProd.SelectedIndex = -1;
            cbMarcaProd.SelectedIndex = -1;
        }


        private void btCadastrarProd_Click(object sender, EventArgs e)
        {
            //Instanciar ClassMarca
            classProduto cProduto = new classProduto();

            if (txtCustoProd.Text == "" || txtDescricaoProd.Text == "" || txtLucroProd.Text == "" || txtPrecoProd.Text == "" || txtQtEstoque.Text == "")
            {
                MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustoProd.BackColor = Color.MistyRose;
                txtDescricaoProd.BackColor = Color.MistyRose;
                txtLucroProd.BackColor = Color.MistyRose;
                txtPrecoProd.BackColor = Color.MistyRose;
                txtQtEstoque.BackColor = Color.MistyRose;
                cbCategoriaProd.BackColor = Color.MistyRose;
                cbMarcaProd.BackColor = Color.MistyRose;
                txtMargem.BackColor = Color.MistyRose;
            }
            else
            {
                //Passar os dados
                cProduto.descricao_prod = txtDescricaoProd.Text;
                cProduto.custo_prod = Convert.ToDecimal(txtCustoProd.Text);
                cProduto.lucro_prod = Convert.ToDecimal(txtLucroProd.Text);
                cProduto.preco_prod = Convert.ToDecimal(txtPrecoProd.Text);
                cProduto.qt_estoque_prod = Convert.ToInt32(txtQtEstoque.Text);
                cProduto.cod_marca = Convert.ToInt32(cbMarcaProd.SelectedValue);
                cProduto.cod_categ = Convert.ToInt32(cbCategoriaProd.SelectedValue);

                // Chamar o método da classe cliente para fazer o cadastro
                int aux = cProduto.CadastrarProduto();

                //Se der certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" O Produto " + cProduto.descricao_prod + " foi Cadastrado com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpar campos do formulário, chamando o método Limpar
                    this.LimparProduto();


                }
                //Se der errado = 0
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.",
                        "Sistema Loja de Informática",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        //Funções no carregamento do FORM
        private void FormProduto_Load(object sender, EventArgs e)
        {
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


            //Carregar


            //Aparecer Data no início do FORM
            lbDataCadProdRes.Text = DateTime.Now.ToShortDateString();

            //Quando Abrir o Form para Atualizar ou excluir
            if (tipo == "Atualização")
            {
                btCadastrarProd.Enabled = false;
                ckbStatusAtivo.Enabled = true;
                lbDataCadProdRes.Text = datacad.ToString();
                cbCategoriaProd.SelectedValue = categ;
                cbMarcaProd.SelectedValue = marca;
                btAtualizarProd.Enabled = true;
                btExcluir.Enabled = true;
            }
            else
            {
                btAtualizarProd.Enabled = false;
                btExcluir.Enabled = false;
            }


        }
        //Validação Campos Númericos que usam vírgula
        private void txtCustoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtCustoProd.Focus();
            }
        }

        private void txtLucroProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtLucroProd.Focus();
            }
        }

        private void txtPrecoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtPrecoProd.Focus();
            }
        }

        //Validação, apenas usando números no campo
        private void txtQtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Apenas números
                e.Handled = true;
                txtQtEstoque.Focus();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Produto?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classProduto cProduto = new classProduto();
                cProduto.cod_prod = Convert.ToInt32(txtCodProd.Text);

                bool aux = cProduto.ExcluirProduto();

                if (aux)
                {
                    MessageBox.Show("Produto " + cProduto.descricao_prod + " excluído com sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Produto não pode ser excluído, há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btAtualizarProd_Click(object sender, EventArgs e)
        {
            //Instanciar ClassMarca
            classProduto cProduto = new classProduto();

            if (txtCustoProd.Text == "" || txtDescricaoProd.Text == "" || txtLucroProd.Text == "" || txtPrecoProd.Text == "" || txtQtEstoque.Text == "")
            {
                MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustoProd.BackColor = Color.MistyRose;
                txtDescricaoProd.BackColor = Color.MistyRose;
                txtLucroProd.BackColor = Color.MistyRose;
                txtPrecoProd.BackColor = Color.MistyRose;
                txtQtEstoque.BackColor = Color.MistyRose;
                cbCategoriaProd.BackColor = Color.MistyRose;
                cbMarcaProd.BackColor = Color.MistyRose;
                txtMargem.BackColor = Color.MistyRose;
            }
            else
            {
                //Passar os dados
                cProduto.descricao_prod = txtDescricaoProd.Text;
                cProduto.custo_prod = Convert.ToDecimal(txtCustoProd.Text);
                cProduto.lucro_prod = Convert.ToDecimal(txtLucroProd.Text);
                cProduto.preco_prod = Convert.ToDecimal(txtPrecoProd.Text);
                cProduto.qt_estoque_prod = Convert.ToInt32(txtQtEstoque.Text);
                cProduto.cod_marca = Convert.ToInt32(cbMarcaProd.SelectedValue);
                cProduto.cod_categ = Convert.ToInt32(cbCategoriaProd.SelectedValue);

                if (ckbStatusAtivo.Checked == true)
                {
                    cProduto.status_prod = 1;
                }
                else
                {
                    if (ckbStatusAtivo.Checked == false)
                    {
                        cProduto.status_prod = 0;
                    }

                }

                //Status Produto
                if (cProduto.status_prod == 0)
                {
                    ckbStatusAtivo.Checked = false;
                }
                else
                {
                    if (cProduto.status_prod == 1)
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                    else
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                }
                //Método Atualizar
                cProduto.cod_prod = Convert.ToInt32(txtCodProd.Text);

                bool aux = cProduto.AtualizarProduto();

                if (aux)
                {
                    MessageBox.Show("Produto: " + cProduto.descricao_prod + " Atualizado com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        //Keypress só números
        private void txtMargem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Apenas números
                e.Handled = true;
            }
        }

        private void txtCustoProd_TextChanged(object sender, EventArgs e)
        {
            decimal custo, lucro;
            int margem;

            if (txtMargem.Text != "" && txtCustoProd.Text != "")

            {
                margem = Convert.ToInt32(txtMargem.Text);
                custo = Convert.ToDecimal(txtCustoProd.Text);
                lucro = (custo * margem) / 100;
                txtLucroProd.Text = Convert.ToString(lucro);
                txtPrecoProd.Text = Convert.ToString(custo + lucro);
            }
            else
            {
                if (txtCustoProd.Text == "")
                {
                    txtPrecoProd.Text = ""; txtLucroProd.Text = "";
                }
            }
        }


        //Criando um cálculo que associe os campos(custo,lucro e preço)
        private void txtMargem_TextChanged(object sender, EventArgs e)
        {
            decimal custo, lucro;
            int margem;

            if (txtMargem.Text != "" && txtCustoProd.Text != "")

            {
                margem = Convert.ToInt32(txtMargem.Text);
                custo = Convert.ToDecimal(txtCustoProd.Text);
                lucro = (custo * margem) / 100;
                txtLucroProd.Text = Convert.ToString(lucro);
                txtPrecoProd.Text = Convert.ToString(custo + lucro);
            }
            else
            {
                if (txtMargem.Text == "")
                {
                    txtPrecoProd.Text = ""; txtLucroProd.Text = "";
                }
            }
        }   


        //Começar o campo com a primeira letra Maiúscula
        private void txtDescricaoProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDescricaoProd.Text.Length > 0)
            {
                txtDescricaoProd.Text = txtDescricaoProd.Text.Substring(0, 1).ToUpper() + txtDescricaoProd.Text.Substring(1);
                txtDescricaoProd.SelectionStart = txtDescricaoProd.Text.Length + 1;
            }
        }
    }
}

