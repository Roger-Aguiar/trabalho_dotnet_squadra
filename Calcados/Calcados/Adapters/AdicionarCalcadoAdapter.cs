using Calcados.Bordas.Adapter;
using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Adapters
{
    public class AdicionarCalcadoAdapter : IAdicionarCalcadoAdapter
    {
        public CalcadoItem ConverterRequestParaResponse(AdicionarCalcadoRequest request)
        {
            var novoCalcadoItem = new CalcadoItem();
            novoCalcadoItem.Numeracao = request.Numeracao;
            novoCalcadoItem.Modelo = request.Modelo;
            novoCalcadoItem.Cor = request.Cor;
            novoCalcadoItem.Material = request.Material;
            novoCalcadoItem.Solado = request.Solado;
            novoCalcadoItem.Forro = request.Forro;
            novoCalcadoItem.Palmilha = request.Palmilha;
            novoCalcadoItem.AlturaCano = request.AlturaCano;
            novoCalcadoItem.AlturaSola = request.AlturaSola;
            novoCalcadoItem.Fechamento = request.Fechamento;

            return novoCalcadoItem;
        }
    }
}
