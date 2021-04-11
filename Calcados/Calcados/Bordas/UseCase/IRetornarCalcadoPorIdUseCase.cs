using Calcados.DTO.Calcados.RetornarCalcadoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public interface IRetornarCalcadosPorIdUseCase
    {
        RetornarCalcadoPorIdResponse Executar(RetornarCalcadoPorIdRequest request);
    }
}
