using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GradingLog.Entities;

namespace GradingLog.Database
{
    public class GradingLogDbContext : DbContext
    {
        public GradingLogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentEntitiy> Students { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }
        public DbSet<SchoolSubjectEntity> SchoolSubjects { get; set; }
        public DbSet<ScheduleEntity> Schedules { get; set; }
        public DbSet<GradeEntity> Grades { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
