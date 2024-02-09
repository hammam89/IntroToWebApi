using System.Data.Entity;

namespace IntroToWebApi.Entities
{
#nullable disable 
    public class HRDbContext : DbContext
    {

        public DbSet<Department> departments { get; set; }  
        public DbSet<Employee> employees { get; set; }



    }
}
