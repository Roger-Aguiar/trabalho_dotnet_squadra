using Calcados.Models;
using System.Collections.Generic;

namespace Calcados.Repositórios
{
    public interface IRepositorioCalcados
    {
        public void Add(CalcadoItem request);
        public List<CalcadoItem> ObterListaDeCalcados();
        public CalcadoItem ObterCalcadoPorId(int id);
        public void Delete(int id);
        public bool Update(CalcadoItem calcado);
    }
}
