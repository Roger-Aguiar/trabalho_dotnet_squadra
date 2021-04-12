using Calcados.DTO.Calcados.RetornarCalcadoPorId;

namespace Calcados.UseCase
{
    public interface IRetornarCalcadosPorIdUseCase
    {
        RetornarCalcadoPorIdResponse Executar(RetornarCalcadoPorIdRequest request);
    }
}
