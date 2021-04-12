using Calcados.DTO.Calcados.AtualizarCalcado;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Bordas.Adapter
{
    public interface IUpdateCalcadosAdapter
    {
        public CalcadoItem ConverterDeRequestParaResponse(AtualizarCalcadoRequest request);
    }
}
