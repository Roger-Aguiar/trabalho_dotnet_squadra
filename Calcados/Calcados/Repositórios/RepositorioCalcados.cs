using Calcados.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Delete(int id)
        {
            var deleteProduto = _local.CalcadoItems.Where(x => x.Id == id).FirstOrDefault();
            _local.CalcadoItems.Remove(deleteProduto);
            _local.SaveChanges();
        }

        public CalcadoItem ObterCalcadoPorId(int id)
        {
            foreach(CalcadoItem calcado in _local.CalcadoItems)
            {
                if (calcado.Id == id)
                    return calcado;
                else
                    continue;
            }
            return null;
        }

        public List<CalcadoItem> ObterListaDeCalcados()
        {
            return _local.CalcadoItems.ToList();            
        }

        public bool Update(CalcadoItem calcado)
        {
            var local = _local.Set<CalcadoItem>().Local.Where(x => x.Id == calcado.Id).FirstOrDefault();
            
            if (local != null)
            {
                _local.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }

            _local.CalcadoItems.Update(calcado);
            _local.SaveChanges();

            return true;                                                                        
        }
    }
}
