using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classVenda
    {
        //Construtor
        public classVenda()
        {
            cod_vend = 0;
            data_vend = DateTime.Now;
            preco_vend = 0;
            desconto_vend = 0;
            forma_pag_vend = null;
            preco_total_vend = 0;
            cod_func = 0;
            cod_cli = 0;
        }

        //Propriedades
        public int cod_vend { get; set; }
        public DateTime data_vend { get; set; }
        public decimal preco_vend { get; set; }
        public decimal desconto_vend { get; set; }
        public string forma_pag_vend { get; set; }
        public decimal preco_total_vend { get; set; }
        public int cod_func { get; set; }
        public int cod_cli { get; set; }


        //Insert da Venda
        public bool CadastrarVenda()
        {
            string query = "INSERT INTO venda VALUES(0, now(), '" + preco_vend.ToString().Replace(",", ".") + "', '" + desconto_vend.ToString().Replace(",", ".") + "', '" + forma_pag_vend + "', '" + preco_total_vend.ToString().Replace(",", ".") + "', " + cod_func + ", " + cod_cli + "); select last_insert_id()";
            classConexao cConexao = new classConexao();

            cod_vend = 0;
            cod_vend = cConexao.ExecutaQueryID(query);

            if (cod_vend != 0)
                return true;
            else
            {
                //Erro = cConexao.ComandoErro;
                return false;
            }
        }

        //Método para busca da venda por data
        public DataTable RelVendaData(DateTime data1, DateTime data2)
        {
            string query = "select venda.data_vend, venda.forma_pag_vend, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli where date(venda.data_vend) BETWEEN '" + data1.ToString("yyyy-MM-dd") + "' AND '"+data2.ToString("yyyy-MM-dd") + "' order by venda.data_vend";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por preço
        public DataTable RelVendaPreço(decimal preco1, decimal preco2)
        {
            string query = "select venda.data_vend, venda.forma_pag_vend, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli where venda.preco_total_vend BETWEEN '" + preco1+"' AND '"+preco2+"' order by venda.preco_total_vend DESC";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por Forma de Pagamento
        public DataTable RelVendaFormaPag(string formapag)
        {
            string query = "select venda.data_vend, venda.forma_pag_vend, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli where venda.forma_pag_vend = '" + formapag+"' order by venda.forma_pag_vend";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por Nome do Funcionário
        public DataTable RelVendaNomeFunc(int codfunc)
        {
            string query = "select venda.data_vend, venda.forma_pag_vend, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli where funcionario.cod_func = " + codfunc+" order by venda.preco_total_vend DESC";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para busca da venda por nome do Cliente
        public DataTable RelVendaNomeCli(string nomecli)
        {
            string query = "select venda.data_vend, venda.forma_pag_vend, venda.preco_total_vend, funcionario.nome_func 'cod_func', Concat(cliente.nome_cli, ' ' , cliente.sobrenome_cli) 'cod_cli' from venda join funcionario on venda.cod_func = funcionario.cod_func JOIN cliente on venda.cod_cli = cliente.cod_cli where Concat(cliente.nome_cli, cliente.sobrenome_cli) Like '%"+nomecli+"%' order by venda.preco_total_vend DESC";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
    }
}
