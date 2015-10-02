using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ConsoleApplication1
{
    class LibraryModule : NinjectModule
    {
        public override void Load()
        {
            this.InitializeRepositories();
        }

        private void InitializeRepositories()
        {
            Bind<DbContext>().To<SchoolContext>();
            Bind<IRepository>().To<Repository>();
        }
    }
}
