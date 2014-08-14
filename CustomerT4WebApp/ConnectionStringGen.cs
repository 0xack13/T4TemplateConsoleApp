



using System.Configuration;

public static class ConnectionStrings
{

	public static string DefaultConnection
	{
		get { return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; }
	}
	public static string MainConnectionString
	{
		get { return ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString; }
	}
}
