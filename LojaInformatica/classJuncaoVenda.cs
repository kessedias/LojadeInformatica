using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classJuncaoVenda
    {
        public classJuncaoVenda()
        {
            //classItensVendidos
            cod_itens_vendidos = 0;
            qt_vendida = 0;
            preco_venda = 0;
            cod_prod = 0;
            cod_vend = 0;

            //classVenda
            //cod_vend = 0;
            data_vend = DateTime.Now;
            preco_vend = 0;
            desconto_vend = 0;
            forma_pag_vend = null;
            preco_total_vend = 0;
            cod_func = 0;
            cod_cli = 0;

            nome_marca = null;
            nome_categ = null;
        }


            //Propriedades Venda
        //public int cod_vend { get; set; }
        public DateTime data_vend { get; set; }
        public decimal preco_vend { get; set; }
        public decimal desconto_vend { get; set; }
        public string forma_pag_vend { get; set; }
        public decimal preco_total_vend { get; set; }
        public int cod_func { get; set; }
        public int cod_cli { get; set; }         

        //Propriedades Itens Vendidos
        public int cod_itens_vendidos { get; set; }
        public int qt_vendida { get; set; }
        public decimal preco_venda { get; set; }
        public int cod_prod { get; set; }
        public int cod_vend { get; set; }

        public string nome_categ { get; set; }

        public string nome_marca { get; set; }


        //Método para busca da venda por data
        public DataTable RelVendaDetData(DateTime data1, DateTime data2)
        {
            string query = "select venda.cod_vend, venda.forma_pag_vend, venda.desconto_vend, itens_vendidos.preco_venda, venda.data_vend, itens_vendidos.qt_vendida, produto.descricao_prod'cod_prod',  marca.nome_marca, categoria.nome_categ, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli JOIN itens_vendidos on itens_vendidos.cod_vend = venda.cod_vend join produto on produto.cod_prod = itens_vendidos.cod_prod join marca on produto.cod_marca = marca.cod_marca join categoria on produto.cod_categ = categoria.cod_categ where Cast(venda.data_vend as date) BETWEEN '"+data1.ToString("yyyy-MM-dd") + "' and '"+data2.ToString("yyyy-MM-dd") + "'";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por preço
        public DataTable RelVendaDetPreço(decimal preco1, decimal preco2)
        {
            string query = "select venda.cod_vend, venda.forma_pag_vend, venda.desconto_vend, itens_vendidos.preco_venda, venda.data_vend, itens_vendidos.qt_vendida, produto.descricao_prod'cod_prod',  marca.nome_marca, categoria.nome_categ, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli JOIN itens_vendidos on itens_vendidos.cod_vend = venda.cod_vend join produto on produto.cod_prod = itens_vendidos.cod_prod join marca on produto.cod_marca = marca.cod_marca join categoria on produto.cod_categ = categoria.cod_categ where venda.preco_total_vend BETWEEN "+preco1+" and "+preco2+"";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por Forma de Pagamento
        public DataTable RelVendaDetFormaPag(string formapag)
        {
            string query = "select venda.cod_vend, venda.forma_pag_vend, venda.desconto_vend, itens_vendidos.preco_venda, venda.data_vend, itens_vendidos.qt_vendida, produto.descricao_prod'cod_prod',  marca.nome_marca, categoria.nome_categ, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli JOIN itens_vendidos on itens_vendidos.cod_vend = venda.cod_vend join produto on produto.cod_prod = itens_vendidos.cod_prod join marca on produto.cod_marca = marca.cod_marca join categoria on produto.cod_categ = categoria.cod_categ where venda.forma_pag_vend = '"+formapag+"'";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por Nome do Funcionário
        public DataTable RelVendaDetNomeFunc(int codfunc)
        {
            string query = "select venda.cod_vend, venda.forma_pag_vend, venda.desconto_vend, itens_vendidos.preco_venda, venda.data_vend, itens_vendidos.qt_vendida, produto.descricao_prod'cod_prod',  marca.nome_marca, categoria.nome_categ, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli JOIN itens_vendidos on itens_vendidos.cod_vend = venda.cod_vend join produto on produto.cod_prod = itens_vendidos.cod_prod join marca on produto.cod_marca = marca.cod_marca join categoria on produto.cod_categ = categoria.cod_categ where funcionario.cod_func = "+codfunc;

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por nome do Cliente
        public DataTable RelVendaDetNomeCli(string nomecli)
        {
            string query = "select venda.cod_vend, venda.forma_pag_vend, venda.desconto_vend, itens_vendidos.preco_venda, venda.data_vend, itens_vendidos.qt_vendida, produto.descricao_prod'cod_prod',  marca.nome_marca, categoria.nome_categ, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli JOIN itens_vendidos on itens_vendidos.cod_vend = venda.cod_vend join produto on produto.cod_prod = itens_vendidos.cod_prod join marca on produto.cod_marca = marca.cod_marca join categoria on produto.cod_categ = categoria.cod_categ where Concat(cliente.nome_cli, ' ', cliente.sobrenome_cli) LIKE '%"+nomecli+"%'";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
    }
}
