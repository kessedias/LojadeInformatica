
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classCategoria
    {
        public classCategoria()

        //Construtor - Categoria
        {
            cod_categ = 0;
            status_categ = 0;
            nome_categ = null;
            data_cad_categ = DateTime.Now;        
        }

        //Propriedades - Categoria
        public int cod_categ { get; set; }
        public int status_categ { get; set; }
        public string nome_categ { get; set; }
        public DateTime data_cad_categ { get; set; }

        //Método - Cadastrar Categoria
        public int CadastrarCategoria()
        {
            string query = "insert into categoria values (0, 1, '" + nome_categ + "', now())";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //Classe Categoria
        //Método para buscar os dados(Código e Nome da Categoria) da tabela categoria
        //Para popular a combo de categoria do formulário de cadastro de produtos

        public DataTable BuscarCategoria()
        {
            string query = "select cod_categ, nome_categ from categoria where status_categ = 1 order by nome_categ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //Método de pesquisa de Categoria por Nome, Status e Data

        //Pesquisa de Categoria por Nome(Inicial)
        public DataTable BuscarCategoriaNomeInicial(string nomei)
        {
            string query = "SELECT cod_categ 'Cod', nome_categ 'Nome' from categoria where nome_categ like '" + nomei + "%' and status_categ = 1 ORDER by nome_categ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de categoria por Nome(Contem)
        public DataTable BuscarCategoriaNomeContem(string contem)
        {
            string query = "SELECT cod_categ 'Cod', nome_categ 'Nome' from categoria where nome_categ like '%" + contem + "%' and status_categ = 1 ORDER by nome_categ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de categ por Status(status)
        public DataTable BuscarCategoriaStatus(int status)
        {
            string query = "SELECT cod_categ 'Cod', nome_categ 'Nome' from categoria where  status_categ = " + status + " ORDER by nome_categ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de categ por Data(datacateg)
        public DataTable BuscarCategoriaData(DateTime datacateg1, DateTime datacateg2)
        {
            string query =" SELECT cod_categ 'Cod', nome_categ 'Categoria', data_cad_categ 'Data de Cadastro' from categoria where status_categ = 1 and date(data_cad_categ) between '" + datacateg1.ToString("yyyy-MM-dd")+ "' and '" + datacateg2.ToString("yyyy-MM-dd") + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método ára buscar os dados do banco quando o usuário escolhe o cliente na grid

        public bool ConsultarCategoria(int cod)
        {
            string query = "select * from categoria where cod_categ =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_categ = Convert.ToInt32(dt.Rows[0]["cod_categ"]);
                data_cad_categ = Convert.ToDateTime(dt.Rows[0]["data_cad_categ"]);
                nome_categ = dt.Rows[0]["nome_categ"].ToString();
                status_categ = Convert.ToInt32(dt.Rows[0]["status_categ"]);

                return true;
            }
            else
                return false;
        }

        //Método Atualizar Categoria
        public bool AtualizarCategoria()
        {
            string query = "update categoria set nome_categ = '" + nome_categ + "', status_categ =" + status_categ + " where cod_categ = " + cod_categ;

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        public bool ExcluirCategoria()
        {
            string query = "delete from categoria where cod_categ = " + cod_categ;

            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

    }
}
