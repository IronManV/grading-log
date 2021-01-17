using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Entities
{
    [Table("SchoolSubjects")]
    public class SchoolSubjectEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TeacherEntity Teacher { get; set; }
    }
}

