namespace wsm.Puzzle
{
	public class <%= name %>Presenter
	{
		private I<%= name %>Model m_model;
		private I<%= name %>Adapter m_adapter;

		public <%= name %>Presenter(I<%= name %>Model model, I<%= name %>Adapter adapter)
		{
			m_model = model;
			m_adapter = adapter;
		}
	}
}
