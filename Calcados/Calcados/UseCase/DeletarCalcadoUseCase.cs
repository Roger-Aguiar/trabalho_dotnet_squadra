using Calcados.DTO.Calcados.DeletarCalcado;
using Calcados.Repositórios;

namespace Calcados.UseCase
{
    public class DeletarCalcadoUseCase : IDeletarCalcadosUseCase
    {
        private readonly IRepositorioCalcados _repositorioCalcados;

        public DeletarCalcadoUseCase(IRepositorioCalcados repositorioCalcados)
        {
            _repositorioCalcados = repositorioCalcados;
        }

        public DeletarCalcadoResponse Executar(DeletarCalcadoRequest request)
        {
            var response = new DeletarCalcadoResponse();
            var idCalcado = _repositorioCalcados.ObterCalcadoPorId(request.id);

            try
            {
                if (request.id <= 0 || idCalcado == null)
                    response.mensagem = "Produto não encontrado.";

                _repositorioCalcados.Delete(request.id);
                response.mensagem = "Operação realizada com sucesso!";

            }
            catch
            {
                response.mensagem = "Erro ao excluir registro.";                
            }

            return response;            
        }
    }
}
