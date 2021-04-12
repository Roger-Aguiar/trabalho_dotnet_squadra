using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calcados.Services;
using Calcados.UseCase;
using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.DTO.Calcados.RetornarCalcadoPorId;
using Calcados.DTO.Calcados.AtualizarCalcado;
using Calcados.DTO.Calcados.DeletarCalcado;

namespace Calcados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcadoItemsController : ControllerBase
    {      
        
        private readonly IAdicionarCalcadosUseCase _adicionarCalcadoUseCase;
        private readonly IRetornarCalcadosUseCase _calcadosSelecionados;
        private readonly IRetornarCalcadosPorIdUseCase _calcadoPorId;
        private readonly IAtualizarCalcadosUseCase _atualizacao;
        private readonly IDeletarCalcadosUseCase _delete;

        public CalcadoItemsController(ILogger<CalcadoItemsController> logger, ICalcadoService calcado, 
                                      IAdicionarCalcadosUseCase adicionarCalcadoUseCase,
                                      IRetornarCalcadosUseCase calcadosSelecionados,
                                      IRetornarCalcadosPorIdUseCase calcadoPorId,
                                      IAtualizarCalcadosUseCase atualizacao,
                                      IDeletarCalcadosUseCase delete)
        {
            
            _adicionarCalcadoUseCase = adicionarCalcadoUseCase;
            _calcadosSelecionados = calcadosSelecionados;
            _calcadoPorId = calcadoPorId;
            _atualizacao = atualizacao;
            _delete = delete;
        }
                
        [HttpGet]
        public IActionResult ObterListaDeCalcados()
        {
            return Ok(_calcadosSelecionados.Executar());
        }
                
        [HttpGet("{id}")]
        public IActionResult ObterCalcadoPorId(int id)
        {
            if(id <= 0)
            {
                return BadRequest("Código inválido!");
            }
            else
            {
                var request = new RetornarCalcadoPorIdRequest();
                request.id = id;
                return Ok(_calcadoPorId.Executar(request));
            }           
        }

        [HttpPost]
        public IActionResult calcadoAdd([FromBody] AdicionarCalcadoRequest novoCalcado)
        {
            return Ok(_adicionarCalcadoUseCase.Executar(novoCalcado));            
        }
                
        [HttpPut("{id}")]
        public IActionResult CalcadoUpdate([FromBody] AtualizarCalcadoRequest calcado, int id)
        {
            if (id <= 0)
                return BadRequest("Produto não encontrado.");
            else
                return Ok(_atualizacao.Executar(calcado, id));
        }

        [HttpDelete("{id}")]
        public IActionResult CalcadoDelete(int id)
        {
            if(id <= 0)
            {
                return BadRequest("Produto não encontrado, verifique o código e tente novamente.");
            }
            else
            {
                var request = new DeletarCalcadoRequest();
                request.id = id;
                return Ok(_delete.Executar(request));
            }
        }
    }
}
