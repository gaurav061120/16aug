using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppExercise.Models;

namespace WebAppExercise.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext (DbContextOptions<CourseDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppExercise.Models.Course> Course { get; set; } = default!;
    }
}
