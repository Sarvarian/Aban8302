using AbanLibTests.TestFacility;
using Xunit.Abstractions;

namespace AbanLibTests.Logging;

public class LogBaseTest(ITestOutputHelper output) : Test
{
	[Fact]
	public void Formatted()
	{
		var log = RandomLog.Create();
		var expected = $"{log.Title}\n{log.Message}";
		Assert.Equal(expected, log.Formatted);
	}

	[Fact]
	public void FormattedVerbose()
	{
		var elements = RandomLog.GenerateRandomElements(5);
		var log = RandomLog.Create(elements);
		var expected =
			$"""
				 {log.Formatted}
				 {elements[0].Name}: {elements[0].DataAsText}
				 {elements[1].Name}: {elements[1].DataAsText}
				 {elements[2].Name}: {elements[2].DataAsText}
				 {elements[3].Name}: {elements[3].DataAsText}
				 {elements[4].Name}: {elements[4].DataAsText}
				 """.Trim();
		Assert.Equal(expected, log.FormattedVerbose);
	}

	[Fact]
	public void CheckOutAllTheseLogElements()
	{
		var log = RandomLog.Create();
		output.WriteLine(log.FormattedVerbose);
	}
}