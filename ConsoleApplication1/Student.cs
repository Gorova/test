using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public int Age { get; set; }

        public Cource cources { get; set; }
    }
}
