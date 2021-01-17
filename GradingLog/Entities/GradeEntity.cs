using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Entities
{
    [Table("Grades")]
    public class GradeEntity
    {
        [Key]
        public int Id { get; set; }
        public TeacherEntity Teacher { get; set; }
        public StudentEntitiy Student { get; set; }
        public SchoolSubjectEntity SchoolSubject { get; set; }
        public float Grade { get; set; }
    } 
}
