using Calcados.DTO.Calcados.RetornarCalcados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public interface IRetornarCalcadosUseCase
    {
        RetornarCalcadoResponse Executar(RetornarCalcadoRequest request);
    }
}
