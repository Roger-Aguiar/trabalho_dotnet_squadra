using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Repositórios
{
    public interface IRepositorioCalcados
    {
        public void Add(CalcadoItem request);
    }
}
