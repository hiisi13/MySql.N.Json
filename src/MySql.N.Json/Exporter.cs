using Massive;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.N.Json
{
    public static class Exporter
    {
        public static void Export(ExportArguments exportArgs)
        {
            var connStrBuilder = new MySqlConnectionStringBuilder
            {
                Server = exportArgs.Server,
                UserID = exportArgs.User,
                Password = exportArgs.Password,
                Database = exportArgs.Database
            };
            var model = new DynamicModel(connStrBuilder.ConnectionString, exportArgs.Table);
            string json = JsonConvert.SerializeObject(model.All());
            Console.WriteLine(json);
        }
    }
}
