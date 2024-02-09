using System.ComponentModel.DataAnnotations;
#nullable disable
namespace IntroToWebApi.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(4)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(100)]
        [Required]

        public string JobTile { get; set; }


        public DateTime BirthDate { get; set; }

        public Sex Sex { get; set; }

        public int DepartmentId { get; set; }
    }
}
