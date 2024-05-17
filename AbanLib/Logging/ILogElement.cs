namespace AbanLib.Logging;

public interface ILogElement
{
	string Name { get; }
	object Data { get; }
	string DataAsText { get; }
}