using AbanLib.Logging;
using AbanLibTests.facility;

namespace AbanLibTests.Logging;

public class LogElementTest : Test
{
	[Fact]
	public void EnsureGeneratorAmountIsConsidersAllTheSubTypesOfILogElement()
	{
		// Minus 1 to discount the ILogElement itself from the count.
		var shouldBe = SubTypesOf<ILogElement>().Length - 1;
		Assert.Equal(shouldBe, ILogElement.Generators.Length);
	}
}