using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Loja_de_Brinquedos___IN204__Nº_22
{
    class BDLP
    {
        private MySqlConnection bdConn;

        public bool Conecta()
        {
            bool retorno = true;

            bdConn = new MySqlConnection("server=localhost;database=bdlp;uid=root;pwd=''");
            try
            {
                bdConn.Open();
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public bool Insere(string sql)
        {
            bool retorno = true;
            try
            {
                MySqlCommand commS = new MySqlCommand(sql, bdConn);
                commS.BeginExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public bool Altera(string sql)
        {
            bool retorno = true;

            try
            {
                MySqlCommand commS = new MySqlCommand(sql, bdConn);
                commS.BeginExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }


        public bool Deleta(string sql)
        {
            bool retorno = true;
            try
            {
                MySqlCommand commS = new MySqlCommand(sql, bdConn);
                commS.BeginExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public DataTable Busca(string sql)
        {
            DataTable dtable;
            DataSet bdDataSet = new DataSet();

            MySqlCommand cmd = new MySqlCommand(sql, bdConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(bdDataSet, "tabela");
            dtable = bdDataSet.Tables["tabela"];

            return dtable;
        }


        public void Desconecta()
        {
            bdConn.Close();
        }
    }

    }
}
