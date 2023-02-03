using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_backend.Interfaces
{
    public interface IPessoa
    {
        float CalcularImposto(float rendimento);
    }
}