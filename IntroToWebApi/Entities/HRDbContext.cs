

using Microsoft.EntityFrameworkCore;

namespace IntroToWebApi.Entities
{
#nullable disable 
    public class HRDbContext : DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options):base(options) 
        {
            
        }

        public DbSet<Department> departments { get; set; }  
        public DbSet<Employee> employees { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<City> Cities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //عشان الحقل الجديد required لازم نعطيه ديفولت فاليو
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().Property("SchoolName").HasDefaultValueSql("'-'");

            //عشان نعمل initial data
            modelBuilder.Entity<City>()
                .HasData(
              new City { Id=1,Name= "jerusalem"}
            , new City { Id = 2, Name = "ramallah", }
            , new City { Id = 3, Name = "jenin" });

            modelBuilder.Entity<Student>().Property("CityId").HasDefaultValueSql("1");

        }





    }
}
