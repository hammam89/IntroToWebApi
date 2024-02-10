using System.ComponentModel.DataAnnotations;

namespace IntroToWebApi.Entities
{
#nullable disable
    public class City
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
