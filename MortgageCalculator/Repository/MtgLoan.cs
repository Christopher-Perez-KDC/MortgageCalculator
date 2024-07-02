using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
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
            decimal insuranceMonthly = Insurance / 12;
            decimal taxesMonthly = Taxes / 12;
            decimal taxesInsurance = insuranceMonthly + taxesMonthly;
            decimal monthlyHOA = HOA;

            //Calculate PMI
            decimal pmiRate = 0.005m; // fixed PMI rate(0.5%)
            decimal annualPMI = loanAmount * pmiRate;
            decimal monthlyPMI = annualPMI / 12;


            decimal monthlyPayment = loanAmount * monthlyInterestRate / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), (double)-totalMonths));
            MonthlyPayment = Math.Round(monthlyPayment, 2);
            monthlyPayment += taxesMonthly;
            monthlyPayment += insuranceMonthly;
            monthlyPayment += monthlyPMI;
            decimal piti = monthlyPayment += monthlyPMI + monthlyHOA + taxesInsurance;

            TotalPayment = Math.Round(MonthlyPayment * totalMonths, 2);
            LoanAmount = loanAmount;
            InMonths = inMonths;
            DownAmountPercent = downPercent;
            Taxes = taxesMonthly;
            Insurance = insuranceMonthly;

            PITI = piti;
            PMI = Math.Round(monthlyPMI, 2); // store monthly PMI
        }
    }
}
