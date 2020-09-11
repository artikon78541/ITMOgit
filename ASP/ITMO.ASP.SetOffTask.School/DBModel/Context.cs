using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public class Context : DbContext
    {
        public Context() : base("SchoolASP")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Performance> Performances { get; set; }

    }
}
