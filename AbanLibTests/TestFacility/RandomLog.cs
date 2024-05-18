using AbanLib;
using AbanLib.Logging;

namespace AbanLibTests.TestFacility;

public class RandomLog : LogBase
{
	private RandomLog()
	{
	}

	private RandomLog(ILogElement[] elements)
	{
		Elements = elements;
	}

	public override ILogElement[] Elements { get; } = GenerateRandomElements((uint)Rand.Random.Next(10, 100));
	public override string Title { get; } = GenerateRandomTitle();
	public override string Message { get; } = GenerateRandomMessage();

	public static ILog Create()
	{
		return new RandomLog();
	}

	public static ILog Create(ILogElement[] elements)
	{
		return new RandomLog(elements);
	}

	public static ILogElement[] GenerateRandomElements(uint howMany)
	{
		var elements = new List<ILogElement>();
		for (uint i = 0; i < howMany; i++) elements.Add(ILogElement.GenerateRandom());
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