using CURDOprationsDimo.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperationsDemo
{
    public class CRUDDbContext : DbContext
    {
        public CRUDDbContext(DbContextOptions<CRUDDbContext> options) : base(options)   
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
