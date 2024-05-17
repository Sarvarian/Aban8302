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

	public override string Formatted =>
		$"{Title}\n{Message}"; // TODO: Move Formatted and FormattedVerbose to LogBase to get generated base on Title and Message and Elements.

	public override string FormattedVerbose =>
		$"{Formatted}\n..."; // TODO: Write a generator for this in LogBase and before that write a test for the generator routine. 
}