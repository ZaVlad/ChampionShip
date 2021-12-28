using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Infrastructure
{
    public static class  AppConnection
    {
        public static string ConnectionStringSettings => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }
}
