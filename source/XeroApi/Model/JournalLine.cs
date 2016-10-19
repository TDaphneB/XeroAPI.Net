using System;

namespace XeroApi.Model
{
	public class JournalLine : ModelBase
	{
		public Guid JournalLineID { get; set; }

		public Guid AccountID { get; set; }

		public string AccountCode { get; set; }

		public string AccountType { get; set; }

		public string AccountName { get; set; }

		public string Description { get; set; }

		public decimal NetAmount { get; set; }

		public decimal GrossAmount { get; set; }

		public decimal TaxAmount { get; set; }

		public string TaxType { get; set; }

		public string TaxName { get; set; }

		public TrackingCategories TrackingCategories { get; set; }

		public string ToLogString( )
		{
			return string.Format( "Journal Line Id: {0}, AccountId: {1}, AccountCode: '{2}', AccountName: '{3}', Description: '{4}', NetAmount: {5}, GrossAmount: {6}, TaxAmount: {7}, TaxType: '{8}', TaxName: '{9}'",
				// 0           1          2            3            4            5          6            7          8        9
				JournalLineID, AccountID, AccountCode, AccountName, Description, NetAmount, GrossAmount, TaxAmount, TaxType, TaxName );
		}
	}


	public class JournalLines : ModelList<JournalLine>
	{
	}

}
