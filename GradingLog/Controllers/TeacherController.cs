using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradingLog.Database;
using Microsoft.AspNetCore.Mvc;

namespace GradingLog.Controllers
{
    public class TeacherController : Controller
    {
        private readonly GradingLogDbContext _dbContext;

        public TeacherController(GradingLogDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public IActionResult Index()
        {
            var subjects = _dbContext.SchoolSubjects.ToList();

            return View("Index", subjects);
        }
    }
}
