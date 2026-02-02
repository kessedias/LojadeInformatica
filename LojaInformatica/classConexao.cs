using System;
using System.Data;
using MySqlConnector;

namespace LojaInformatica
{
    class classConexao
    {
        private MySqlConnection c;
        private MySqlCommand cmd;
        private MySqlDataAdapter mDAdap;
        private string erros;

        public classConexao()
        {
            c = new MySqlConnection();
            erros = null;
        }

        public string ComandoErro => erros;

        /**
         * Nova conexão com o banco de dados
         */
        private void Conectar()
        {
            string conex =
                "Server=localhost;" +
                "Database=loja_informatica;" +
                "Uid=root;" +
                "Pwd=;" +
                "SslMode=None;";

            if (c.State == ConnectionState.Closed || c.State == ConnectionState.Broken)
            {
                c.ConnectionString = conex;
                c.Open();
            }
        }

        private void Desconectar()
        {
            if (c.State == ConnectionState.Open)
            {
                c.Close();
                c.Dispose();
            }
        }

        public int ExecutaQuery(string query)
        {
            try
            {
                Conectar();

                using (cmd = new MySqlCommand(query, c))
                {
                    cmd.CommandType = CommandType.Text;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                erros = ex.Message;
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable RetornaDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                Conectar();

                using (cmd = new MySqlCommand(query, c))
                using (mDAdap = new MySqlDataAdapter(cmd))
                {
                    mDAdap.Fill(dt);
                }

                return dt;
            }
            catch (MySqlException ex)
            {
                erros = ex.Message;
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public int ExecutaQueryID(string query)
        {
            try
            {
                Conectar();

                using (cmd = new MySqlCommand(query, c))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                erros = ex.Message;
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
