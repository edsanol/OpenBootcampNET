using Microsoft.EntityFrameworkCore;
using OpenBootcamp.Models.DataModels;

namespace OpenBootcamp.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }

        // TODO: Add DbSets (Tables of our DataBase)
        public DbSet<User>? Users { get; set; }

        public DbSet<Curso> Cursos { get; set; }
    }
}
