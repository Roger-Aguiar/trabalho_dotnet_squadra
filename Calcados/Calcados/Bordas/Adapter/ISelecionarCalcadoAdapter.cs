using Calcados.DTO.Calcados.RetornarCalcados;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Bordas.Adapter
{
    public interface ISelecionarCalcadoAdapter
    {
        public CalcadoItem ConverterRequestParaResponse(SelecionarCalcadosRequest request);
    }
}
