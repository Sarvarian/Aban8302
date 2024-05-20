using System.Globalization;

namespace AbanLib.Logging;

public readonly struct LogElementFloat(string name, float data) : ILogElement
{
	string ILogElement.Name => name;
	object ILogElement.Data => data;
	string ILogElement.DataAsText => data.ToString(CultureInfo.InvariantCulture);
}