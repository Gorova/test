using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Cource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public virtual IList<Student> students { get; set; }
    }
}
