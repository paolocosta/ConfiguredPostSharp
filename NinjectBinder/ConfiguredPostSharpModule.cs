
using Ninject.Modules;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebImplementation;

namespace NinjectBinder
{
    public class ConfiguredPostSharpModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICacheProvider>().To<CacheProvider>();
            Bind<IContext>().To<Context>();
        }



    }
}
