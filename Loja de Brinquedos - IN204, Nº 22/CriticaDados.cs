using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    class CriticaDados
    {
        //Nome
        public bool VerificaLetra_Ponto_Traco(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if(!char.IsLetter(c[i]) && !char.IsWhiteSpace(c[i]) && c[i] != '.' && c[i] != '-')

                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        //CPF
        public bool VerificaNum_Ponto_Traco(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsDigit(c[i]) && c[i] != '.' && c[i] != '-' && texto.Length > 14)

                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        //Telefone
        public bool VerificaNum_Parenteses_Traco(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsDigit(c[i]) && c[i] != '(' && c[i] != ')' && c[i] != '-' && (texto.Length > 14 || texto.Length < 8))

                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        //Email
        public bool VerificaLetra_Ponto_Arroba(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetterOrDigit(c[i]) && c[i] != '.' && c[i] != '@')

                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        public bool VerificaLetra_Num_Ponto_Traco(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetterOrDigit(c[i]) && c[i] != '.' && !char.IsWhiteSpace(c[i]) && c[i] != '-')

                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        //Categoria
        public bool VerificaLetra_Traco(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetter(c[i]) && !char.IsWhiteSpace(c[i]) && c[i] != '-')
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }


        public bool VerificaNum(string texto)
        {
            bool retorno = true;
            int i;
            char[] c = texto.ToCharArray();
            for (i = 0; i < c.Count(); i++)
            {
                if (!char.IsDigit(c[i]))
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }
    }
}
