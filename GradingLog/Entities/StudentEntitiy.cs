using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradingLog.Entities
{
    [Table("Students")]
    public class StudentEntitiy
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Semester { get; set; }

        public static implicit operator List<object>(StudentEntitiy v)
        {
            throw new NotImplementedException();
        }
    }
}
