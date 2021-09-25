using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JobC.Data
{
    public class DataContext : DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
             public DbSet<Livro> Livros {get ; set ;}
            
    }
}