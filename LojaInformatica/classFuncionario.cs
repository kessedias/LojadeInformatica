using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaInformatica
{
    class classFuncionario
    {
        public classFuncionario()
        {
            cod_func = 0;
            data_cad_func = DateTime.Now;
            status_func = 0;
            nome_func = null;
            sobrenome_func = null;
            nome_social_func = null;
            sexo_func = null;
            data_nasc_func = DateTime.Now;
            email_func = null;
            tel_res_func = null;
            tel_com_func = null;
            cel_func = null;
            cpf_func = null;
            sal_func = 0;
            cep_func = null;
            rua_func = null;
            numero_func = 0;
            complemento_func = null;
            bairro_func = null;
            cidade_func = null;
            estado_func = null;
            num_rg_func = null;
            orgao_emissor_func = null;
            data_expedicao_func = DateTime.Now;
            cod_cargo = 0;
        }

        //Propriedades
        public int cod_func { get; set; }
        public DateTime data_cad_func { get; set; }
        public int status_func { get; set; }
        public string nome_func { get; set; }
        public string sobrenome_func { get; set; }
        public string nome_social_func { get; set; }
        public string sexo_func { get; set; }
        public DateTime data_nasc_func { get; set; }
        public string email_func { get; set; }
        public string tel_res_func { get; set; }
        public string tel_com_func { get; set; }
        public string cel_func { get; set; }
        public string cpf_func { get; set; }
        public decimal sal_func { get; set; }
        public string cep_func { get; set; }
        public string rua_func { get; set; }
        public string complemento_func { get; set; }
        public int numero_func { get; set; }
        public string bairro_func { get; set; }
        public string cidade_func { get; set; }
        public string estado_func { get; set; }
        public string num_rg_func { get; set; }
        public string orgao_emissor_func { get; set; }
        public DateTime data_expedicao_func { get; set; }
        public int cod_cargo { get; set; }

        //Cadastrar Funcionário

        public int CadastrarFuncionario()
        {
            string query = "insert into funcionario values(0,now(), 1, '" + nome_func + "', '" + sobrenome_func + "', '" + nome_social_func + "', '" + sexo_func + "', '" + data_nasc_func.ToString("yyyy-MM-dd") + "', '" + email_func + "', '" + tel_res_func + "', '" + tel_com_func + "', '" + cel_func + "', '" + cpf_func + "', '" + sal_func.ToString().Replace(",", ".") + "', '" + cep_func + "', '" + rua_func + "', '" + complemento_func + "', " + numero_func + ", '" + bairro_func + "', '" + cidade_func + "', '" + estado_func + "', '" + num_rg_func + "', '" + orgao_emissor_func + "', '" + data_expedicao_func.ToString("yyyy-MM-dd") + "', '" + cod_cargo + "')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //Método de pesquisa de Funcionários por Nome, CPF, e Status

        //Pesquisa de Funcionário por Nome(Inicial)
        public DataTable BuscarFuncionarioInicial(string nomei)
        {
            string query = "SELECT cod_func 'Cod', nome_func 'Nome', sobrenome_func 'Sobrenome', cpf_func 'CPF', data_nasc_func 'Data de Nasc.', tel_res_func 'Tel. Res.', tel_com_func 'Tel. Com.', cel_func 'Celular' FROM funcionario WHERE nome_func LIKE '%" + nomei + "' and status_func = 1 ORDER by nome_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Pesquisa de Funcionário por CPF(Contém)
        public DataTable BuscarFuncionarioCPF(string cpfcli)
        {
            string query = "SELECT cod_func 'Cod', nome_func 'Nome', sobrenome_func 'Sobrenome', cpf_func 'Sobrenome', data_nasc_func 'Data de Nascimento', tel_res_func 'Tel. Res.', tel_com_func 'Tel. Com.', cel_func 'Celular' FROM funcionario WHERE cpf_func LIKE '%" + cpfcli + "%' and status_func = 1 ORDER by nome_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Pesquisa de Funcionário por Status ativo
        public DataTable BuscarFuncionarioStatus(int status)
        {
            string query = "SELECT cod_func 'Cod', nome_func 'Nome', sobrenome_func 'Sobrenome', cpf_func 'CPF', data_nasc_func 'Data de Nascimento', tel_res_func 'Tel. Res.', tel_com_func 'Tel. Com.', cel_func 'Celular' FROM funcionario WHERE status_func = " + status + " ORDER by nome_func";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Pesquisa dde Funcionario por Nome(Contem)
        public DataTable BuscarFuncionarioContem(string contem)
        {
            string query = "SELECT cod_func 'Cod', nome_func 'Nome', sobrenome_func 'Sobrenome', cpf_func 'CPF', data_nasc_func 'Data de Nascimento', tel_res_func 'Tel. Res.', tel_com_func 'Tel. Com.', cel_func 'Celular' FROM funcionario WHERE nome_func LIKE '%" + contem + "%' and status_func = 1 ORDER by nome_func";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para buscar funcionário pelo Cargo
        public DataTable BuscarFuncionarioCargo(int cargo)
        {
            string query = "SELECT funcionario.cod_func 'Cod', funcionario.nome_func as 'Nome', cargo.nome_cargo as 'Cargo', funcionario.sal_func as 'Salario' from cargo JOIN funcionario ON cargo.cod_cargo = funcionario.cod_cargo WHERE funcionario.status_func = 1 and cargo.cod_cargo = " + cargo;
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para buscar funcionário pelo Sexo
        public DataTable BuscarFuncionarioSexo(string sexo)
        {
            string query = "select cod_func 'Cod', nome_func 'Nome', sexo_func 'Sexo' from funcionario WHERE sexo_func = '" + sexo + "'  and status_func = 1 ORDER BY nome_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para Buscar os Dados do Banco quando o Usuário escolhe o Funcionário na GRID
        public bool ConsultarFuncionario(int cod)
        {
            string query = "select * from funcionario where cod_func =" + cod;
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_func = Convert.ToInt32(dt.Rows[0]["cod_func"]);
                data_cad_func = Convert.ToDateTime(dt.Rows[0]["data_cad_func"]);
                status_func = Convert.ToInt32(dt.Rows[0]["status_func"]);
                nome_func = dt.Rows[0]["nome_func"].ToString();
                sobrenome_func = dt.Rows[0]["sobrenome_func"].ToString();
                nome_social_func = dt.Rows[0]["nome_social_func"].ToString();
                sexo_func = dt.Rows[0]["sexo_func"].ToString();
                data_nasc_func = Convert.ToDateTime(dt.Rows[0]["data_nasc_func"]);
                email_func = dt.Rows[0]["email_func"].ToString();
                tel_res_func = dt.Rows[0]["tel_res_func"].ToString();
                tel_com_func = dt.Rows[0]["tel_com_func"].ToString();
                cel_func = dt.Rows[0]["cel_func"].ToString();
                cpf_func = dt.Rows[0]["cpf_func"].ToString();
                sal_func = Convert.ToDecimal(dt.Rows[0]["sal_func"]);
                cep_func = dt.Rows[0]["cep_func"].ToString();
                rua_func = dt.Rows[0]["rua_func"].ToString();
                complemento_func = dt.Rows[0]["complemento_func"].ToString();
                numero_func = Convert.ToInt32(dt.Rows[0]["numero_func"]);
                bairro_func = dt.Rows[0]["bairro_func"].ToString();
                cidade_func = dt.Rows[0]["cidade_func"].ToString();
                estado_func = dt.Rows[0]["estado_func"].ToString();
                num_rg_func = dt.Rows[0]["num_rg_func"].ToString();
                orgao_emissor_func = dt.Rows[0]["orgao_emissor_func"].ToString();
                data_expedicao_func = Convert.ToDateTime(dt.Rows[0]["data_expedicao_func"]);
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);


                return true;
            }
            else
                return false;
        }
        //Método Atualizar Funcionario
        public bool AtualizarFuncionario()
        {
            string query = "update funcionario set nome_func= '" + nome_func + "', sobrenome_func= '" + sobrenome_func + "', nome_social_func= '" + nome_social_func + "', data_nasc_func= '" + data_nasc_func.ToString("yyyy-MM-dd") + "', sexo_func='" + sexo_func + "', cpf_func='" + cpf_func + "', cep_func='" + cep_func + "', rua_func= '" + rua_func + "', numero_func=" + numero_func + ",complemento_func= '" + complemento_func + "', bairro_func='" + bairro_func + "', cidade_func='" + cidade_func + "', estado_func= '" + estado_func + "', sal_func = '" + sal_func.ToString().Replace(",", ".") + "', email_func= '" + email_func + "', tel_com_func ='" + tel_com_func + "', tel_res_func ='" + tel_res_func + "', cel_func ='" + cel_func + "',num_rg_func= '" + num_rg_func + "',orgao_emissor_func= '" + orgao_emissor_func + "',data_expedicao_func= '" + data_expedicao_func.ToString("yyyy-MM-dd") + "', cod_cargo= " + cod_cargo + ", status_func =" + status_func + " where cod_func=" + cod_func;

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


        //Método Excluir Funcionario
        public bool ExcluirFuncionario()
        {
            string query = "delete from funcionario where cod_func =" + cod_func;

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //Método para o relatório de Funcionários - Cargo
        public DataTable RelFuncCargo(int cargo)
        {
            string query = "SELECT cargo.nome_cargo 'cod_cargo',funcionario.nome_func, funcionario.bairro_func, funcionario.sal_func, funcionario.sexo_func FROM funcionario JOIN cargo on funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = 1 and cargo.cod_cargo = " + cargo + " order by cargo.nome_cargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para o relatório de Funcionários - Bairro
        public DataTable RelFuncBairro(string bairro)
        {
            string query = "SELECT cargo.nome_cargo 'cod_cargo',funcionario.nome_func, funcionario.bairro_func, funcionario.sal_func, funcionario.sexo_func FROM funcionario JOIN cargo on funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = 1 and funcionario.bairro_func = '" + bairro + "' order by funcionario.bairro_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método para o relatório de Funcionários - Salário
        public DataTable RelFuncSalario(decimal sal1, decimal sal2)
        {
            string query = "SELECT cargo.nome_cargo 'cod_cargo',funcionario.nome_func, funcionario.bairro_func, funcionario.sal_func, funcionario.sexo_func FROM funcionario JOIN cargo on funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = 1 and funcionario.sal_func BETWEEN " + sal1 + " and " + sal2 + " ORDER BY funcionario.sal_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        //Método para o relatório de Funcionários - Sexo
        public DataTable RelFuncSexo(string sexo)
        {
            string query = "SELECT cargo.nome_cargo 'cod_cargo',funcionario.nome_func, funcionario.bairro_func, funcionario.sal_func, funcionario.sexo_func FROM funcionario JOIN cargo on funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = 1 and funcionario.sexo_func = '" + sexo + "' order by funcionario.sexo_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //Método para o relatório de funcionários - Status
        public DataTable RelFuncStatus(int status)
        {
            string query = "SELECT cargo.nome_cargo 'cod_cargo',funcionario.nome_func, funcionario.bairro_func, funcionario.sal_func, funcionario.sexo_func FROM funcionario JOIN cargo on funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = " + status + " order by funcionario.nome_func";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        //Método para carregar combo de bairros (dos funcionários) No Relatório de Funcionários
        public DataTable BuscarBairro()
        {
            string query = "SELECT DISTINCT bairro_func from funcionario WHERE status_func = 1";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }


        //Método de busca funcionário
        public DataTable BuscarNomeFuncionario()
        {
            string query = "select cod_func, CONCAT(funcionario.nome_func, ' ', funcionario.sobrenome_func) as nome FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo where funcionario.status_func = 1 and cargo.nome_cargo = 'Vendedor' order by funcionario.nome_func";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //Método de buscar cpf do funcionário
        public DataTable BuscarCPFFuncionario(string cpf)
        {
            string query = "SELECT cpf_func FROM funcionario where status_func = 1 and cpf_func = '"+cpf+"'";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
    }
}
