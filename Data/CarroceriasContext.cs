using carrocerias.models;
using Microsoft.EntityFrameworkCore;

namespace carrocerias.Data
{
    public class CarroceriasContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarroceriasContext).Assembly);
        }
    }
}
