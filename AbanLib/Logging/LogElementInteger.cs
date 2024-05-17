namespace AbanLib.Logging;

public readonly struct LogElementInteger(string name, int data) : ILogElement
{
	string ILogElement.Name => name;
	object ILogElement.Data => data;
	string ILogElement.DataAsText => data.ToString();
}