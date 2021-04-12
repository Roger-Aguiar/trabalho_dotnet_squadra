using Calcados.Bordas.Adapter;
using Calcados.DTO.Calcados.AtualizarCalcado;
using Calcados.Models;

namespace Calcados.Adapters
{
    public class UpdateCalcadosAdapter : IUpdateCalcadosAdapter
    {
        public CalcadoItem ConverterDeRequestParaResponse(AtualizarCalcadoRequest request)
        {
            var update = new CalcadoItem();

            update.Numeracao = request.Numeracao;
            update.Modelo = request.Modelo;
            update.Cor = request.Cor;
            update.Material = request.Material;
            update.Solado = request.Solado;
            update.Forro = request.Forro;
            update.Palmilha = request.Palmilha;
            update.AlturaCano = request.AlturaCano;
            update.AlturaSola = request.AlturaSola;
            update.Fechamento = request.Fechamento;

            return update;
        }
    }
}
