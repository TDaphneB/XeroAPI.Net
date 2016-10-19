namespace XeroApi.Model
{
	public class ExternalLink : ModelBase
	{
		public string LinkType;

		public string Url;
	}

	public class ExternalLinks : ModelList<ExternalLink>
	{
	}
}
