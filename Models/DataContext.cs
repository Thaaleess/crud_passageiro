using Microsoft.EntityFrameworkCore;

namespace crud_passageiro.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        public DbSet<Passageiro> Passageiros { get; set; }
    }
}