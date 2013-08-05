using System.Collections.Generic;
using Massive;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;

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
			IEnumerable<dynamic> records = exportArgs.UseQuery ? model.Query(exportArgs.Query) : model.All();
			string json = JsonConvert.SerializeObject(records);
			Console.WriteLine(json);
		}
	}
}
