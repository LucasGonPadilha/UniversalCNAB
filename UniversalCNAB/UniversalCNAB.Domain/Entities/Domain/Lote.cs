using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCNAB.Domain.Entities.Domain
{
    public class Lote
    {
        public RegistroHeaderLote RegistroHeaderLote { get; set; }
        public RegistroInicialLote RegistroInicialLote { get; set; }
        public List<RegistroDetalheSegmento> RegistroDetalheSegmento { get; set; }
        public RegistroFinalLote RegistroFinalLote { get; set; }
        public RegistroTrailerLote RegistroTrailerLote { get; set; }
    }
}
