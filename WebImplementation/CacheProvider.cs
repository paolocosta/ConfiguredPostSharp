using ConfiguredPostSharp.Configuration.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebImplementation
{
    public class CacheProvider:ICacheProvider
    {
        public void Insert(string CacheKey, object Value, int Duration)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object GetValue(string CacheKey)
        {
            throw new NotImplementedException();
        }
    }
}
