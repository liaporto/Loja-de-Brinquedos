using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    class VendasClasse
    {
        public int Cod_venda { get; private set; }
        public string Cpf_cliente { get; private set; }
        public int Cod_brinquedo { get; private set; }
        public DateTime Data_venda { get; private set; }
        public int Quantidade { get; private set; }

        public bool AlteraAtributo(string Cpf_cliente_, int Cod_brinquedo_, DateTime Data_Venda_, int Quantidade_)
        {
            CriticaDados novo = new CriticaDados();
            bool retorno = true;

           
            Cpf_cliente = Cpf_cliente_;
            Cod_brinquedo = Cod_brinquedo_;
            Data_venda = Data_Venda_;
            Quantidade = Quantidade_;
            return retorno;
        }

        public bool CadastraBancoemBloco(int[] Cod_Brinquedo, DateTime[] Data_Venda, string[] Cpf_cliente, int[] qtd)
        {
            bool retorno;

                BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Insert into tab_vendas_cliente(FK_cod_produto, data_venda, FK_cpf_cliente, quantidade) values";
                for (int i = 0; i < Cod_Brinquedo.Count(); i++)
                {
                    sql = sql + "(" + Cod_Brinquedo[i] + ", '" + Data_Venda[i].ToString("yyyy-MM-dd") + "', '" + Cpf_cliente[i] + "', " + qtd[i] + "),";


                    if (i == Cod_Brinquedo.Count() - 1)
                        sql = sql.Substring(0, sql.Count() - 1);

                }
                if (banco.Insere(sql))
                {
                    retorno = true;
                }
                else
                    retorno = false;
            }
            else
                retorno = false;

            
          BDLP banco2 = new BDLP();
          if (banco2.Conecta())
            { 
                string sqlEstoque = "UPDATE tab_brinquedo SET quantidade_em_estoque = quantidade_em_estoque - ";
                for (int i = 0; i < Cod_Brinquedo.Count(); i++)
                {

                    sqlEstoque = sqlEstoque
                    + qtd[i] + " where cod_brinquedo = " +
                    Cod_Brinquedo[i] + " ";

                    if (i == Cod_Brinquedo.Count() - 1)
                        sqlEstoque = sqlEstoque.Substring(0, sqlEstoque.Count() - 1);

                }
                    if (banco2.Insere(sqlEstoque))
                    {
                        retorno = true;

                    }
                    else
                        retorno = false;
                }
          else
            retorno = false;

            return retorno;
            //banco.Desconecta();

        }





        public DataTable BuscaVendaBanco(int Cod_brinquedo)
        {
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Select C.nome Nome, B.nome_brinquedo  Nome_brinquedo, V.data_venda data_Venda, quantidade from"+
                    " tab_vendas_cliente V, tab_cliente C, tab_brinquedo B" + " where B.cod_brinquedo = V.FK_cod_produto"+
                    " and C.cpf = V.FK_cpf_cliente and B.cod_brinquedo = " + Cod_brinquedo;
                dt = banco.Busca(sql);
            }
            banco.Desconecta();
            return dt;
        }


    }
}

