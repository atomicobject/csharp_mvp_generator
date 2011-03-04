using NMock;
using NUnit.Framework;

namespace wsm.Puzzle.Tests
{
	[TestFixture]
	public class Test<%= name %>Presenter : TestHelper
	{
		private DynamicMock modelMock;
		private I<%= name %>Model model;
		private DynamicMock viewMock;
		private I<%= name %>View view;

		[SetUp]
		public void SetUp()
		{
			modelMock = new DynamicMock(typeof (I<%= name %>Model));
			modelMock.Strict = true;
			model = modelMock.MockInstance as I<%= name %>Model;

			// Setup the view
			viewMock = new DynamicMock(typeof (I<%= name %>View));
			viewMock.Strict = true;
			view = viewMock.MockInstance as I<%= name %>View;

			// create the presenter
			new <%= name %>Presenter(model, view);
		}

		[TearDown]
		public void TearDown()
		{
			modelMock.Verify();
			viewMock.Verify();
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
