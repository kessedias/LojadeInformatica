using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    class classItensVendidos
    {
        //Construtor
        public classItensVendidos()
        {
            cod_itens_vendidos = 0;
            qt_vendida = 0;
            preco_venda = 0;
            cod_prod = 0;
            cod_vend = 0;
        }

        //Propriedades
        public int cod_itens_vendidos { get; set; }
        public int qt_vendida { get; set; }
        public decimal preco_venda { get; set; }
        public int cod_prod { get; set; }
        public int cod_vend { get; set; }


        //Insert Intes Vendidos
        public bool CadastrarItensVendidos()
        {
            string query = "INSERT INTO itens_vendidos VALUES(0, " + qt_vendida + ", '" + preco_venda.ToString().Replace(",", ".") + "', "+cod_prod+", "+cod_vend+")";
            classConexao cConexao = new classConexao();

           int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
            {
                //Erro = cConexao.ComandoErro;
                return false;
            }
        }
    }
}
