using Microsoft.EntityFrameworkCore;
using ProArcardeScore.API.Models;

namespace ProArcardeScore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<RegistrarPonto> RegistrarPontos { get; set; }
    }
}