using Calcados.Bordas.Repositórios;
using Calcados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcados.Repositórios
{
    public class SelectRepository : IRepositorioRetornar
    {
        private readonly CalcadoContext _local;

        public SelectRepository(CalcadoContext local)
        {
            _local = local;
        }
               
        
        public void Select()
        {
            //_local.CalcadoItems.Select();
            _local.SaveChanges();            
        }
    }
}
