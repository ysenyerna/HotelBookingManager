// Class for logging information, warnings, and errors
namespace HotelBookingManager;
static class Logger
{
	const string Path = "booking_manager.log";

	public static void Info(string message)
	{
		Write("INFO: ", message);
	}

	public static void Warn(string message)
	{
		Write("WARN: ", message);
	}

	public static void Error(string message)
	{
		Write("ERROR: ", message);
	}

	static void Write(string level, string message)
	{
		string line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {level}: {message}";
		try
		{
			File.AppendAllText(Path, line + Environment.NewLine);
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("LOGGING FAILURE: " + ex.Message);
		}
	}
}