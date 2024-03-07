namespace MortgageCalculator.Models
{
    public class MortgageCalculatorModel
    {
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int LoanTermMonths { get; set; }
        public double PurchasePrice {  get; set; }
        public double DownAmount {  get; set; }
        public double MonthlyPayment { get; private set; }
        public double TotalPayment { get; private set; }

        public void Calculate()
        {
            double purchasePrice = PurchasePrice;
            double downAmount = DownAmount;
            double monthlyInterestRate = InterestRate / 100 / 12;
            double totalMonths = LoanTermMonths;
            double loanAmount = (LoanAmount = (purchasePrice - downAmount));

            double monthlyPayment = loanAmount * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalMonths));
            MonthlyPayment = Math.Round(monthlyPayment, 2);

            TotalPayment = Math.Round(monthlyPayment * totalMonths, 2);
        }
    }
}