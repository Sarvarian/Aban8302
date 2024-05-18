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

	public virtual string Formatted => GenerateFormatted();
	public virtual string FormattedVerbose => GenerateFormattedVerbose();

	object? ILog.ExtraDataForUser { get; set; } = null;

	private string GenerateFormatted()
	{
		return $"{Title}\n{Message}";
	}

	private string GenerateFormattedVerbose()
	{
		var start = $"{Formatted}";
		return Elements.Aggregate(start, (current, element) => current + $"\n{element.Name}: {element.DataAsText}");
	}
}