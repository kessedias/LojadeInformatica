using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    class classMarca
    {
        public classMarca()

            //Construtor - Marca
        {
            cod_marca = 0;
            status_marca = 0;
            data_cad_marca = DateTime.Now;
            nome_marca = null;
        }

        //Propriedades - Marca
        public int cod_marca { get; set; }
        public int status_marca { get; set; }
        public DateTime data_cad_marca { get; set; }
        public string nome_marca { get; set; }

        //Método - Cadastrar Marca
        public int CadastrarMarca()
        {
            string query = "insert into marca values (0, 1, now(), '"+nome_marca+"')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

  
        //Classe Marca
        //Método para buscar os dados(Código e Nome da Categoria) da tabela categoria
        //Para popular a combo de categoria do formulário de cadastro de produtos

        public DataTable BuscarMarca()
        {
            string query = "select cod_marca, nome_marca from marca where status_marca = 1 order by nome_marca";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método de pesquisa de Marca por Nome, Status e Data

        //Pesquisa de Marca por Nome(Inicial)
        public DataTable BuscarMarcaNomeInicial(string nomei)
        {
            string query = "SELECT cod_marca 'Cod', nome_marca 'Marca' from marca where nome_marca like '" + nomei + "%' and status_marca = 1 ORDER by nome_marca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por Nome(Contem)
        public DataTable BuscarMarcaNomeContem(string contem)
        {
            string query = "SELECT cod_marca 'Cod', nome_marca 'Marca' from marca where nome_marca like '%" + contem + "%' and status_marca = 1 ORDER by nome_marca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por Status(status)
        public DataTable BuscarMarcaStatus(int status)
        {
            string query = "SELECT cod_marca 'Cod', nome_marca 'Marca' from marca where  status_marca = " + status + " ORDER by nome_marca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Marca por Data(datamarca)
        public DataTable BuscarMarcaData(DateTime datamarca1, DateTime datamarca2)
        {
            string query = "SELECT cod_marca 'Cod', nome_marca 'Marca', data_cad_marca 'Data de Cadastro' from marca where status_marca = 1 and date(data_cad_marca) between '" + datamarca1.ToString("yyyy-MM-dd")+ "' and '" + datamarca2.ToString("yyyy-MM-dd") + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método ára buscar os dados do banco quando o usuário escolhe o cliente na grid

        public bool ConsultarMarca(int cod)
        {
            string query = "select * from marca where cod_marca =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_marca = Convert.ToInt32(dt.Rows[0]["cod_marca"]);
                data_cad_marca = Convert.ToDateTime(dt.Rows[0]["data_cad_marca"]);
                nome_marca = dt.Rows[0]["nome_marca"].ToString();
                status_marca = Convert.ToInt32(dt.Rows[0]["status_marca"]);

                return true;
            }
            else
                return false;
        }

        //Método Atualizar Marca
        public bool AtualizarMarca()
        {
            string query = "update marca set nome_marca = '" + nome_marca + "', status_marca =" + status_marca + " where cod_marca = " + cod_marca;

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        public bool ExcluirMarca()
        {
            string query = "delete from marca where cod_marca = " + cod_marca;

            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }

        //Relatório de Marca
        public DataTable RelMarca()
        {
            string query = "SELECT cod_marca, nome_marca, data_cad_marca, status_marca from marca WHERE status_marca = 1 ORDER BY nome_marca";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }  
    }
}
