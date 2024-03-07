using Microsoft.EntityFrameworkCore;
using BabbySitter.Models;

namespace BabbySitter.Data
{
    public class BabySitterDbContext : DbContext
    {
        public DbSet<Babysitter> Babysitters { get; set; }
        public DbSet<BabysitterCertificate> BabysitterCertificates { get; set; }
        public DbSet<BabbySitterReview> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Child> Child { get; set; }

        public BabySitterDbContext()
        {
        }

        public BabySitterDbContext(DbContextOptions<BabySitterDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite for local development
            // optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<BabysitterCertificate>()
            //     .HasKey(bc => new { bc.BabysitterId, bc.CertificateId });

            // modelBuilder.Entity<BabysitterCertificate>()
            //     .HasOne(bc => bc.Babysitter)
            //     .WithMany(b => b.BabysitterCertificates)
            //     .HasForeignKey(bc => bc.BabysitterId);

            // modelBuilder.Entity<BabysitterCertificate>()
            //     .HasOne(bc => bc.Certificate)
            //     .WithMany(c => c.BabysitterCertificates)
            //     .HasForeignKey(bc => bc.CertificateId);
        }

        //     2. User and Authentication Models
        // Consider adding user authentication to your app. You might have different types of users (e.g., babysitters, parents). ASP.NET Core Identity can help manage users, passwords, roles, and authentication.

        // Integrate ASP.NET Core Identity: Add IdentityUser and IdentityRole to your DbContext or consider using a separate DbContext for identity management.
        // Authentication and Authorization: Implement JWT (JSON Web Tokens) or use ASP.NET Core Identity's built-in mechanisms for securing your API endpoints.
    }

}