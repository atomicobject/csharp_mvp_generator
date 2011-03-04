namespace wsm.Puzzle
{
	public class <%= name %>Adapter : I<%= name %>Adapter
	{
		private I<%= name %>AdapterModel m_adapterModel;
		private I<%= name %>View m_view;

		public <%= name %>Adapter(I<%= name %>AdapterModel adapterModel, I<%= name %>View view)
		{
			m_adapterModel = adapterModel;
			m_view = view;
		}
	}
}
