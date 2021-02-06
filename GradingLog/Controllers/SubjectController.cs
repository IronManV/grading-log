using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using GradingLog.Database;
using GradingLog.Entities;
using GradingLog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GradingLog.Controllers
{
    public class SubjectController : Controller
    {
        private readonly GradingLogDbContext _dbContext;

        public SubjectController(GradingLogDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public IActionResult Index(SchoolSubjectEntity schoolSubject)
        {
            if (schoolSubject == null)
            {
                return View();
            }
            var IsSubject = _dbContext.SchoolSubjects.Any(x => x.Id == schoolSubject.Id);

            if (IsSubject == true)
            {
                /* //student entity
                 var subject = */

                var models = new EntitiesModel();

                models.subjectsEntity = _dbContext.SchoolSubjects.Include(x => x.Teacher).Where(x => x.Id == schoolSubject.Id).Single();
                models.SchedulesEntity = _dbContext.Schedules.Include(x => x.SchoolSubject).Include(x => x.Student).Where(x => x.SchoolSubject.Id == schoolSubject.Id).ToList();
                models.GradesEntity = _dbContext.Grades.Include(x => x.Student).Include(x => x.SchoolSubject).Where(x => x.SchoolSubject.Id == schoolSubject.Id).ToList();
                return View(models);
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddGrade(EntitiesModel gradeFormModel)
        {
            var subject = _dbContext.SchoolSubjects.Where(x => x.Id == gradeFormModel.gradeModel.SchoolSubjectId).Single();
            var teacher = _dbContext.Teachers.Where(x => x.Id == gradeFormModel.gradeModel.TeacherId).Single();
            var student = _dbContext.Students.Where(x => x.Id == gradeFormModel.gradeModel.StudentId).Single();

            var addGrade = new GradeEntity
            {
                SchoolSubject = subject,
                Teacher = teacher,
                Student = student,
                Grade = gradeFormModel.gradeModel.Grade,
            };

            _dbContext.Grades.Add(addGrade);
            _dbContext.SaveChanges();

            SendNotification(addGrade.Teacher, addGrade.Grade, addGrade.SchoolSubject, addGrade.Student);

            return View("AddGradeView", addGrade);
        }

        public void SendNotification(TeacherEntity teacher, float grade, SchoolSubjectEntity subject, StudentEntitiy student)
        {
            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("f5955d6c4a5994", "80775e91c1ea73"),
                EnableSsl = true
            };
            string message = $"{teacher.Title} {teacher.FirstName} {teacher.LastName} has just gave you {grade}, from {subject.Name}!";
            client.Send("noreply@gradinglog.com", student.Login, "Grade notification", message);
        }
    }
}
