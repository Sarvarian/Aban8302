using System.Globalization;

namespace AbanLib;

public static class Rand
{
	public static Guid Guid => Guid.NewGuid();
	public static string GuidString => Guid.ToString();

	public static Random Random =>
		new((Guid.NewGuid() + DateTime.Now.ToString(CultureInfo.CurrentCulture)).GetHashCode());

	public static int RandomInteger => Random.Next();
	public static float RandomFloat => Random.NextSingle();
	public static double RandomDouble => Random.NextDouble();
	public static bool RandomBoolean => RandomInteger % 2 == 0;
	public static string RandomString => GuidString;
}