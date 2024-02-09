using System.ComponentModel.DataAnnotations;

namespace IntroToWebApi.Models
{
#nullable disable
    public class DepartmentListViewModel
    {

        [Display(Name ="#")]
        public int Id { get; set; }


        [Display(Name ="الاسم")]
        public String Name { get; set; }

        [Display(Name = "# of employees")]
        public int EmployeeCount { get; set; }

    }
}
