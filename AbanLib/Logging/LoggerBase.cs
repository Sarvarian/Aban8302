namespace AbanLib.Logging;

public abstract class LoggerBase : ILogger
{
	public LoggerBase(string name)
	{
		Name = name;
	}

	public string Name { get; }
}