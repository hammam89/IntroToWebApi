using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroToWebApi.Entities
{
#nullable disable   
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [MinLength(4)]
        [Required]
        public string FullName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Level { get; set; }
        [Range(0,100)]
        public int Mark { get; set; }
        [MaxLength(50)]
        [Required]
        public String SchoolName { get; set; }

       
        public int CityId { get; set;}
        [ForeignKey(nameof(CityId))]
        public City City { get; set;}

    }
}
