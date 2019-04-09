using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(string conn) : base(conn)
        {
            Database.SetInitializer<SchoolContext>(null);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
