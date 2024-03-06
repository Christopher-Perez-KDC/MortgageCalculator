namespace MortgageCalculator.Models
{
    public class MortgageDetailModel
    {

        double _homePrice;
        double _downPaymentPct;
        int _loanInMonths;
        double _interestRate;
        DateTime _startDate;

        public double HomePrice
        {
            get { return _homePrice; }
            set { _homePrice = value; }
        }

        public double DownPaymentPercent
        {
            get { return _downPaymentPct; }
            set { if (value > 1) { _downPaymentPct = (value / 100); } else { _downPaymentPct = value; } }
        }

        public int LoanPeriodInMonths
        {
            get { return _loanInMonths; }
            set { _loanInMonths = value; }
        }

        public double InterestRate
        {
            get { return _interestRate; }
            set { if (value >= 1) { _interestRate = (value / 100); } else { _interestRate = value; } }
        }

        public DateTime LoanStartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public MortgageDetailModel()
        {
            // Basic constructor defining start date of the loan as today.
            _homePrice = 0;
            _downPaymentPct = 0;
            _loanInMonths = 0;
            _interestRate = 0;
            _startDate = DateTime.Today;
        }

        public MortgageDetailModel(double SalePrice, double DownPaymentPct, int LoanInMonths, double InterestRate, DateTime StartDate)
        {
            _homePrice = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = StartDate;
        }

        public MortgageDetailModel(double SalePrice, double DownPaymentPct, int LoanInMonths, double InterestRate)
        {
            _homePrice = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = DateTime.Today;
        }

    }
}
