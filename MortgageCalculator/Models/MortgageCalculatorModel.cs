namespace MortgageCalculator.Models
{
    public class MortgageCalculatorModel
    {
        public decimal PurchasePrice { get; set; }
        public decimal DownAmount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Years { get; set; }

        public decimal MonthlyPayment { get; private set; }
        public decimal TotalPayment { get; private set; }
        public decimal LoanAmount { get; private set; }
        public decimal InMonths { get; private set; }
        public decimal DownAmountPercent { get; private set; }

        public void Calculate()
        {
            decimal purchasePrice = PurchasePrice;
            decimal downAmount = DownAmount;
            decimal monthlyInterestRate = InterestRate / 100 / 12;
            decimal totalMonths = Years * 12;
            decimal loanAmount = purchasePrice - downAmount;
            decimal inMonths = totalMonths;
            decimal downPercent = Math.Round((downAmount / purchasePrice) * 100, 2);

            decimal monthlyPayment = loanAmount * monthlyInterestRate / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), (double)-totalMonths));
            MonthlyPayment = Math.Round(monthlyPayment, 2);

            TotalPayment = Math.Round(monthlyPayment * totalMonths, 2);
            LoanAmount = loanAmount;
            InMonths = inMonths;
            DownAmountPercent = downPercent;
        }
    }
}
