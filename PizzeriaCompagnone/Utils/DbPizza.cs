using PizzeriaCompagnone.Models;

namespace PizzeriaCompagnone.Utils
{
    public static class DbPizza
    {
        private static List<Pizza> pizzas;

        private static List<Pizza> GetPizzas()
        {
            if (DbPizza.pizzas != null)
            {
                return DbPizza.pizzas;
            }
            List<Pizza> NuovaListaPizze = new List<Pizza>();

            Pizza post = new pizzas(1, "Mortadella Bologna IGP “La Santo”", "Mortadella Bologna IGP “La Santo” Villani, Pesto di Pistacchio, Fiordilatte “Latteria Sorrentina”, Olio EVO Italiano e Basilico.", );
        }

    }
}
