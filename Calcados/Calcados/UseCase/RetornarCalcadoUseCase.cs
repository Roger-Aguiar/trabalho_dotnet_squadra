using Calcados.DTO.Calcados.RetornarCalcados;
using Calcados.Repositórios;

namespace Calcados.UseCase
{
    public class RetornarCalcadoUseCase : IRetornarCalcadosUseCase
    {
        private readonly IRepositorioCalcados _calcadoRepositorio;
        
        public RetornarCalcadoUseCase(IRepositorioCalcados calcadoRepositorio)
        {
            _calcadoRepositorio = calcadoRepositorio;            
        }
                
        public SelecionarCalcadosResponse Executar()
        {
            var response = new SelecionarCalcadosResponse();
            var listaDeCalcados = _calcadoRepositorio.ObterListaDeCalcados();

            try
            {
                if(listaDeCalcados == null)
                {
                    response.msg = "Nenhum item encontrado.";
                    return response;                    
                }
                else
                {
                    response.calcados = _calcadoRepositorio.ObterListaDeCalcados();
                    response.msg = "Lista de calçados carregada com sucesso!";
                    return response;
                }
            }
            catch
            {
                response.msg = "Falha ao carregar lista de calçados.";
                return response;
            }                        
        }
    }
}
