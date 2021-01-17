using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Entities
{
    [Table("Schedules")]
    public class ScheduleEntity
    {
        [Key]
        public int Id { get; set; }
        public StudentEntitiy Student { get; set; }
        public SchoolSubjectEntity SchoolSubject { get; set; }
    }
}
