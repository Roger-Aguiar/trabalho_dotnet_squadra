using Calcados.DTO.Calcados.DeletarCalcado;

namespace Calcados.UseCase
{
    public interface IDeletarCalcadosUseCase
    {
        DeletarCalcadoResponse Executar(DeletarCalcadoRequest request);
    }
}
