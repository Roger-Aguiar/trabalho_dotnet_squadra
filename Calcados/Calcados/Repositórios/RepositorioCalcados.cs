using Calcados.DTO.Calcados.AdicionarCalcado;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Repositórios
{
    public class RepositorioCalcados : IRepositorioCalcados
    {
        private CalcadoContext _local;

        public RepositorioCalcados(CalcadoContext local)
        {
            _local = local;
        }

        public void Add(CalcadoItem request)
        {
            _local.CalcadoItems.Add(request);
            _local.SaveChanges();
        }

        public List<CalcadoItem> ObterListaDeCalcados()
        {
            return _local.CalcadoItems.ToList();            
        }
    }
}
