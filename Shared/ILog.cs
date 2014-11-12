using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface ILog
    {
        void Info(string message);
        void Info(string message, Exception ex);
        void Error(object message);
        void Error(object message, Exception ex);

    }
}
