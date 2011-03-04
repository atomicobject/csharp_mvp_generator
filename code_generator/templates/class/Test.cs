using NUnit.Framework;

namespace BepHost.Test
{
	[TestFixture]
	public class Test<%= name %> : TestHelper
	{
		private <%= name %> <%= name.downcase %>;

		[SetUp]
		public void SetUp()
		{
			<%= name.downcase %> = new <%= name %>();
		}

		[TearDown]
		public void TearDown()
		{
			// verify mocks
		}
		
		//
		// HELPERS
		//

		//
		// TESTS
		//
		[Test]
		public void test_Something()
		{
			Assert.Fail("Test Me");
		}
	}
}
