using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classCliente
    {
       
        //Construtor - Inicializar as variáveis
       public classCliente()
        {
            cod_cli = 0;
            data_cad_cli = DateTime.Now;
            status_cli = 0;
            nome_cli = null;
            sobrenome_cli = null;
            data_nasc_cli = DateTime.Now;
            sexo_cli = null;
            cpf_cli = null;
            rua_cli = null;
            numero_cli = 0;
            complemento_cli = null;
            bairro_cli = null;
            cidade_cli = null;
            estado_cli = null;
            email_cli = null;
            tel_com_cli = null;
            tel_res_cli = null;
            cel_cli = null;
        }
        
        //Propriedades - ler as informações do BD
        //Mesmo nome dos campos do BD para as propriedades
        public int cod_cli { get; set; }
        public DateTime data_cad_cli { get; set; }
        public int status_cli { get; set; }
        public string nome_cli { get; set; }
        public string sobrenome_cli { get; set; }
        public DateTime data_nasc_cli { get; set; }
        public string sexo_cli { get; set; }
        public string cpf_cli { get; set; }
        public string cep_cli { get; set; }
        public string rua_cli { get; set; }
        public int numero_cli { get; set; }
        public string complemento_cli { get; set; }
        public string bairro_cli  { get; set; }
        public string cidade_cli { get; set; }
        public string estado_cli { get; set; }
        public string email_cli  { get; set; }
        public string tel_com_cli { get; set; }
        public string tel_res_cli { get; set; }
        public string cel_cli { get; set; }

        //Método para cadastrar cliente
        //Tipo do método - tipo de retorno - nome do método - pârametro()
        //fazer o insert na sequencia da tabela criada no BD

        public int CadastrarCliente()
        {
            string query = "insert into cliente values(0, now(), 1 , '"+ nome_cli +"', '"+ sobrenome_cli + "', '"+ data_nasc_cli.ToString("yyyy-MM-dd") +"', '"+ sexo_cli + "', '"+ cpf_cli + "', '"+ cep_cli +"', '"+ rua_cli + "', "+ numero_cli + ", '"+ complemento_cli + "', '"+ bairro_cli + "', '"+ cidade_cli + "', '"+ estado_cli + "', '"+ email_cli + "', '"+ tel_com_cli + "', '"+ tel_res_cli + "', '"+ cel_cli +"')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
         //Método de pesquisa de Clientes por Nome, CPF, e Status
         
        //Pesquisa de Cliente por Nome(Inicial)
        public DataTable BuscarClienteInicial(string nomei)
        {
            string query = "SELECT cod_cli 'Cod', nome_cli 'Nome', sobrenome_cli 'Sobrenome', cpf_cli 'CPF', data_nasc_cli 'Data de Nasc.', tel_res_cli 'Tel. Res.', tel_com_cli 'Tel. Com.', cel_cli 'Celular' FROM cliente WHERE nome_cli LIKE '%"+ nomei +"' and status_cli = 1 ORDER by nome_cli";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Pesquisa de Cliente por CPF(Contém)
        public DataTable BuscarClienteCPF(string cpfcli)
        {
            string query = "SELECT cod_cli 'Cod', nome_cli 'Nome', sobrenome_cli 'Sobrenome', cpf_cli 'CPF', data_nasc_cli 'Data de Nasc.', tel_res_cli 'Tel. Res.', tel_com_cli 'Tel. Com.', cel_cli 'Celular' FROM cliente WHERE cpf_cli LIKE '%" + cpfcli + "%' and status_cli = 1 ORDER by nome_cli";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Cliente por Status ativo
        public DataTable BuscarClienteStatus(int status)
        {
            string query = "SELECT cod_cli 'Cod', nome_cli 'Nome', sobrenome_cli 'Sobrenome', cpf_cli 'CPF', data_nasc_cli 'Data de Nasc.', tel_res_cli 'Tel. Res.', tel_com_cli 'Tel. Com.', cel_cli 'Celular' FROM cliente WHERE status_cli = "+status+" ORDER by nome_cli";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Pesquisa dde Cliente por Nome(Contem)
        public DataTable BuscarClienteContem(string contem)
        {
            string query = "SELECT cod_cli 'Cod', nome_cli 'Nome', sobrenome_cli 'Sobrenome', cpf_cli 'CPF', data_nasc_cli 'Data de Nasc.', tel_res_cli 'Tel. Res.', tel_com_cli 'Tel. Com.', cel_cli 'Celular' FROM cliente WHERE nome_cli LIKE '%" + contem + "%' and status_cli = 1 ORDER by nome_cli";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar cliente pelo Sexo
        public DataTable BuscarClienteSexo(string sexo)
        {
            string query = "select cod_cli 'Cod', nome_cli 'Nome', sexo_cli 'Sexo' from cliente WHERE sexo_cli = '" + sexo + "' and status_cli = 1 ORDER BY nome_cli";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar cliente pelo bairro
        public DataTable BuscarClienteBairro(string bairro)
        {
            string query = "select cod_cli 'Cod', nome_cli 'Nome', bairro_cli 'Bairro', rua_cli 'Rua', numero_cli 'Numero' from cliente WHERE bairro_cli = '" + bairro + "' and status_cli = 1 order by bairro_cli";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para Buscar os Dados do Banco quando o Usuário escolhe o Cliente na GRID
        public bool ConsultarCliente(int cod)
        {
            string query = "select * from cliente where cod_cli =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_cli = Convert.ToInt32(dt.Rows[0]["cod_cli"]);
                data_cad_cli = Convert.ToDateTime(dt.Rows[0]["data_cad_cli"]);
                status_cli = Convert.ToInt32(dt.Rows[0]["status_cli"]);
                nome_cli = dt.Rows[0]["nome_cli"].ToString();
                sobrenome_cli = dt.Rows[0]["sobrenome_cli"].ToString();
                data_nasc_cli = Convert.ToDateTime(dt.Rows[0]["data_nasc_cli"]);
                sexo_cli = dt.Rows[0]["sexo_cli"].ToString();
                cpf_cli = dt.Rows[0]["cpf_cli"].ToString();
                cep_cli = dt.Rows[0]["cep_cli"].ToString();
                rua_cli = dt.Rows[0]["rua_cli"].ToString();
                numero_cli = Convert.ToInt32(dt.Rows[0]["numero_cli"]);
                complemento_cli = dt.Rows[0]["complemento_cli"].ToString();
                bairro_cli = dt.Rows[0]["bairro_cli"].ToString();
                cidade_cli = dt.Rows[0]["cidade_cli"].ToString();
                estado_cli = dt.Rows[0]["estado_cli"].ToString();
                email_cli = dt.Rows[0]["email_cli"].ToString();
                tel_com_cli = dt.Rows[0]["tel_com_cli"].ToString();
                tel_res_cli = dt.Rows[0]["tel_res_cli"].ToString();
                cel_cli = dt.Rows[0]["cel_cli"].ToString();

                return true;
            }
            else
                return false;
        }
        //Método Atualizar Cliente
        public bool AtualizarCliente()
        {
            string query = "update cliente set nome_cli= '" + nome_cli + "', sobrenome_cli= '" + sobrenome_cli + "', data_nasc_cli= '" + data_nasc_cli.ToString("yyyy-MM-dd") + "', sexo_cli='" + sexo_cli + "', cpf_cli='" + cpf_cli + "', cep_cli='" + cep_cli + "', rua_cli= '" + rua_cli + "', numero_cli= " + numero_cli + ",complemento_cli= '" + complemento_cli + "', bairro_cli='" + bairro_cli + "', cidade_cli='" + cidade_cli + "', estado_cli= '" + estado_cli + "', email_cli= '" + email_cli + "', tel_com_cli ='" + tel_com_cli + "', tel_res_cli ='" + tel_res_cli + "', cel_cli ='" + cel_cli + "', status_cli =" + status_cli + " where cod_cli=" + cod_cli; 

            //Criando o objeto Classe conexão
            classConexao cConexao = new classConexao();

            //Criando a variável que vai chamar o método parar fazer a alteração
            int aux = cConexao.ExecutaQuery(query);

            //Se for 1 ele atualiza, caso contrário, não passará. Usando a variável booleana.
            if (aux != 0)
                return true;
            else
                return false;
        }


        //Método Excluir Cliente
        public bool ExcluirCliente()
        {
            string query = "delete from cliente where cod_cli =" + cod_cli;

            classConexao  cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }


        //Método para o relatório de Cliente - Busca de Aniversariante por mês e dia
        public DataTable RelClienteDiaMes(int dia, int mes)

        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE DAY(data_nasc_cli) = "+dia+" AND MONTH(data_nasc_cli) = "+mes+" and status_cli = 1 order by nome_cli";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método para o relatório de Cliente - Busca de Aniversariante por mês
        public DataTable RelClienteMes(int mes)

        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE MONTH(data_nasc_cli) = "+mes+" and status_cli = 1 order by nome_cli";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método para o relatório de Cliente - Busca de Sexo
        public DataTable RelClienteSexo(string sexo)

        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE sexo_cli = '"+sexo+"' and status_cli = 1 order by nome_cli ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método para o relatório de Cliente - Busca de Cidade
        public DataTable RelClienteCidade(string cidade)

        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE cidade_cli = '" + cidade + "' and status_cli = 1 order by nome_cli ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método para o relatório de CLiente - Busca entre Idades
        public DataTable RelClienteIdade(int idadei, int idadef)
        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE TIMESTAMPDIFF(YEAR, data_nasc_cli, NOW()) BETWEEN "+idadei+" AND "+idadef+" and status_cli = 1";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para carregar combo de cidades (dos clientes) No Relatório de clientes
        public DataTable BuscarCidade()
        {
            string query = "SELECT DISTINCT cidade_cli from cliente WHERE status_cli = 1";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método para Pesquisa de Cliente por Status 
        public DataTable RelClienteStatus(int status)
        {
            string query = "SELECT cpf_cli, nome_cli, data_nasc_cli, sexo_cli, cidade_cli, cel_cli FROM cliente WHERE status_cli = " + status + " ORDER by nome_cli";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Buscar Cliente - Venda
        public DataTable BuscarCliente(string cli)
        {
            string query = "SELECT cod_cli 'Cod', cpf_cli 'CPF', nome_cli 'Nome', sobrenome_cli 'Sobrenome' from cliente where status_cli = 1 and nome_cli like '%"+cli+"' order by nome_cli";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


    }
}
