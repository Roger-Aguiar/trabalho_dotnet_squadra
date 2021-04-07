using Microsoft.EntityFrameworkCore;

namespace Calcados.Models
{
    public class CalcadoContext : DbContext
    {
        public CalcadoContext(DbContextOptions<CalcadoContext> options) : base(options) { }
        public DbSet<CalcadoItem> CalcadoItems { get; set; }        
    }
}
