using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IContext
    {
        string GetValue(string key);

        string MapPath(string file);
    }
}
