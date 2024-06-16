using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.Models;
using MortgageCalculator.Repository;
namespace MortgageCalculator.Controllers
{

    public class MortgageCalculatorController : Controller
    {
        public IActionResult GoToIndex() //Redirects back to MortgageCalculator Index 
        {
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(MtgLoan model)
        {
            if (ModelState.IsValid)
            {
                model.Calculate(); // Perform calculation
                return View("Calculate", model);
            }
            return View("Index", model); // Return to index with validation errors
        }
    }
}
