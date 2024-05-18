using AbanLibTests.TestFacility;
using Xunit.Abstractions;

namespace AbanLibTests;

public class UnitTest1(ITestOutputHelper output) : Test
{
	[Fact]
	public void Test1()
	{
		output.WriteLine("Hello, world!");
	}
}