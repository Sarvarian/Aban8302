namespace AbanLibTests.TestFacility;

public class TestTest : Test
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
}