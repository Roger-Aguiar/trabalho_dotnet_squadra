using Calcados.DTO.Calcados.AtualizarCalcado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public interface IAtualizarCalcadosUseCase
    {
        AtualizarCalcadoResponse Executar(AtualizarCalcadoRequest request);
    }
}
