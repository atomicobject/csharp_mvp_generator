using NUnit.Framework;

namespace XRite.Retail.Utility.ColorantCombinator.Tests
{
	[TestFixture]
	public class Test<%= class_name %> : TestHelper
	{
		private <%= iface_name %> <%= class_name.downcase %>;

		[SetUp]
		public void SetUp()
		{
			<%= class_name.downcase %> = new <%= class_name %>();
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
