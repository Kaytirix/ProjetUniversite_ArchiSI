using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Universite.Model;

namespace Universite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Etudiant>? Etudiant { get; set; }

        public DbSet<Note>? Notes { get; set; }

        public DbSet<Enseignant>? Enseignants { get; set; }

        public DbSet<UE>? UE { get; set; }

        public DbSet<Formation>? Formation { get; set; }
        public DbSet<Universite.Model.Enseigner> Enseigner { get; set; } = default!;
    }
}
