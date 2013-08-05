namespace MySql.N.Json
{
	public class ExportArguments
	{
		public string Server { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
		public string Table { get; set; }
		public string Database { get; set; }
		public string OutputFieName { get; set; }
		public string Query { get; set; }

		public bool UseQuery { get { return !string.IsNullOrEmpty(Query); } }
	}
}