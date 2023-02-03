using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prog_backend.Interfaces;

namespace prog_backend.Classes
{
    public class PessoaFisica: Pessoa, IPessoaFisica
    {
        public string? cpf {get;set;}
        //public DateTime dataNasc {get;set;}
        public string? dataNascimento {get;set;}
        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento*0.02f);
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento*0.035f);
            }
            else
            {
                return (rendimento*0.05f);
            }
        }

        // public bool ValidarDataNasc(DateTime dataNasc){

        //     DateTime dataAtual = DateTime.Today;
        //     double idade = (dataAtual - dataNasc).TotalDays/365;
            
        //     if (idade >= 18)
        //     {
        //         return true;
        //     }

        //     return false;
        // }
        // public bool ValidarDataNasc(string dataNasc){
              
        //     if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
        //     {
        //         DateTime dataAtual = DateTime.Today;
        //         double idade = (dataAtual - dataConvertida).TotalDays/365;

        //         Console.WriteLine(idade);

        //         if (idade >= 18)
        //         {
        //             return true;
        //         }
        //     }

        //     return false;
        // }
        public bool ValidarDataNascimento(string dataNasc)
        {   
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)){
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if (anos >= 18){
                    return true;
                }
                return false;  
            } 
            return false; 
        }
    }
}