using Calcados.DTO.Calcados.AtualizarCalcado;

namespace Calcados.UseCase
{
    public interface IAtualizarCalcadosUseCase
    {
        AtualizarCalcadoResponse Executar(AtualizarCalcadoRequest request, int id);
    }
}
