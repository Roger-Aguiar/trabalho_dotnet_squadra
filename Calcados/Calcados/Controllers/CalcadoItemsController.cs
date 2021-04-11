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

namespace Calcados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcadoItemsController : ControllerBase
    {       
        private readonly ILogger<CalcadoItemsController> _logger;
        private readonly ICalcadoService _calcado;

        public CalcadoItemsController(ILogger<CalcadoItemsController> logger, ICalcadoService calcado)
        {
            _logger = logger;
            _calcado = calcado;
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
        public IActionResult calcadoAdd([FromBody] CalcadoItem novoCalcado)
        {
            return Ok(_calcado.AdicionarCalcado(novoCalcado));
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
