﻿using Xunit.Abstractions;

namespace AbanLibTests.facility;

public class TestTest(ITestOutputHelper output) : Test
{
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
	public void CreatesTempDirectoryOnConstruction()
	{
		Assert.True(Path.Exists(DirectoryPath));
	}
}