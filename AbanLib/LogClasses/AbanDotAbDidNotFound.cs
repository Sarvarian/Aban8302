using AbanLib.Logging;

namespace AbanLib.LogClasses;

public class AbanDotAbDidNotFound(string path) : LogBase
{
	public override ILogElement[] Elements =>
	[
		new LogElementString(nameof(path), path)
	];

	public override string Title => "Failed to find 'aban.ab'.";
	public override string Message => $"Could not locate any 'aban.ab' file in directory {path}";
}