﻿using ConfiguredPostSharp.Configuration.Providers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectResolver
{
    public class ConfiguredPostSharpModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICacheProvider>().To<CacheProvider>();
        }

        public static T Get<T>()
        { 
            return 
        }
    
    }
}
