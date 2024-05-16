namespace AbanLibTests.facility;

public abstract class Test : IDisposable
{
	protected readonly string DirectoryName;
	protected readonly string DirectoryPath;
	protected readonly string GuidString = Guid.NewGuid().ToString();

	protected Test()
	{
		PreviousGuid = LatestGuid;
		LatestGuid = GuidString;
		DirectoryName = $"AbLibTest-{GuidString}";
		var tempDirectory = Path.GetTempPath();
		DirectoryPath = Path.Combine(tempDirectory, DirectoryName);
		Directory.CreateDirectory(DirectoryPath);
	}

	protected static string PreviousGuid { get; private set; } = "";
	protected static string LatestGuid { get; private set; } = "";

	public virtual void Dispose()
	{
		GC.SuppressFinalize(this);
		if (Directory.Exists(DirectoryPath)) Directory.Delete(DirectoryPath, true);
	}
}