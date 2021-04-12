using Microsoft.AspNetCore.Mvc;
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
        private readonly IRetornarCalcadosUseCase _calcadosSelecionados;

        public CalcadoItemsController(ILogger<CalcadoItemsController> logger, ICalcadoService calcado, 
                                      IAdicionarCalcadosUseCase adicionarCalcadoUseCase,
                                      IRetornarCalcadosUseCase calcadosSelecionados)
        {
            _logger = logger;
            _calcado = calcado;
            _adicionarCalcadoUseCase = adicionarCalcadoUseCase;
            _calcadosSelecionados = calcadosSelecionados;
        }
                
        [HttpGet]
        public IActionResult ObterListaDeCalcados()
        {
            return Ok(_calcadosSelecionados.Executar());
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
