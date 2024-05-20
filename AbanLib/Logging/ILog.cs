namespace AbanLib.Logging;

public interface ILog
{
	/// <summary>
	///     Time related to the event that the log
	///     represents.
	///     Or time of creation of the log itself.
	/// </summary>
	DateTime Time { get; }

	/// <summary>
	///     Title of the log for quick review.
	/// </summary>
	string Title { get; }

	/// <summary>
	///     A concise message of what happened.
	/// </summary>
	string Message { get; }

	/// <summary>
	///     Fully formatted message for presentation
	///     in console or file.
	/// </summary>
	string Formatted { get; }

	/// <summary>
	///     Fully formatted message for presentation
	///     in console or file with all the information.
	/// </summary>
	string FormattedVerbose { get; }

	/// <summary>
	///     A list of elements of the log message.
	///     May use for serialization in JSON or YAML.
	/// </summary>
	ILogElement[] Elements { get; }

	/// <summary>
	///     Previous log that accrue before this one.
	///     Possibly can be null. Null check before use.
	/// </summary>
	ILog? PreviousLog { get; }

	/// <summary>
	///     Next log that accrue after this one.
	///     Possibly can be null. Null check before use.
	/// </summary>
	ILog? NextLog { get; }

	/// <summary>
	///     For users of this object, like a log manager
	///     or something, to associate some more data to
	///     this log.
	///     Not for the use of the log object itself. May
	///     override by any users of this object at anytime.
	///     So, be carefully using it and insure that you
	///     have sole owner ship and control over the log
	///     so that no one else will override your data.
	/// </summary>
	object? ExtraDataForUser { get; set; }
}