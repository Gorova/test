using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("SchoolContext")
        {
        }

        public IEnumerable<Student> students { get; set; }

        public IEnumerable<Cource> cources { get; set; } 
    }
}
