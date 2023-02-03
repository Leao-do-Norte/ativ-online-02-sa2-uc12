using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_backend.Classes
{
    public class Endereco
    {
        public string? logradouro {get;set;}
        public int numero {get;set;}
        public string? complemento {get;set;}
        public bool endComercial {get;set;}
        public bool endResidencial {get;set;}
    }
}