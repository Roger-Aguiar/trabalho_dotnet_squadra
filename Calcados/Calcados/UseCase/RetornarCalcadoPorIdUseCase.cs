using Calcados.DTO.Calcados.RetornarCalcadoPorId;
using Calcados.Repositórios;

namespace Calcados.UseCase
{
    public class RetornarCalcadoPorIdUseCase : IRetornarCalcadosPorIdUseCase
    {
        private readonly IRepositorioCalcados _repositorioCalcados;

        public RetornarCalcadoPorIdUseCase(IRepositorioCalcados repositorioCalcados)
        {
            _repositorioCalcados = repositorioCalcados;
        }

        public RetornarCalcadoPorIdResponse Executar(RetornarCalcadoPorIdRequest request)
        {
            var response = new RetornarCalcadoPorIdResponse();
            var calcadoPorId = _repositorioCalcados.ObterCalcadoPorId(request.id);

            try
            {
                if(request.id <= 0 || calcadoPorId == null)
                {
                    response.mensagem = "Produto não encontrado.";
                    return response;
                }
                else
                {
                    response.calcados = _repositorioCalcados.ObterCalcadoPorId(request.id);
                    response.mensagem = "Produto encontrado com sucesso!";
                    return response;
                }
            }
            catch
            {
                response.mensagem = "Falha na busca pelo produto.";
                return response;
            }
        }
    }
}
