using NMock;
using NUnit.Framework;

namespace wsm.Puzzle.Tests
{
	[TestFixture]
	public class Test<%= name %>Presenter : TestHelper
	{
		private DynamicMock modelMock;
		private I<%= name %>Model model;
		private DynamicMock adapterMock;
		private I<%= name %>Adapter adapter;

		[SetUp]
		public void SetUp()
		{
			modelMock = new DynamicMock(typeof (I<%= name %>Model));
			modelMock.Strict = true;
			model = modelMock.MockInstance as I<%= name %>Model;

			// Setup the adapter
			adapterMock = new DynamicMock(typeof (I<%= name %>Adapter));
			adapterMock.Strict = true;
			adapter = adapterMock.MockInstance as I<%= name %>Adapter;

			// create the presenter
			new <%= name %>Presenter(model, adapter);
		}

		[TearDown]
		public void TearDown()
		{
			modelMock.Verify();
			adapterMock.Verify();
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
