using IntroToWebApi.Entities;
using IntroToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
#nullable disable
namespace IntroToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly HRDbContext _dbContext;


        public DepartmentsController(HRDbContext dbContext) { 
        
            _dbContext = dbContext; 

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var depts = await _dbContext.departments.Select(d => new DepartmentListViewModel()
            
            { Id = d.Id, Name = d.Name, EmployeeCount = d.Employees.Count() }).ToListAsync();

            return Ok(depts);
        }
    }
}
