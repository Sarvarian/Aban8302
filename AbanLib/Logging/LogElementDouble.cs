using System.Globalization;

namespace AbanLib.Logging;

public readonly struct LogElementDouble(string name, double data) : ILogElement
{
	string ILogElement.Name => name;
	object ILogElement.Data => data;
	string ILogElement.DataAsText => data.ToString(CultureInfo.InvariantCulture);
}