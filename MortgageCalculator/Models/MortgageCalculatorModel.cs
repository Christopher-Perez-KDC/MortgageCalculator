namespace MortgageCalculator.Models
{
    public class MortgageCalculatorModel
    {

        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; } 
        public int LoanTermYears { get; set; } 

        // calculate monthly payment
        public decimal CalculateMonthlyPayment()
        {
            decimal monthlyInterestRate = InterestRate / 12 / 100;
            int totalPayments = LoanTermYears * 12; 

            decimal monthlyPayment = (LoanAmount * monthlyInterestRate) /
                                      (1 - (decimal)Math.Pow(1 + (double)monthlyInterestRate, -totalPayments));
            return monthlyPayment;
        }
    }
}