using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.Models;


namespace MortgageCalculator.Controllers
{
    public class MtgInsuranceTaxesController : Controller
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
        public IActionResult MtgInsuranceTaxes()
        {
            return View();
        }
    }
}
