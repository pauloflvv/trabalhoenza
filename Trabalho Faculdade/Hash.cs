using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Faculdade
{
    public class Hash
    {
        public string CriptografarSenha(string senha)
        {
            // Encoding = codificação de caracteres
            // ANSI, ASCII, Unicode, UTF
            var valorCodificado = Encoding.UTF8.GetBytes(senha);

            //ComputeHash = calcula o valor de hash para os dados da entrada
            var senhaCriptografada = SHA1.Create().ComputeHash(valorCodificado);

            //String = imutável
            //StringBuilder = mutável
            StringBuilder stringBuilder = new StringBuilder();

            // Passa por cada byte e formata cada um para uma string hexadecimal
            for (int contador = 0; contador < senhaCriptografada.Length; contador++)
            {
                // ToString = Converte o valor byte no seu equivalente em HexaDecimal
                // x = hexadecimal
                // 2 = quantidade caracteres
                stringBuilder.Append(senhaCriptografada[contador].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public bool CompararSenha(string senhaDigitada, string senhaCadastrada)
        {
            var senhaDigitadaCripto = CriptografarSenha(senhaDigitada);
            return senhaDigitadaCripto == senhaCadastrada;
        }
    }
}
