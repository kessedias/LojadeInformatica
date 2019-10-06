using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classProduto
    {
        public classProduto()
        {
            cod_prod = 0;
            status_prod = 0;
            data_cad_prod = DateTime.Now;
            descricao_prod = null;
            qt_estoque_prod = 0;
            preco_prod = 0;
            custo_prod = 0;
            lucro_prod = 0;
            cod_categ = 0;
            cod_marca = 0;
        }

        //Fazendo as Propriedades
        public int cod_prod { get; set; }
        public int status_prod { get; set; }
        public DateTime data_cad_prod { get; set; }
        public string descricao_prod { get; set; }
        public int qt_estoque_prod { get; set; }
        public decimal preco_prod { get; set; }
        public decimal custo_prod { get; set; }
        public decimal lucro_prod { get; set; }
        public int cod_categ { get; set; }
        public int cod_marca { get; set; }

        public int CadastrarProduto()
        {
            string query = "insert into produto values(0, 1, now(), '" + descricao_prod + "', '" + qt_estoque_prod + "', '" + preco_prod.ToString().Replace(",",".")+"', '"+custo_prod.ToString().Replace(",",".")+"', '"+lucro_prod.ToString().Replace(",", ".") + "', '"+cod_categ+"', '"+cod_marca+"')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarProduto()
        {
            string query = "select cod_prod, descricao_prod, qt_estoque_prod, preco_prod, from produto where status_prod = 1 order by descricao_prod";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de pesquisa de Produto por Nome, Status e Data

        //Pesquisa de Produto por Nome(Inicial)
        public DataTable BuscarProdutoNomeInicial(string nomei)
        {
            string query = "SELECT cod_prod 'Cod', descricao_prod 'Descritivo', qt_estoque_prod 'Qt. Estoque', preco_prod 'Preco' from produto where descricao_prod like '" + nomei + "%' and status_prod = 1 ORDER by descricao_prod";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Produto por Nome(Contem)
        public DataTable BuscarProdutoNomeContem(string contem)
        {
            string query = "SELECT cod_prod 'Cod', descricao_prod 'Descritivo', qt_estoque_prod 'Qt. Estoque', preco_prod 'Preco' from produto where descricao_prod like '%" + contem + "%' and status_prod = 1 ORDER by descricao_prod";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Produto por Status(status)
        public DataTable BuscarProdutoStatus(int status)
        {
            string query = "SELECT cod_prod 'Cod', descricao_prod 'Descritivo', qt_estoque_prod 'Qt. Estoque', preco_prod 'Preco' from produto where status_prod = " + status + " ORDER by descricao_prod";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar Produto pela Marca
        public DataTable BuscarProdutoMarca(int marca)
        {
            string query = "SELECT produto.cod_prod 'Cod', produto.descricao_prod 'Descritivo', marca.nome_marca 'Marca' from produto JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status_prod = 1 and marca.cod_marca = " + marca;
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar Produto pela Categoria
        public DataTable BuscarProdutoCategoria(int categoria)
        {
            string query = "SELECT produto.cod_prod 'Cod', produto.descricao_prod 'Descritivo', categoria.nome_categ 'Categoria' from produto JOIN categoria ON categoria.cod_categ = produto.cod_categ WHERE produto.status_prod = 1 and categoria.cod_categ = " + categoria;
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar Produto pelo Preço
        public DataTable BuscarProdutoPreco(decimal preco1, decimal preco2)
        {
            string query = "select cod_prod 'Cod', preco_prod 'Preco', descricao_prod 'Descritivo' FROM produto where preco_prod BETWEEN '"+preco1.ToString().Replace(",", ".") + "' and '"+preco2.ToString().Replace(",", ".")+"'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método ára buscar os dados do banco quando o usuário escolhe o cliente na grid

        public bool ConsultarProduto(int cod)
        {
            string query = "select * from produto where cod_prod =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_prod = Convert.ToInt32(dt.Rows[0]["cod_prod"]);
                data_cad_prod = Convert.ToDateTime(dt.Rows[0]["data_cad_prod"]);               
                status_prod = Convert.ToInt32(dt.Rows[0]["status_prod"]);
                descricao_prod = dt.Rows[0]["descricao_prod"].ToString();
                qt_estoque_prod = Convert.ToInt32(dt.Rows[0]["qt_estoque_prod"]);
                custo_prod = Convert.ToDecimal(dt.Rows[0]["custo_prod"]);
                lucro_prod = Convert.ToDecimal(dt.Rows[0]["lucro_prod"]);
                preco_prod = Convert.ToDecimal(dt.Rows[0]["preco_prod"]);
                cod_categ = Convert.ToInt32(dt.Rows[0]["cod_categ"]);
                cod_marca = Convert.ToInt32(dt.Rows[0]["cod_marca"]);                

                return true;
            }
            else
                return false;
        }

        //Método Atualizar Produto
        public bool AtualizarProduto()
        {
            string query = "update produto set descricao_prod = '" + descricao_prod + "', qt_estoque_prod = "+ qt_estoque_prod +", custo_prod = '"+custo_prod.ToString().Replace(",", ".") + "', preco_prod = '"+preco_prod.ToString().Replace(",", ".") + "', lucro_prod = '"+lucro_prod.ToString().Replace(",", ".") + "', cod_marca = "+cod_marca+", cod_categ = "+cod_categ+", status_prod =" + status_prod + " where cod_prod = " + cod_prod;

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        public bool ExcluirProduto()
        {
            string query = "delete from produto where cod_prod = " + cod_prod;

            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }


        //Método de Pesquisa por marca
        public DataTable RelProdMarca(int marca)
        {
            string query = "select categoria.nome_categ 'cod_categ', marca.nome_marca 'cod_marca', produto.descricao_prod, produto.qt_estoque_prod, produto.preco_prod FROM produto JOIN marca on produto.cod_marca = marca.cod_marca JOIN categoria on produto.cod_categ = categoria.cod_categ WHERE produto.status_prod = 1 and marca.cod_marca = "+marca+ " ORDER By marca.nome_marca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa por categoria
        public DataTable RelProdCateg(int categ)
        {
            string query = "select categoria.nome_categ 'cod_categ', marca.nome_marca 'cod_marca', produto.descricao_prod, produto.qt_estoque_prod, produto.preco_prod FROM produto JOIN marca on produto.cod_marca = marca.cod_marca JOIN categoria on produto.cod_categ = categoria.cod_categ WHERE produto.status_prod = 1 and categoria.cod_categ = " + categ + " ORDER By categoria.nome_categ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa por Preço
        public DataTable RelProdPreco(decimal preco1, decimal preco2)
        {
            string query = "select categoria.nome_categ 'cod_categ', marca.nome_marca 'cod_marca', produto.descricao_prod, produto.qt_estoque_prod, produto.preco_prod FROM produto JOIN marca on produto.cod_marca = marca.cod_marca JOIN categoria on produto.cod_categ = categoria.cod_categ WHERE produto.status_prod = 1 and produto.preco_prod BETWEEN " + preco1.ToString().Replace(",", ".") + " and " + preco2.ToString().Replace(",", ".") + " ORDER By produto.preco_prod";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa por Qt. Estoque
        public DataTable RelProdQtEstoque(int estoque1, int estoque2)
        {
            string query = "select categoria.nome_categ 'cod_categ', marca.nome_marca 'cod_marca', produto.descricao_prod, produto.qt_estoque_prod, produto.preco_prod FROM produto JOIN marca on produto.cod_marca = marca.cod_marca JOIN categoria on produto.cod_categ = categoria.cod_categ WHERE produto.status_prod = 1 and produto.qt_estoque_prod BETWEEN " + estoque1 + " and " + estoque2 + " ORDER By produto.qt_estoque_prod";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de Pesquisa por Status
        public DataTable RelProdStatus(int status)
        {
            string query = "select categoria.nome_categ 'cod_categ', marca.nome_marca 'cod_marca', produto.descricao_prod, produto.qt_estoque_prod, produto.preco_prod FROM produto JOIN marca on produto.cod_marca = marca.cod_marca JOIN categoria on produto.cod_categ = categoria.cod_categ WHERE produto.status_prod = " + status+" ORDER By categoria.nome_categ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Buscar Produto - Venda 
        public DataTable BuscarProduto(string prod)
        { 
            string query = "select produto.cod_prod 'Cod', produto.descricao_prod 'Descritivo', marca.nome_marca 'Marca', produto.qt_estoque_prod 'Qt. Estoque', produto.preco_prod 'Custo' from produto JOIN categoria on produto.cod_categ = categoria.cod_categ join marca on produto.cod_marca = marca.cod_marca where produto.status_prod = 1 AND produto.descricao_prod LIKE '%"+prod+"%' ORDER by produto.descricao_prod";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método usado para quando clicar na grid de produtos no formulário de vendas,
        //carregar as informações do produto (nome, preço, qt. estoque) nos text box

        public bool BuscarProdutoCod(int cod)
        {
            string query = "select descricao_prod, preco_prod, qt_estoque_prod from produto where cod_prod = " + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count >= 0)
            {
                descricao_prod = (string)dt.Rows[0]["descricao_prod"];
                preco_prod = (decimal)dt.Rows[0]["preco_prod"];
                qt_estoque_prod = (int)dt.Rows[0]["qt_estoque_prod"];
                return true;
            }
            else
                return false;
        }

        //Método para atualiar estoque
        public bool AtualizarQtEstoque(int qtde, int cod)
        {
            string query = "update produto set qt_estoque_prod = " +qtde+ " where cod_prod = " + cod;
            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }


        //Levar nome do produto para lista de itens (grid)
        public string BuscaNomeProd(int cod)
        {
            string query = "select descricao_prod from produto where cod_prod = " + cod;
            classConexao cConexao = new classConexao();

            DataTable dt = cConexao.RetornaDataTable(query);
            if (dt.Rows.Count > 0)

            {
                descricao_prod = dt.Rows[0]["descricao_prod"].ToString();
            }
            return descricao_prod;
        }
    }
}
