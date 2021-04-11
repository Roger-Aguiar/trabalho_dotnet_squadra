using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Bordas.Adapter
{
    public interface IAdicionarCalcadoAdapter
    {
        public CalcadoItem ConverterRequestParaResponse(AdicionarCalcadoRequest request);
    }
}
