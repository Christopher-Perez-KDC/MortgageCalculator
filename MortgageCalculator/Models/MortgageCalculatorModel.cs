namespace MortgageCalculator.Models
{
    public class MortgageCalculatorModel
    {
        public double LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        
        public double PurchasePrice {  get; set; }
        public double DownAmount {  get; set; }
        public double MonthlyPayment { get; private set; }
        public double TotalPayment { get; private set; }
        public double Years {  get; set; }
        public double InMonths {  get; set; }

        public double DownAmountPercent {  get; set; }
        public void Calculate()
        {
           
            double purchasePrice = PurchasePrice;
            double downAmount = DownAmount;
            double monthlyInterestRate = (double)(InterestRate / 100 / 12);
           // double downPercent = (DownAmountPercent =(downAmount / purchasePrice) * 100);
            double downPercent = Math.Round((DownAmountPercent = (downAmount / purchasePrice) * 100), 2);

            double totalMonths = (Years * 12);
            double loanAmount = (LoanAmount = (purchasePrice - downAmount));
            double inMonths = (InMonths = (totalMonths));
            double monthlyPayment = loanAmount * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalMonths));
            MonthlyPayment = Math.Round(monthlyPayment, 2);

            TotalPayment = Math.Round(monthlyPayment * totalMonths, 2);
        }
    }
}