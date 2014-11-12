using Shared;
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
            System.Web.HttpContext.Current.Cache.Insert(CacheKey, Value, null, DateTime.Now.AddSeconds(Duration), System.Web.Caching.Cache.NoSlidingExpiration);
        }

        public void InsertWithFileDependancy(string CacheKey, object Value, int Duration, string FileName)
        {
            log4net.ILog l = null;
            
            System.Web.HttpContext.Current.Cache.Insert(CacheKey, Value, new System.Web.Caching.CacheDependency(FileName), DateTime.Now.AddSeconds(Duration), System.Web.Caching.Cache.NoSlidingExpiration);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object GetValue(string CacheKey)
        {
            return System.Web.HttpContext.Current.Cache.Get(CacheKey);
        }
    }
}
