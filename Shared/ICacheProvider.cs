using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface ICacheProvider
    {
        void Insert(string CacheKey, object Value, int Duration);
        void Clear();
        object GetValue(string CacheKey);

        void InsertWithFileDependancy(string CacheKey, object Value, int Duration, string FileName);
    }
}
