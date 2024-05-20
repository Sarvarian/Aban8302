using AbanLib.Logging;
using AbanLib.Util;

namespace AbanLibTests.TestFacility;

public class RandomLogger : LoggerBase
{
	private RandomLogger() : base(Rand.RandomString)
	{
	}

	public static ILogger Create()
	{
		return new RandomLogger();
	}
}