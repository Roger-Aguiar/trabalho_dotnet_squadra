using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.DTO.Calcados.AdicionarCalcado
{
    public class AdicionarCalcadoRequest
    {
        public int Numeracao { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Material { get; set; }
        public string Solado { get; set; }
        public string Forro { get; set; }
        public string Palmilha { get; set; }
        public string AlturaCano { get; set; }
        public decimal AlturaSola { get; set; }
        public string Fechamento { get; set; }
    }
}
