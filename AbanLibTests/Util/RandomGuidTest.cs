using AbanLib.Util;
using AbanLibTests.TestFacility;
using Xunit.Abstractions;

namespace AbanLibTests.Util;

public class RandomGuidTest(ITestOutputHelper output) : Test
{
	[Fact]
	public void GenerateGuid()
	{
		Guid.Parse(Rand.GuidString);
	}

	[Fact]
	public void MakeSureGuidsAreDifferent1()
	{
		output.WriteLine(DirectoryName);
	}

	[Fact]
	public void MakeSureGuidsAreDifferent2()
	{
		output.WriteLine(DirectoryName);
	}

	[Fact]
	public void GuidStringGivesNewGuidEachTime()
	{
		var g1 = Rand.GuidString;
		var g2 = Rand.GuidString;
		var g3 = Rand.GuidString;
		Assert.NotEqual(g1, g2);
		Assert.NotEqual(g2, g3);
		Assert.NotEqual(g3, g1);
		Assert.NotEqual(Rand.GuidString, Rand.GuidString);
		Assert.NotEqual(Rand.GuidString, Rand.GuidString);
		Assert.NotEqual(Rand.GuidString, Rand.GuidString);
	}
}