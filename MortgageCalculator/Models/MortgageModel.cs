namespace MortgageCalculator.Models
{
    public class MortgageModel
    {

        public decimal PurchasePrice { get; set; }
        public decimal DownAmount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Years { get; set; }
        public decimal MonthlyPayment { get;  set; }
        public decimal TotalPayment { get;  set; }
        public decimal LoanAmount { get;  set; }
        public decimal InMonths { get;  set; }
        public decimal DownAmountPercent { get; set; }
        public decimal Taxes { get; set; }
        public decimal Insurance { get; set; }
    }
}
