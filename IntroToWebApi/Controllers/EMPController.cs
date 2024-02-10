using IntroToWebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroToWebApi.Controllers
{
    public class EMPController : Controller
    {

        private readonly HRDbContext _dbContext;


        public EMPController(HRDbContext dbContext)
        {

            _dbContext = dbContext;

        }
        public IActionResult Index()
        {
            var emp = _dbContext.employees.ToListAsync().Result;

            return View(emp);

        }
    }
}
