namespace AbanLib.Logging;

public readonly struct LogElementBoolean(string name, bool data) : ILogElement
{
	string ILogElement.Name => name;
	object ILogElement.Data => data;
	string ILogElement.DataAsText => data.ToString();
}