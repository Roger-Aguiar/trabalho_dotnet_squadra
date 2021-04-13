using Bogus;
using Calcados.DTO.Calcados.AdicionarCalcado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2Teste.Builder
{
    public class AdicionarCalcadoRequestBuilder
    {
        private readonly Faker faker = new Faker("pt_BR");
        private readonly AdicionarCalcadoRequest adicionarCalcadoRequest;

        public AdicionarCalcadoRequestBuilder()
        {            
            adicionarCalcadoRequest = new AdicionarCalcadoRequest();
            adicionarCalcadoRequest.Material = faker.Random.String(10);
            adicionarCalcadoRequest.Modelo = faker.Random.String(10);
        }

        public AdicionarCalcadoRequestBuilder WithMaterialLength(int tamanho)
        {
            adicionarCalcadoRequest.Material = faker.Random.String(tamanho);
            return this;
        }

        public AdicionarCalcadoRequest Build()
        {
            return adicionarCalcadoRequest;
        }
    }
}
