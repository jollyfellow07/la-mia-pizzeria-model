using Microsoft.AspNetCore.Mvc;

namespace PizzeriaCompagnone.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("HomePage");
        }
    }
}
