using AbanLib;
using AbanLib.Logging;

namespace AbanLibTests.facility;

public class RandomLog : LogBase
{
	public override ILogElement[] Elements { get; } = GenerateRandomElements();
	public override string Title { get; } = GenerateRandomTitle();
	public override string Message { get; } = GenerateRandomMessage();

	private static ILogElement[] GenerateRandomElements()
	{
		var elements = new List<ILogElement>();
		for (var i = 0; i < Rand.Random.Next(10, 100); i++) elements.Add(ILogElement.GenerateRandom());
		return elements.ToArray();
	}

	private static string GenerateRandomTitle()
	{
		return "Log Title is " + Rand.RandomString;
	}

	private static string GenerateRandomMessage()
	{
		return "Log Message is " + Rand.RandomString + '-' + Rand.RandomString;
	}
}