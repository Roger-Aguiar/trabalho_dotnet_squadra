using Calcados.DTO.Calcados.AdicionarCalcado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public interface IAdicionarCalcadosUseCase
    {
        AdicionarCalcadoResponse Executar(AdicionarCalcadoRequest request);
    }
}
