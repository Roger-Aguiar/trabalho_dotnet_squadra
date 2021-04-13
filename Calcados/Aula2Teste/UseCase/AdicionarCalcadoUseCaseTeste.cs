using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Calcados.Repositórios;
using Moq;
using Calcados.Bordas.Adapter;
using Calcados.UseCase;
using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Models;
using FluentAssertions;
using Aula2Teste.Builder;

namespace Aula2Teste.UseCase
{
    public class AdicionarCalcadoUseCaseTeste
    {
        private readonly Mock<IRepositorioCalcados> _repositorioCalcados;
        private readonly Mock<IAdicionarCalcadoAdapter> _adicionarCalcadoAdapter;
        private readonly AdicionarCalcadoUseCase _useCase;

        public AdicionarCalcadoUseCaseTeste()
        {
            _repositorioCalcados = new Mock<IRepositorioCalcados>();
            _adicionarCalcadoAdapter = new Mock<IAdicionarCalcadoAdapter>();
            _useCase = new AdicionarCalcadoUseCase(_repositorioCalcados.Object, _adicionarCalcadoAdapter.Object);
        }

        [Fact]
        public void Calcado_AdicionarCalcado_QuandoRetornarSucesso()
        {                           
            var request = new AdicionarCalcadoRequestBuilder().Build();
            var response = new AdicionarCalcadoResponse();
            response.msg = "Produto adicionado com sucesso!";
            
            var calcado = new CalcadoItem();
            //var calcadoId = 1;

            //Observação: O método "Returns" não funciona, dá uma mensagem de que ISetup não contém uma definição de método Returns
            //_repositorioCalcados.Setup(repositorio => repositorio.Add(calcado)).Returns(calcadoId);

            _repositorioCalcados.Setup(repositorio => repositorio.Add(calcado)).Throws(new Exception());
            _adicionarCalcadoAdapter.Setup(adapter => adapter.ConverterRequestParaResponse(request)).Returns(calcado);
                       
            var resultado = _useCase.Executar(request);

            response.Should().BeEquivalentTo(resultado);

        }
    }
}
