using NUnit.Framework;

namespace wsm.Puzzle.Test
{
	[TestFixture]
	public class Test<%= name %>AdapterModel : TestHelper
	{
		private <%= name %>AdapterModel model;

		[SetUp]
		public void SetUp()
		{
			model = new <%= name %>AdapterModel();
		}

		[TearDown]
		public void TearDown()
		{
			// verify mocks
		}

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
