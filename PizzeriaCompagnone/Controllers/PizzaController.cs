using Microsoft.AspNetCore.Mvc;
using PizzeriaCompagnone.Models;
using PizzeriaCompagnone.Utils;

namespace PizzeriaCompagnone.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzas = DbPizza.GetPizzas();
            return View("HomePage", pizzas);
        }
        [HttpGet]
        public IActionResult Dettagli()
        {
            List<Pizza> pizzas = DbPizza.GetPizzas();
            return View("Dettagli", pizzas);
        }
    }
}
