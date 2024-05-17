namespace AbanLib.Logging;

public readonly struct LogElementString(string name, string data) : ILogElement
{
	string ILogElement.Name => name;
	object ILogElement.Data => data;
	string ILogElement.DataAsText => data;
}