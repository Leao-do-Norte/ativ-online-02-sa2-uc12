using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prog_backend.Interfaces;

namespace prog_backend.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get;set;}
        public float rendimento{get;set;}
        public Endereco? endereco {get;set;}
        public abstract float CalcularImposto (float rendimento);
    }
}