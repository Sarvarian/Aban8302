namespace AbanLib.Logging;

public abstract class LogBase : ILog
{
	public abstract DateTime Time { get; }
	public abstract string Title { get; }
	public abstract string Message { get; }
	public abstract string Formatted { get; }
	public abstract string FormattedVerbose { get; }
	public abstract ILogElement[] Elements { get; }

	public ILog? PreviousLog { get; } = null;
	public ILog? NextLog { get; } = null;
	public object? ExtraDataForUser { get; set; } = null;
}