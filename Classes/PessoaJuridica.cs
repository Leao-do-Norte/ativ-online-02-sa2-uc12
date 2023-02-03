using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using prog_backend.Interfaces;

namespace prog_backend.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}
        //public string? cnpjInfo {get; set;}
        public string? razaoSocial {get;set;}
        public override float CalcularImposto(float rendimento){

            if (rendimento <= 3000)
            {
                return rendimento*0.03f;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento*0.05f;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento*0.07f;
            }
            else
            {
                return rendimento*0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj){
            // formatos possíveis:
            // xxxxxxxx0001xx     : 14 dígitos
            // xx.xxx.xxx/0001-xx : 18 dígitos

            // para usar o Regex deve ser adicionado 'using System.Text.RegularExpressions;'

            bool retornoCnpjValido = Regex.IsMatch(cnpj,@"(^(\d{14}) | (\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)");

            // o símbolo '@' indica que os caracteres seguintes são do tipo string
            //  ^\d{14}$ --> verificar se tem 14 dígitos decimais ininterruptos

            if (retornoCnpjValido)
            {
                string substringCnpj14 = cnpj.Substring(8,4);

                // Substring(8,4) --> bypassa os 8 primeiros dígitos e analisa os 4 seguintes

                if (substringCnpj14 == "0001")
                {
                    return true;
                    
                }
            }

            string substringCnpj18 = cnpj.Substring(11,4);

                if (substringCnpj18 == "0001")
                {
                    return true;
                    
                }

            return false;

            // sem este último "return false" a funçâo dá erro
        }
    }
}