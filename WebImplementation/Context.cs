using ConfiguredPostSharp.Configuration.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebImplementation
{
   public  class Context:IContext
    {
        public string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }


        public string MapPath(string file)
        {
            return System.Web.HttpContext.Current.Server.MapPath(file);
        }
    }
}
