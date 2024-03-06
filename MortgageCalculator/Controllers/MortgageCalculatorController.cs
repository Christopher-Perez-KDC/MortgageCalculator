using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.Models;

namespace MortgageCalculator.Controllers
{
    public class MortgageCalculatorController : Controller
    {
        // GET: MortgageCalculator
        public ActionResult Index()
        {
            return View();
        }

        // POST: MortgageCalculator/Calculate
        [HttpPost]
        public ActionResult Calculate(MortgageCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                decimal monthlyPayment = model.CalculateMonthlyPayment();
                ViewBag.MonthlyPayment = monthlyPayment;

                // Redirect to the Calculate view
                return View("Calculate", model);
            }

            // If model state is not valid, return to the input form view (Index)
            return View("Index", model);
        }
    }

    }
