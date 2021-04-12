using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.DTO.Calcados.RetornarCalcados
{
    public class SelecionarCalcadosResponse
    {
        public List<CalcadoItem> calcados { get; set; }
        public string msg { get; set; }
    }
}
