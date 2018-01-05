using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    class Brinquedo
    {
        public int Cod_Brinquedo { get; private set; }
        public string Nome_Brinquedo { get; private set; }
        public string Categoria { get; private set; }
        public string FaixaEtaria { get; private set; }
        public string Marca { get; private set; }
        public DateTime Data_Aquisicao { get; private set; }
        public int Qtd_Estoque { get; private set; }
        
          //Método que atualiza os dados de cadastro
        public bool AlteraAtributo(string Nome_Brinquedo_, string Categoria_, DateTime Data_Aquisicao_, 
            string FaixaEtaria_, string Marca_, int Qtd_Estoque_)
        {
            CriticaDados novo = new CriticaDados();
            bool retorno = true;
            
            Nome_Brinquedo = Nome_Brinquedo_;
            
            if (novo.VerificaLetra_Ponto_Traco(Categoria_))
            { 
            Categoria = Categoria_;
            }

            Data_Aquisicao = Data_Aquisicao_;
            
           
                FaixaEtaria = FaixaEtaria_;
            
            if (novo.VerificaLetra_Traco(Marca_))
            { 
            Marca = Marca_;
            }
                Qtd_Estoque = Qtd_Estoque_;

            return retorno;
        }

        //Método que cadastra os dados no banco de dados BDLP
        public bool CadastraBanco()
        {
            bool retorno;
            BDLP banco = new BDLP();

            //Se o banco estiver conectado, isso é feito
            if (banco.Conecta())
            {
                //Cria-se a string que vai dar o comando de inserir dados na tabela. A string é um comando SQL
                string sql = "INSERT INTO tab_brinquedo(nome_brinquedo, categoria, faixa_etaria, marca, data_ultimareposicao, quantidade_em_estoque) "+
                    "VALUES ('"+Nome_Brinquedo+"', '"+Categoria+"', '"+FaixaEtaria+"', '"+Marca+"', '"+ Data_Aquisicao.ToString("yyyy-MM-dd") +"', "+Qtd_Estoque+");";

                //Se o método que envia a string sql no banco de dados for rodado com sucesso e retornar "true", o cadastro foi feito e também
                // retorna "true". Se não, retorna "false"
                if (banco.Insere(sql))
                {
                    retorno = true;

                }
                else
                    retorno = false;
            }
            else
                retorno = false;
            //banco.Desconecta();
            return retorno;

        }

        public List<Brinquedo> BuscaBrinquedosBanco(string NomeBrinquedo)
        {
            List<Brinquedo> lista = new List<Brinquedo>();
            DataTable dt = new DataTable();   
            BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_brinquedo where nome_brinquedo like '" + NomeBrinquedo + "%'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Brinquedo novo = new Brinquedo();
                novo.Cod_Brinquedo = Convert.ToInt16(dt.Rows[i]["cod_brinquedo"]);
                novo.Nome_Brinquedo = Convert.ToString(dt.Rows[i]["nome_brinquedo"]);
                novo.Categoria = dt.Rows[i]["categoria"].ToString();
                novo.FaixaEtaria = dt.Rows[i]["faixa_etaria"].ToString();
                novo.Data_Aquisicao = Convert.ToDateTime(dt.Rows[i]["data_ultimareposicao"]);
                novo.Marca = dt.Rows[i]["marca"].ToString();
                novo.Qtd_Estoque = Convert.ToInt16(dt.Rows[i]["quantidade_em_estoque"]);

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }

        public List<Brinquedo> BuscaBrinquedosCodBanco(int Cod_brinquedo)
        {
            List<Brinquedo> lista = new List<Brinquedo>();
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            Brinquedo novo = new Brinquedo();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_brinquedo where cod_brinquedo = '" + Cod_brinquedo + "'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                novo.Cod_Brinquedo = Convert.ToInt16(dt.Rows[i]["cod_brinquedo"]);
                novo.Nome_Brinquedo = Convert.ToString(dt.Rows[i]["nome_brinquedo"]);
                novo.Categoria = dt.Rows[i]["categoria"].ToString();
                novo.FaixaEtaria = dt.Rows[i]["faixa_etaria"].ToString();
                novo.Data_Aquisicao = Convert.ToDateTime(dt.Rows[i]["data_ultimareposicao"]);
                novo.Marca = dt.Rows[i]["marca"].ToString();
                novo.Qtd_Estoque = Convert.ToInt16(dt.Rows[i]["quantidade_em_estoque"]);

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }

        public List<Brinquedo> BuscaBrinquedosBancoNomeInteiro(string NomeBrinquedo)
        {
            List<Brinquedo> lista = new List<Brinquedo>();
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            Brinquedo novo = new Brinquedo();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_brinquedo where nome_brinquedo = '" + NomeBrinquedo + "'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                novo.Cod_Brinquedo = Convert.ToInt16(dt.Rows[i]["cod_brinquedo"]);
                novo.Nome_Brinquedo = Convert.ToString(dt.Rows[i]["nome_brinquedo"]);
               

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }

        public List<Brinquedo> PegaTodoBrinquedoBanco()
        {
            List<Brinquedo> lista = new List<Brinquedo>();
            DataTable dt = new DataTable();
            Brinquedo novo = new Brinquedo();
            BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_brinquedo";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                novo.Cod_Brinquedo = Convert.ToInt16(dt.Rows[i]["cod_brinquedo"]);
                novo.Nome_Brinquedo = Convert.ToString(dt.Rows[i]["nome_brinquedo"]);
                novo.Categoria = dt.Rows[i]["categoria"].ToString();
                novo.FaixaEtaria = dt.Rows[i]["faixa_etaria"].ToString();
                novo.Data_Aquisicao = Convert.ToDateTime(dt.Rows[i]["data_ultimareposicao"]);
                novo.Marca = dt.Rows[i]["marca"].ToString();
                novo.Qtd_Estoque = Convert.ToInt16(dt.Rows[i]["quantidade_em_estoque"]);

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }


        public bool AlteraBrinquedosBanco()
        {
            bool retorno = true;
            BDLP banco = new BDLP();

            if (banco.Conecta())
            {
                string sql = "UPDATE tab_brinquedo SET nome_brinquedo = '" + Nome_Brinquedo +
                    "', categoria = '" + Categoria +
                    "', faixa_etaria = '" + FaixaEtaria +
                    "', marca = '" + Marca +
                    "', data_ultimareposicao = '" + Data_Aquisicao.ToString("yyyy-MM-dd") +
                    "', quantidade_em_estoque = " + Qtd_Estoque +
                    " where cod_brinquedo = " + Cod_Brinquedo;
                if (banco.Altera(sql))

                    retorno = true;

                else
                    retorno = false;
            }

            else
            {
                retorno = false;

                return retorno;
            }

            return retorno;
        }

        public bool DeletaBinquedosBanco(int cod_produto)
        {
            bool retorno = true;
            BDLP banco = new BDLP();

            if (banco.Conecta())
            {
                string sql = "DELETE FROM tab_brinquedo where cod_brinquedo = " + cod_produto.ToString();
                if (banco.Deleta(sql))

                    retorno = true;

                else
                    retorno = false;
            }

            else
            {
                retorno = false;

                return retorno;
            }

            return retorno;

        }

        }



    }

