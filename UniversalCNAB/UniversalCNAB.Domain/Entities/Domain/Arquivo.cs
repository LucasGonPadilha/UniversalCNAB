using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCNAB.Domain.Entities.Domain
{
    public class Arquivo
    {
        public RegistroHeaderArquivo RegistroHeaderArquivo { get; set; }
        public List<Lote> Lotes { get; set; }
        public RegistroTrailerArquivo RegistroTrailerArquivo { get; set; }
    }
}
