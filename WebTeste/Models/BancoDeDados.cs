using Microsoft.EntityFrameworkCore;

namespace WebTeste.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet <MenuDePontos> Jogador { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=WebTeste;Integrated Security=True");
        }
    }
}
