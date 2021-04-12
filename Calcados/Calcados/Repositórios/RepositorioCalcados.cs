using Calcados.Models;
using System;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
