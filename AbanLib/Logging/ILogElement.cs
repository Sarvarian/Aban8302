using AbanLib.Util;

namespace AbanLib.Logging;

public interface ILogElement
{
	public static readonly Func<ILogElement>[] Generators =
	[
		GenerateString,
		GenerateInteger,
		GenerateFloat,
		GenerateDouble,
		GenerateBoolean
	];

	string Name { get; }
	object Data { get; }
	string DataAsText { get; }

	public static ILogElement GenerateRandom()
	{
		var index = Rand.Random.Next(0, Generators.Length);
		return Generators[index]();
	}

	private static ILogElement GenerateString()
	{
		return new LogElementString(Rand.RandomString, Rand.RandomString);
	}

	private static ILogElement GenerateInteger()
	{
		return new LogElementInteger(Rand.RandomString, Rand.RandomInteger);
	}

	private static ILogElement GenerateFloat()
	{
		return new LogElementFloat(Rand.RandomString, Rand.RandomFloat);
	}

	private static ILogElement GenerateDouble()
	{
		return new LogElementDouble(Rand.RandomString, Rand.RandomDouble);
	}

	private static ILogElement GenerateBoolean()
	{
		return new LogElementBoolean(Rand.RandomString, Rand.RandomBoolean);
	}
}