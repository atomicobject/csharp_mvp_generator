namespace wsm.Puzzle
{
	public class <%= name %>Presenter
	{
		private I<%= name %>Model m_model;
		private I<%= name %>View m_view;

		public <%= name %>Presenter(I<%= name %>Model model, I<%= name %>View view)
		{
			m_model = model;
			m_view = view;
		}
	}
}
