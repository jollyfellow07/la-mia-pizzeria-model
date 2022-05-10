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
        public IActionResult Dettagli(int id)
        {
            Pizza pizzaTrovata = null;
            foreach (Pizza pizza in DbPizza.GetPizzas())
            {
                if (pizza.id == id)
                {
                    pizzaTrovata = pizza;
                        break;
                }
            }
            if (pizzaTrovata != null)
            {
                return View("Dettagli", pizzaTrovata);
            }
            else
            {
               return NotFound("il post con id " + id + " non è stato trovato!");
            }
        

        }
    }
}
