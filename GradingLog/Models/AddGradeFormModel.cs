using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Models
{
    public class AddGradeFormModel
    {
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int SchoolSubjectId { get; set; }
        public float Grade { get; set; }
    }
}
