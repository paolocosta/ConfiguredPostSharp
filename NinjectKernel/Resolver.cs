using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectResolver
{
    public class Resolver
    {
        public static T Get<T>()
        {
            return NinjectKernel.KernelFactory.Kernel.Get<T>();
        }
    
    }
}
