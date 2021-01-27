using GradingLog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Models
{
    public class EntitiesModel
    {
        public TeacherEntity teacherEntity { get; set; }
        public StudentEntitiy studentEntitiy { get; set; }
        public List<StudentEntitiy> StudentsEntity { get; set; }
        public List<TeacherEntity> TeachersEntity { get; set; }
        public List<SchoolSubjectEntity> SchoolSubjectsEntity { get; set; }
        public List<ScheduleEntity> SchedulesEntity { get; set; }
        public List<GradeEntity> GradesEntity { get; set; }
    }
}
