using System;
using System.Xml.Serialization;

namespace XeroApi.Model
{
	public class ManualJournal : EndpointModelBase, IAttachmentParent
	{
		[ItemUpdatedDate]
		public DateTime? UpdatedDateUTC { get; set; }

		[ItemId]
		public Guid ManualJournalID { get; set; }

		public DateTime? Date { get; set; }

		public string Status { get; set; }

		public LineAmountType LineAmountTypes { get; set; }

		public string Narration { get; set; }

		public string Url { get; set; }

		public bool? ShowOnCashBasisReports { get; set; }

		[XmlArrayItem( "JournalLine" )]
		public ManualJournalLineItems JournalLines { get; set; }

		[ReadOnly]
		public bool HasAttachments { get; set; }

		public Attachments Attachments { get; set; }
	}

	public class ManualJournals : ModelList<ManualJournal>
	{
	}
}