using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GradingLog.Models;
using GradingLog.Database;

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
                    var students = _dbContext.Students.Where(a => a.Login == user.Login).Single();

                    if (students.Login == user.Login && students.Password == user.Password)
                    {
                        var student = new Student
                        {
                            Id = students.Id,
                            Login = students.Login,
                            Password = students.Password,
                            FirstName = students.FirstName,
                            LastName = students.LastName,
                            Semester = students.Semester
                        };
                        return View("StudentView", student);
                    }
                    //login error view or error message
                    return View();
                } 

         
                var IsTeacher = _dbContext.Teachers.Any(a => a.Login == user.Login);

                if (IsTeacher == true)
                {
                    var teachers = _dbContext.Teachers.Where(a => a.Login == user.Login).Single();

                    if(teachers.Login == user.Login && teachers.Password == user.Password)
                    {
                        var teacher = new Teacher
                        {
                            Id = teachers.Id,
                            Login = teachers.Login,
                            Password = teachers.Password,
                            FirstName = teachers.FirstName,
                            LastName = teachers.LastName,
                            Title = teachers.Title
                        };

                        return View("TeacherView", teacher);
                    }
                    //login error view or error message
                    return View();
                }
            return View();
        }

    }
}
