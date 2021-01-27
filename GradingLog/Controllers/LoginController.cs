using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GradingLog.Models;
using GradingLog.Database;
using Microsoft.EntityFrameworkCore;

namespace GradingLog.Controllers
{
    public class LoginController : Controller
    {
        private readonly GradingLogDbContext _dbContext;

        public LoginController(GradingLogDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user == null)
            {
                return Index();
            }

            var IsStudent = _dbContext.Students.Any(a => a.Login == user.Login);

            if (IsStudent == true)
            {
                //student entity
                var student = _dbContext.Students.Where(a => a.Login == user.Login).Single();

                if (student.Login == user.Login && student.Password == user.Password)
                {
                    var models = new EntitiesModel();

                    models.studentEntitiy = student;
                    models.SchedulesEntity = _dbContext.Schedules.Include(x => x.SchoolSubject).Include(x => x.SchoolSubject.Teacher).Where(x => x.Student.Id == student.Id).ToList();
                    models.GradesEntity = _dbContext.Grades.Include(x => x.SchoolSubject).Include(x => x.Teacher).Where(x => x.Student.Id == student.Id).ToList();

                    return View("StudentView",  models);
                }

                //login error view or error message
                return Index();
            } 

         
            var IsTeacher = _dbContext.Teachers.Any(a => a.Login == user.Login);

            if (IsTeacher == true)
            {
                //teacher entity
                var teacher = _dbContext.Teachers.Where(a => a.Login == user.Login).Single();

                if(teacher.Login == user.Login && teacher.Password == user.Password)
                {
                    var models = new EntitiesModel();

                    models.teacherEntity = teacher;
                    models.SchoolSubjectsEntity = _dbContext.SchoolSubjects.Where(x => x.Teacher.Id == teacher.Id).ToList();

                    return View("TeacherView", models);
                }

                //login error view or error message
                return Index();
            }
            return Index();
        }
    }
}
