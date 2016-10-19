using System;

namespace XeroApi.Model
{
    public class ExpenseClaim : EndpointModelBase
    {
        [ItemId]
        public Guid ExpenseClaimID { get; set; }
        
        public string Status { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }
        
        public Receipts Receipts { get; set; }

        [ReadOnly]
        public DateTime CreatedDateUTC { get; set; }

        [ReadOnly]
        public DateTime UpdatedDateUTC { get; set; }

        [ReadOnly]
        public decimal SubTotal { get; set; }

        [ReadOnly]
        public decimal TotalTax { get; set; }

        [ReadOnly]
        public decimal Total { get; set; }

		[ReadOnly]
		public decimal AmountDue { get; set; }

		[ReadOnly]
		public decimal AmountPaid { get; set; }

		[ReadOnly]
		public DateTime PaymentDueDate { get; set; }

		[ReadOnly]
		public DateTime ReportingDate { get; set; }
    }

    public class ExpenseClaims : ModelList<ExpenseClaim>
    {
    }
}
