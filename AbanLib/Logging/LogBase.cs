namespace AbanLib.Logging;

public abstract class LogBase(DateTime logTime) : ILog
{
	protected LogBase() : this(DateTime.Now)
	{
	}

	public DateTime Time { get; init; } = logTime;
	public ILog? PreviousLog { get; protected set; } = null;
	public ILog? NextLog { get; protected set; } = null;

	public abstract string Title { get; }
	public abstract string Message { get; }
	public abstract string Formatted { get; }
	public abstract string FormattedVerbose { get; }
	public abstract ILogElement[] Elements { get; }

	object? ILog.ExtraDataForUser { get; set; } = null;
}