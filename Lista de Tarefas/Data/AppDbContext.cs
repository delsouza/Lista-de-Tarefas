using Lista_de_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Lista_de_Tarefas.Data
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {}

       public DbSet<TarefaViewModel> Tarefas { get; set; }
       public DbSet<CategoriaViewModel> Categorias { get; set; }
       public DbSet<StatusViewModel> Statuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<CategoriaViewModel>().HasData(
                new CategoriaViewModel { Id = "trabalho", Nome = "Trabalho" },
                new CategoriaViewModel { Id = "casa", Nome = "Casa" },
                new CategoriaViewModel { Id = "faculdade", Nome = "Faculdade" },
                new CategoriaViewModel { Id = "compras", Nome = "Compras" },
                new CategoriaViewModel { Id = "academia", Nome = "Academia" }
            );

            modelBuilder.Entity<StatusViewModel>().HasData(
                new StatusViewModel { StatusId = "incompleto", Nome = "Incompleto" },
                new StatusViewModel { StatusId = "completo", Nome = "Completo" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
