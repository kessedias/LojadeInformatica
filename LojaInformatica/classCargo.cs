using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classCargo
    {
        public classCargo()

        //Construtor - Cargo
        {
            cod_cargo = 0;
            data_cad_cargo = DateTime.Now;
            status_cargo = 0;
            nome_cargo = null;
        }

        //Propriedades - Cargo
        public int cod_cargo { get; set; }
        public DateTime data_cad_cargo { get; set; }
        public int status_cargo { get; set; }
        public string nome_cargo { get; set; }

        //Método - Cadastrar Cargo
        public int CadastrarCargo()
        {
            string query = "insert into cargo values (0,  now(), 1, '" + nome_cargo + "')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
        //Classe Cargo
        //Método para buscar os dados(Código e Nome do Cargo) da tabela cargo
        //Para popular a combo de cargo do formulário de cadastro de funcionários
        public DataTable BuscarCargo()
        {
            string query = "select cod_cargo, nome_cargo from cargo where status_cargo = 1 order by nome_cargo";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método de pesquisa de Cargo por Nome, Status e Data

        //Pesquisa de Cargo por Nome(Inicial)
        public DataTable BuscarCargoNomeInicial(string nomei)
        {
            string query = "SELECT cod_cargo 'Cod', nome_cargo 'Nome' from cargo where nome_cargo like '" +nomei+ "%' and status_cargo = 1 ORDER by nome_cargo";
                classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de cargo por Nome(Contem)
        public DataTable BuscarCargoNomeContem(string contem)
        {
            string query = "SELECT cod_cargo 'Cod', nome_cargo 'Nome' from cargo where nome_cargo like '%" + contem + "%' and status_cargo = 1 ORDER by nome_cargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de cargo por Status(status)
        public DataTable BuscarCargoStatus(int status)
        {
            string query = "SELECT cod_cargo 'Cod', nome_cargo 'Nome' from cargo where status_cargo = " + status + " ORDER by nome_cargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de cargo por Data(datacargo)
        public DataTable BuscarCargoData(DateTime datacargo1, DateTime datacargo2)
        {
            string query = "SELECT cod_cargo 'Cod', nome_cargo 'Nome', data_cad_cargo 'Data de Cadastro' from cargo where date(data_cad_cargo) between '"+datacargo1.ToString("yyyy-MM-dd")+ "'and '" + datacargo2.ToString("yyyy-MM-dd") + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método ára buscar os dados do banco quando o usuário escolhe o cliente na grid

        public bool ConsultarCargo(int cod)
        {
            string query = "select * from cargo where cod_cargo =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);
                data_cad_cargo = Convert.ToDateTime(dt.Rows[0]["data_cad_cargo"]);
                nome_cargo = dt.Rows[0]["nome_cargo"].ToString();
                status_cargo = Convert.ToInt32(dt.Rows[0]["status_cargo"]);

                return true;
            }
            else
                return false;
        }

        //Método Atualizar Cargo
        public bool AtualizarCargo()
        {
            string query = "update cargo set nome_cargo = '" +nome_cargo+ "', status_cargo =" + status_cargo + " where cod_cargo = " + cod_cargo;

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;         
        }
        
        public bool ExcluirCargo()
        {
            string query = "delete from cargo where cod_cargo = " + cod_cargo;

            classConexao cConexao = new classConexao();
            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
                return false;
        }      
    }
}
