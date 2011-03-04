using NMock;
using NUnit.Framework;

namespace wsm.Puzzle.Test
{
	[TestFixture]
	public class Test<%= name %>Adapter : TestHelper
	{
		private DynamicMock modelMock;
		private I<%= name %>AdapterModel model;
		private DynamicMock viewMock;
		private I<%= name %>View view;
		private <%= name %>Adapter adapter;

		[SetUp]
		public void SetUp()
		{
			modelMock = new DynamicMock(typeof (I<%= name %>AdapterModel));
			modelMock.Strict = true;
			model = modelMock.MockInstance as I<%= name %>AdapterModel;

			// Setup the view
			viewMock = new DynamicMock(typeof (I<%= name %>View));
			viewMock.Strict = true;
			view = viewMock.MockInstance as I<%= name %>View;

			// create the presenter
			adapter = new <%= name %>Adapter(model, view);
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
