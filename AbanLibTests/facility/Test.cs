namespace AbanLibTests.facility;

public abstract class Test : IDisposable
{
	protected readonly string DirectoryName;
	protected readonly string DirectoryPath;

	protected Test()
	{
		DirectoryName = $"AbLibTest-{AbanLib.Rand.GuidString}";
		var tempDirectory = Path.GetTempPath();
		DirectoryPath = Path.Combine(tempDirectory, DirectoryName);
		Directory.CreateDirectory(DirectoryPath);
	}


	public virtual void Dispose()
	{
		GC.SuppressFinalize(this);
		if (Directory.Exists(DirectoryPath)) Directory.Delete(DirectoryPath, true);
	}

	public static Type[] SubTypesOf<T>()
	{
		return AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(domainAssembly => domainAssembly.GetTypes())
			.Where(type => typeof(T).IsAssignableFrom(type))
			.ToArray();
	}
}