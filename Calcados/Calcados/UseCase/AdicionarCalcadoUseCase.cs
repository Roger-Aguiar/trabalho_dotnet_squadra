using Calcados.Bordas.Adapter;
using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.UseCase
{
    public class AdicionarCalcadoUseCase : IAdicionarCalcadosUseCase
    {
        private readonly IRepositorioCalcados _calcadoRepositorio;
        private readonly IAdicionarCalcadoAdapter _adapter;

        public AdicionarCalcadoUseCase(IRepositorioCalcados calcadoRepositorio, IAdicionarCalcadoAdapter adapter)
        {
            _calcadoRepositorio = calcadoRepositorio;
            _adapter = adapter;
        }

        public AdicionarCalcadoResponse Executar(AdicionarCalcadoRequest request)
        {
            var response = new AdicionarCalcadoResponse();
            try
            {                
                var calcadoAdicionar = _adapter.ConverterRequestParaResponse(request);
                _calcadoRepositorio.Add(calcadoAdicionar);
                response.msg = "Produto adicionado com sucesso!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar calçado.";
                return response;
            }            
        }
    }
}
