using ConfiguredPostSharp.Configuration;
using ConfiguredPostSharp.Configuration.Providers;
using Ninject;
using NinjectResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguredPostSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IKernel kernel = new StandardKernel())
            {

                kernel.Load(typeof(ConfiguredPostSharpModule).Assembly);
                

                var tc = kernel.Get<ICacheProvider>();
                tc.Insert("", "", 2);
            }
           //var t = new Class1().Test<string>("drtdrtd",3);
           //Console.WriteLine(t);
           Console.ReadLine();
        }

        
    }
}
