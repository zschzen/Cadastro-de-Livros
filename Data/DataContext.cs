using Microsoft.EntityFrameworkCore;
using CadastroDeLivros.Models;

namespace CadastroDeLivros.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Livros> Livros { get; set; }

    }
}