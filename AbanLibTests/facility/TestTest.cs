using Xunit.Abstractions;

namespace AbanLibTests.facility;

public class TestTest(ITestOutputHelper output) : Test
{
	[Fact]
	public void CreatesTempDirectoryOnConstruction()
	{
		Assert.True(Path.Exists(DirectoryPath));
	}

	[Fact]
	public override void Dispose()
	{
		base.Dispose();
		GC.SuppressFinalize(this);
		Assert.False(Path.Exists(DirectoryPath));
	}

	[Fact]
	public void GenerateGuid()
	{
		Guid.Parse(GuidString);
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
		var g1 = GuidString;
		var g2 = GuidString;
		var g3 = GuidString;
		Assert.NotEqual(g1, g2);
		Assert.NotEqual(g2, g3);
		Assert.NotEqual(g3, g1);
		Assert.NotEqual(GuidString, GuidString);
		Assert.NotEqual(GuidString, GuidString);
		Assert.NotEqual(GuidString, GuidString);
	}
}