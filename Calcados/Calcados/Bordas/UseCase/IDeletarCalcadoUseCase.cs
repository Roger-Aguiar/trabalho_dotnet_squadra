using Calcados.DTO.Calcados.DeletarCalcado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public interface IDeletarCalcadosUseCase
    {
        DeletarCalcadoResponse Executar(DeletarCalcadoRequest request);
    }
}
