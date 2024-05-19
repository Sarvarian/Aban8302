using AbanLib.Logging;
using AbanLibTests.TestFacility;

namespace AbanLibTests.Logging;

public class LoggerBaseTest : Test
{
	[Fact]
	public void RandomLoggerCreateGivesILogger()
	{
		var logger = RandomLogger.Create();
		Assert.IsAssignableFrom<ILogger>(logger);
	}
}