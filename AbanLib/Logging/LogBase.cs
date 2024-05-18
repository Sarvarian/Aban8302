namespace AbanLib.Logging;

public abstract class LogBase(DateTime logTime) : ILog
{
	protected LogBase() : this(DateTime.Now)
	{
	}

	public DateTime Time { get; init; } = logTime;
	public ILog? PreviousLog { get; protected set; } = null;
	public ILog? NextLog { get; protected set; } = null;

	public abstract ILogElement[] Elements { get; }
	public abstract string Title { get; }
	public abstract string Message { get; }

	public virtual string Formatted => $"{Title}\n{Message}";

	public virtual string FormattedVerbose => Elements.Aggregate($"{Formatted}",
		(current, element) => current + $"\n{element.Name}: {element.DataAsText}");

	object? ILog.ExtraDataForUser { get; set; } = null;
}