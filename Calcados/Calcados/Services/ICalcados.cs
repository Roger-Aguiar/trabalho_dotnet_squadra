using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Services
{
    public interface ICalcadoService
    {
        bool AdicionarCalcado(CalcadoItem calcado);
        List<CalcadoItem> RetonarListaCalcado();
        CalcadoItem RetornarCalcadoPorId(int id);
        bool AtualizarCalcado(CalcadoItem novoCalcado);
        bool DeletarCalcado(int id);
    }
}
