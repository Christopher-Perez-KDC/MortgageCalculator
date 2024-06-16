using MortgageCalculator.Models;

namespace MortgageCalculator.Repository
{
    public class MtgLoan : MortgageModel
    {
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
