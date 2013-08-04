namespace MySql.N.Json
{
    class Program
    {
        static void Main(string[] args)
        {
            ExportArguments exportArgs = ExportArgumentsHelper.Parse(args);
            Exporter.Export(exportArgs);
        }
    }
}
