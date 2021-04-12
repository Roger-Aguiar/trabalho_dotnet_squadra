using Calcados.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Calcados.Services
{
    public class CalcadoService : ICalcadoService
    {
        private readonly CalcadoContext _local;

        public CalcadoService(CalcadoContext local)
        {
            _local = local;
        }

        public bool AdicionarCalcado(CalcadoItem calcado)
        {

            _local.CalcadoItems.Add(calcado);
            _local.SaveChanges();
            return true;           
        }

        public bool AtualizarCalcado(CalcadoItem novoCalcado)
        {
            _local.CalcadoItems.Attach(novoCalcado);
            _local.Entry(novoCalcado).State = EntityState.Modified;
            _local.SaveChanges();
            return true;           
        }

        public bool DeletarCalcado(int id)
        {
            var objApagar = _local.CalcadoItems.Where(calcado => calcado.Id == id).FirstOrDefault();
            _local.CalcadoItems.Remove(objApagar);
            _local.SaveChanges();
            return true;
            
        }

        public List<CalcadoItem> RetonarListaCalcado()
        {
            return _local.CalcadoItems.ToList();
        }

        public CalcadoItem RetornarCalcadoPorId(int id)
        {
            return _local.CalcadoItems.Where(calcado => calcado.Id == id).FirstOrDefault();
        }
    }
}
