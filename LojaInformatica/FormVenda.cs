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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }
        //Lista Itens da venda
        private List<classItensVendidos> ListaItensVenda = new List<classItensVendidos>();

        //Variável para calcular valor total da venda
        private decimal VendaTotal = 0;

        //Variáel para contar quantos produtos foram adicionados na lista
        private int itensVenda = 0;

        private void FormVenda_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO DE Funcionario DO BANCO DE DADOS - TABELA FUNCIONARIO
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarNomeFuncionario(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE F
            cbFuncionario.DisplayMember = "nome"; // EXIBIR NA COMBO (Funcionario)
            cbFuncionario.ValueMember = "cod_func"; // GUARDAR NO BD (Funcionario)
            cbFuncionario.SelectedIndex = -1;

            //Carregar Combo Forma de Pagamento
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Crediário");
        }

        
        //Método para Limpar os Campos do FORMVENDA, quando finalizado
        private void Limpeza()
        {
            ListaItensVenda.Clear();
            AtualizarGrid();
            dgvItens.Refresh();
            VendaTotal = 0;

            txtValorDesconto.Text = "";
            txtTotalDesconto.Text = "";
            txtTotalVenda.Text = "";
            txtQtdeItens.Text = "";
            txtValor.Text = "";
            txtProduto.Text = "";
            txtQtdeEstoque.Text = "";

            txtValorTotal.Clear();
            cbFuncionario.SelectedIndex = -1;
            cbFormaPagamento.SelectedIndex = -1;
            dgvCliente.DataSource = null;
            dgvProduto.DataSource = null;
            txtPesqCliente.Clear();
            txtPesqProduto.Clear();
            txtQtde.Enabled = false;
            txtValorDesconto.Enabled = false;

            lbAviso.ForeColor = Color.Black;
            lbNomeFunc.ForeColor = Color.Black;
            gbPesquisaCli.ForeColor = Color.Black;
            gbPesquisaProd.ForeColor = Color.Black;
            gbListaVenda.ForeColor = Color.Black;
        }
            

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqCliente.Text))
            {
                MessageBox.Show("Favor informar um Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                classCliente cCliente = new classCliente();
                dgvCliente.DataSource = cCliente.BuscarCliente(txtPesqCliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqProduto.Text))
            {
                MessageBox.Show("Favor informar um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                classProduto cProduto = new classProduto();
                dgvProduto.DataSource = cProduto.BuscarProduto(txtPesqProduto.Text);
                
            }
        }


        //Calcular valor total de acordo com a quantidade e o valor unitário do produto
        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text == "" || txtQtde.Text == "00")
            {
                MessageBox.Show("Favor informar uma quantidade", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
            }

            int qtvendida = Convert.ToInt32(txtQtde.Text);
            int qtdeestoque = Convert.ToInt32(txtQtdeEstoque.Text);

            //Verificar se a quantidade vendida é maior que a quantidade em estoque
            if (qtvendida > qtdeestoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é de " + qtdeestoque + " unidades!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
            }
            else
            {
                qtvendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtvendida * valor).ToString();              
            }
        }


        //Clicar na gird de produtos e mandar para os text do formulário de cadastro de venda
        //Usando o evento CellClick (Pode clicar em qualquer lugar da grid, não só no conteúdo (Texto))
        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQtde.Enabled = true;
            classProduto cProduto = new classProduto();
            bool aux = cProduto.BuscarProdutoCod((int)dgvProduto.SelectedRows[0].Cells[0].Value);

            if (aux)
            {
                txtProduto.Text = cProduto.descricao_prod;
                txtQtdeEstoque.Text = cProduto.qt_estoque_prod.ToString();
                txtValor.Text = cProduto.preco_prod.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }
        }
        //Calcular o Desconto do produto
        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                txtTotalVenda.Text = valor.ToString("n2");
                txtTotalDesconto.Text = "0,00";
            }
            else
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = Convert.ToDecimal(txtValorDesconto.Text);
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");
            }
        }

        
        //Criar a grid que vai receber os produtos que serão adicionados na lista

        private void AtualizarGrid()
        {
            //Adiciona na grid a partir da lista
            classProduto cProduto = new classProduto();
            DataTable dt = new DataTable();

            //Criar as colunas na grid
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Preço"));

            //Adicionar as linhas da grid
            foreach (classItensVendidos item in ListaItensVenda)
            {
                dt.Rows.Add(item.cod_prod, cProduto.BuscaNomeProd(item.cod_prod), item.qt_vendida, item.preco_venda);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;
        }

        //Botão Adicionar Produto
        private void btAddProduto_Click(object sender, EventArgs e)
        {
            classItensVendidos cItensVendidos = new classItensVendidos();
            decimal vTotal = 0;

            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtQtdeEstoque.Text == "0")
                {
                    MessageBox.Show("Não há estoque para esse Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Liberar o Botão de Desconto
                    txtValorDesconto.Enabled = true;

                    //Somando os itens da lista para o valor total
                    vTotal = Convert.ToDecimal(txtTotal.Text);
                    VendaTotal = VendaTotal + vTotal;
                    txtValorTotal.Text = VendaTotal.ToString("");

                    //Contar os itens da venda
                    itensVenda++;

                    //Controle das informações dos itens da venda (Produtos vendidos)
                    cItensVendidos.cod_prod = (int)(dgvProduto.SelectedRows[0].Cells[0].Value);
                    cItensVendidos.preco_venda = Convert.ToDecimal(txtTotal.Text);
                    cItensVendidos.qt_vendida = Convert.ToInt32(txtQtde.Text);

                    //Adiciona produtos na lista
                    ListaItensVenda.Add(cItensVendidos);


                    //Pegar da lista a quantidade de itens (produtos vendidos)
                    txtQtdeItens.Text = itensVenda.ToString();
                    txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                    //Atualizar Grid
                    AtualizarGrid();

                    //Limpar os campos após adicionar o item na lista
                    txtValorDesconto.Text = "0";
                    txtValorDesconto_TextChanged(this, new EventArgs());
                    txtValorDesconto.Select();
                    txtProduto.Clear();
                    txtQtde.Text = "01";
                    txtQtdeEstoque.Clear();
                    txtValorDesconto.Clear();
                    txtTotal.Clear();
                }
            }
        }

        //Método Atualiza Estoque
        private void AtualizaEstoque(int qtde, int cod)
        {
            classProduto cProduto = new classProduto();
            cProduto.BuscarProdutoCod(cod);
            int estoque = cProduto.qt_estoque_prod;
            cProduto.AtualizarQtEstoque(estoque - qtde, cod);
        }

        //Fechamento da Venda
        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.Text != "" && dgvCliente.DataSource != null && txtPesqProduto.Text != "" && dgvItens.DataSource != null && cbFormaPagamento.Text != "")
            {
                classVenda cVenda = new classVenda();
                cVenda.cod_cli = (int)(dgvCliente.SelectedRows[0].Cells[0].Value);
                cVenda.cod_func = (int)(cbFuncionario.SelectedValue);
                cVenda.preco_total_vend = Convert.ToDecimal(txtTotalVenda.Text);
                cVenda.forma_pag_vend = cbFormaPagamento.SelectedItem.ToString();
                cVenda.desconto_vend = Convert.ToDecimal(txtTotalDesconto.Text);
                cVenda.preco_vend = Convert.ToDecimal(txtValorTotal.Text);

                bool aux = cVenda.CadastrarVenda();

                if (aux)
                {
                    foreach (classItensVendidos item in ListaItensVenda)
                    {
                        item.cod_vend = cVenda.cod_vend; //PK Venda e FK ItensVendidos
                        aux = item.CadastrarItensVendidos();

                        //Atualizar o Estoque
                        AtualizaEstoque(item.qt_vendida, item.cod_prod);                       
                    }
                    if (aux)
                    {
                        MessageBox.Show("Venda Cadastrada com Sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpeza();
                    }                    
                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Venda", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos necessários", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbAviso.ForeColor = Color.DarkRed;
                lbNomeFunc.ForeColor = Color.DarkRed;
                gbPesquisaCli.ForeColor = Color.DarkRed;
                gbPesquisaProd.ForeColor = Color.DarkRed;
                gbListaVenda.ForeColor = Color.DarkRed;               
            }
        }


        //Apenas números na txt
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Apenas números
                e.Handled = true;
            }
        }


        //Apenas números na txt
        private void txtValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Apenas números
                e.Handled = true;
            }
        }


        //Botão remover Produto
        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                //subtrair o valor para ter o valor pos substituir o item da lista
                decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                VendaTotal = VendaTotal - valor;
                txtTotalVenda.Text = VendaTotal.ToString("n2");
                txtValorTotal.Text = VendaTotal.ToString("n2");

                //remover da lista e atualiza a grid
                ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                AtualizarGrid();
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                txtProduto.Clear();
                txtQtdeEstoque.Clear();
                txtValorDesconto_TextChanged(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Não há itens para ser removido.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }      
    }
}
