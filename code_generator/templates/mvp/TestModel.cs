using NUnit.Framework;

namespace wsm.Puzzle.Tests
{
	[TestFixture]
	public class Test<%= name %>Model : TestHelper
	{
		private <%= name %>Model model;

		[SetUp]
		public void SetUp()
		{
			model = new <%= name %>Model();
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
