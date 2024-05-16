namespace AbanLibTests.facility;

public abstract class Test : IDisposable
{
	protected readonly string DirectoryName;
	protected readonly string DirectoryPath;

	protected Test()
	{
		DirectoryName = $"AbLibTest-{GuidString}";
		var tempDirectory = Path.GetTempPath();
		DirectoryPath = Path.Combine(tempDirectory, DirectoryName);
		Directory.CreateDirectory(DirectoryPath);
	}

	protected static string GuidString => Guid.NewGuid().ToString();

	public virtual void Dispose()
	{
		GC.SuppressFinalize(this);
		if (Directory.Exists(DirectoryPath)) Directory.Delete(DirectoryPath, true);
	}
}