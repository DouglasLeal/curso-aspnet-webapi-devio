using ApiBasica.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiBasica.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
