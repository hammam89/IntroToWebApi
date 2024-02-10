using IntroToWebApi.Entities;
using IntroToWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroToWebApi.Controllers
{
    public class DeptsController : Controller
    {

        private readonly HRDbContext _dbContext;


        public DeptsController(HRDbContext dbContext)
        {

            _dbContext = dbContext;

        }
        [HttpGet]
        
        public IActionResult Index()
        {
            var Depts = _dbContext.departments.ToListAsync().Result;

            return View(Depts);
          
        }
    }
}
