using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMDCleriston.ConexaoBD
{
    public static class ConexaoBancoDados
    {
        public static string conn_ { get; } = @"Host=localhost;Port=5432;Username=postgres;Password=41529166;Database=Teste";
    }
}
