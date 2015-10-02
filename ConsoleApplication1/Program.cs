using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new LibraryModule());
            var std1 = kernel.Get<Student>();
            var context = kernel.Get<DbContext>();
            var repo = kernel.Get<IRepository>();
          //  IRepository repo = new Repository(context);

        }
    }
}
