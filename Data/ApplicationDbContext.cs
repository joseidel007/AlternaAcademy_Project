using alterna_academy_project.Models;
using Microsoft.EntityFrameworkCore;

namespace alterna_academy_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Login> Logins { get; set; }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Logins)
                .WithOne(l => l.Category)
                .HasForeignKey(l => l.CategoryId);
        }*/
        /*        protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    modelBuilder.Entity<Categories>().HasData(
                        new Categories()
                        {
                            Id = 1,
                            CategoryName = "Jobs",
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                        },

                        new Categories()
                        {
                            Id = 2,
                            CategoryName = "Entertainment",
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,    
                        }
                        );
                }*/

    }
}
