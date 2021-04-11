using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calcados.Models;
using Microsoft.Extensions.Logging;
using Calcados.Services;
using Calcados.UseCase;
using Calcados.DTO.Calcados.AdicionarCalcado;

namespace Calcados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcadoItemsController : ControllerBase
    {       
        private readonly ILogger<CalcadoItemsController> _logger;
        private readonly ICalcadoService _calcado;
        private readonly IAdicionarCalcadosUseCase _adicionarCalcadoUseCase;

        public CalcadoItemsController(ILogger<CalcadoItemsController> logger, ICalcadoService calcado, IAdicionarCalcadosUseCase adicionarCalcadoUseCase)
        {
            _logger = logger;
            _calcado = calcado;
            _adicionarCalcadoUseCase = adicionarCalcadoUseCase;
        }

        [HttpGet]
        public IActionResult TodosCalcados()
        {
            return Ok(_calcado.RetonarListaCalcado());
        }

        [HttpGet("{id}")]
        public IActionResult calcado(int id)
        {
            return Ok(_calcado.RetornarCalcadoPorId(id));
        }

        [HttpPost]
        public IActionResult calcadoAdd([FromBody] AdicionarCalcadoRequest novoCalcado)
        {
            return Ok(_adicionarCalcadoUseCase.Executar(novoCalcado));
            //return Ok(_calcado.AdicionarCalcado(novoCalcado));
        }

        [HttpPut]
        public IActionResult calcadoUpdate(CalcadoItem novoCalcado)
        {
            return Ok(_calcado.AtualizarCalcado(novoCalcado));
        }

        [HttpDelete("{id}")]
        public IActionResult calcadoDelete(int id)
        {
            return Ok(_calcado.DeletarCalcado(id));
        }
    }
}
