using System.ComponentModel.DataAnnotations;

namespace IntroToWebApi.Entities
{
#nullable disable
    public class Department
    {
        [MaxLength(50)]
        [Required]
        public int Id { get; set; }

        [MaxLength(100)]
        [MinLength(50)]
        [Required]
        public string Name { get; set; }


        public ICollection<Employee> Employees { get; set; }

    }
}
