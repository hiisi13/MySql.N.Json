using NDesk.Options;

namespace MySql.N.Json
{
	public static class ExportArgumentsHelper
	{
		public static ExportArguments Parse(string[] args)
		{
			var exportArgs = new ExportArguments();
			var optionsSet = new OptionSet
			{
				{ "s=|server=", s => exportArgs.Server = s },
				{ "u=|user=", u => exportArgs.User = u },
				{ "p=|password=", p => exportArgs.Password = p },
				{ "t=|table=", t => exportArgs.Table = t },
				{ "d=|database=", d => exportArgs.Database = d },
				{ "e=|execute=", e => exportArgs.Query = e}
			};
			optionsSet.Parse(args);
			return exportArgs;
		}
	}
}
