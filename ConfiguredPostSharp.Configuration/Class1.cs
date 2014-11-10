using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguredPostSharp.Configuration
{
    public class Class1
    {
        [Exception]
        [MethodBoundary]
        public string Test<T>(string p1, int p2)
        {
            return 1.ToString();
        }
    }
}
