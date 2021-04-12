using Calcados.Bordas.Adapter;
using Calcados.DTO.Calcados.AtualizarCalcado;
using Calcados.Repositórios;

namespace Calcados.UseCase
{
    public class AtualizarCalcadoUseCase : IAtualizarCalcadosUseCase
    {
        private IRepositorioCalcados _repositorioCalcados;
        private IUpdateCalcadosAdapter _updateAdapter;

        public AtualizarCalcadoUseCase(IRepositorioCalcados repositorioCalcados, IUpdateCalcadosAdapter updateAdapter)
        {
            _repositorioCalcados = repositorioCalcados;
            _updateAdapter = updateAdapter;
        }

        public AtualizarCalcadoResponse Executar(AtualizarCalcadoRequest request, int id)
        {
            var response = new AtualizarCalcadoResponse();
            var calcadoId = _repositorioCalcados.ObterCalcadoPorId(id);

            try
            {
                if(id <= 0 || calcadoId == null)
                {
                    response.mensagem = "Erro ao tentar atualizar";
                    return response;
                }

                var update = _updateAdapter.ConverterDeRequestParaResponse(request);
                update.Id = id;
                _repositorioCalcados.Update(update);
                response.mensagem = "Registro atualizado com sucesso!";
                response.id = (int)update.Id;
                return response;
            }
            catch
            {
                response.mensagem = "Erro ao tentar atualizar o registro.";
                response.id = id;
                return response;
            }
           
        }
    }
}
