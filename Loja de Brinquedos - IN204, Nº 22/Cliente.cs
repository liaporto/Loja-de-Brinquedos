using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string TelCelular { get; private set; }
       


        //Método que atualiza os dados de cadastro
        public bool AlteraAtributo(string Nome_, string CPF_, DateTime DataNascimento_, 
            string Email_, string TelCelular_)
        {
            CriticaDados novo = new CriticaDados();
            bool retorno = true;

            if (novo.VerificaLetra_Ponto_Traco(Nome_))
            {
                Nome = Nome_;
            }

            else
                retorno = false;

            if (novo.VerificaNum_Ponto_Traco(CPF_))
            {
                CPF = CPF_;
            }
            else
                retorno = false;

            DataNascimento = DataNascimento_;

            if (novo.VerificaLetra_Ponto_Arroba(Email_))
            {
                Email = Email_;
            }
            else
                retorno = false;

            if (novo.VerificaNum_Parenteses_Traco(TelCelular_))
            {
                TelCelular = TelCelular_;
            }
            else
                retorno = false;
          
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
                string sql = "INSERT INTO tab_cliente(nome, cpf, email, tel_celular, datanasc) VALUES ('" + Nome + "', '" +
                    CPF + "', '" + Email + "', '" + TelCelular + "', '" + DataNascimento.ToString("yyyy-MM-dd") + "')";

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

        public List<Cliente> BuscaClientesBanco(string NomeCliente)
        {
            List<Cliente> lista = new List<Cliente>();
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_cliente where nome like '" + NomeCliente + "%'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Cliente novo = new Cliente();
                novo.Nome = Convert.ToString(dt.Rows[i]["nome"]);
                novo.CPF = dt.Rows[i]["cpf"].ToString();
                novo.Email = dt.Rows[i]["email"].ToString();
                novo.TelCelular = dt.Rows[i]["tel_celular"].ToString();
                novo.DataNascimento = Convert.ToDateTime(dt.Rows[i]["datanasc"]);
               
                
                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }
        public List<Cliente> BuscaClientesCPFBanco(string CPF)
        {
            List<Cliente> lista = new List<Cliente>();
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            Cliente novo = new Cliente();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_cliente where cpf = '" + CPF + "'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                novo.CPF = Convert.ToString(dt.Rows[i]["cpf"]);
                novo.Nome = Convert.ToString(dt.Rows[i]["nome"]);
                novo.DataNascimento = Convert.ToDateTime(dt.Rows[i]["datanasc"]);
                novo.Email = dt.Rows[i]["email"].ToString();
                novo.TelCelular = dt.Rows[i]["tel_celular"].ToString();
                novo.DataNascimento = Convert.ToDateTime(dt.Rows[i]["datanasc"]);

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }

        public List<Cliente> BuscaClientesNomeBanco(string NomeCliente)
        {
            List<Cliente> lista = new List<Cliente>();
            DataTable dt = new DataTable();
            BDLP banco = new BDLP();
            if (banco.Conecta())
            {
                string sql = "Select * from tab_cliente where nome = '" + NomeCliente + "'";
                dt = banco.Busca(sql);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Cliente novo = new Cliente();
                novo.Nome = Convert.ToString(dt.Rows[i]["nome"]);
                novo.CPF = dt.Rows[i]["cpf"].ToString();
                novo.Email = dt.Rows[i]["email"].ToString();
                novo.TelCelular = dt.Rows[i]["tel_celular"].ToString();
                novo.DataNascimento = Convert.ToDateTime(dt.Rows[i]["datanasc"]);

                lista.Add(novo);
            }
            banco.Desconecta();
            return lista;
        }

        public bool AlteraClientesBanco()
        {
            bool retorno = true;
            BDLP banco = new BDLP();

            if (banco.Conecta())
            {
                string sql = "UPDATE tab_cliente SET nome = '" + Nome +
                    "', datanasc = '" + DataNascimento.ToString("yyyy-MM-dd") +
                    "', email = '" + Email +
                    "', tel_celular = '" + TelCelular +
                    "' where cpf = '" + CPF + "';";
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

        public bool DeletaClientesBanco()
        {
            bool retorno = true;
            BDLP banco = new BDLP();

            if (banco.Conecta())
            {
                string sql = "DELETE FROM tab_cliente where cpf = '" + CPF + "';";
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

