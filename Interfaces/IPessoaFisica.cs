using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_backend.Interfaces
{
    public interface IPessoaFisica
    {
        //bool ValidarDataNasc(DateTime dataNasc);
        bool ValidarDataNascimento(string dataNasc);
    }
}