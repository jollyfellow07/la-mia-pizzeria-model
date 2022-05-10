﻿using PizzeriaCompagnone.Models;

namespace PizzeriaCompagnone.Utils
{
    public static class DbPizza
    {
        public static List<Pizza> pizzas;

        public static List<Pizza> GetPizzas()
        {
            if (DbPizza.pizzas != null)
            {
                return DbPizza.pizzas;
            }
            List<Pizza> NuovaListaPizze = new List<Pizza>();

            Pizza pizza1 = new Pizza(0, "Mortadella Bologna IGP “La Santo”", "Mortadella Bologna IGP “La Santo” Villani, Pesto di Pistacchio, Fiordilatte “Latteria Sorrentina”, Olio EVO Italiano e Basilico.", "~/img/mortadella3.jpg", "~/img/mortadella2.jpg",8.00) ;
            NuovaListaPizze.Add(pizza1);
            Pizza pizza2 = new Pizza(1, "Salsiccia e Friarielli", "Salsiccia Fresca di Maiale, Friarielli Saltati in Padella con Peperoncino, Provola Affumicata, Basilico Fresco.", "~/img/fiarielli.jpg", "~/img/friarielli3.jpg", 8.00);
            NuovaListaPizze.Add(pizza2);
            Pizza pizza3 = new Pizza(2, "Margherita", "Pomodoro di Agricoltura Biologica , Fiordilatte “Latteria Sorrentina”, Olio EVO Italiano e Basilico Fresco.", "~/img/margherita.jpg", "~/img/margherita2.jpg", 6.00);
            NuovaListaPizze.Add(pizza3);
            Pizza pizza4 = new Pizza(3, "Americana", "Sticks di patate dolci americane fritte, salsiccia di suino nazionale, Provola di Agerola, Salsa crispy, olio E.V.O.", "~/img/patate1.jpg", "~/img/patate2.jpg", 10.00);
            NuovaListaPizze.Add(pizza4);
            Pizza pizza5 = new Pizza(4, "Marinara", "Pomodoro san mazano D.O.P., pesto di aglio orsino, origano di collina fresco, olio EVO del cilento.", "~/img/marinara1.jpg", "~/img/marinara2.jpg", 5.00);
            NuovaListaPizze.Add(pizza5);
            Pizza pizza6 = new Pizza(4, "Gialla Provola & pepe", "Pomodorini gialli del piennolo, provola di Agerola. pepe nero, olio extravergine aggiunto a fine cottura, basilico.", "~/img/gialla1.jpg", "~/img/gialla2.jpg", 13.00);
            NuovaListaPizze.Add(pizza6);

            DbPizza.pizzas = NuovaListaPizze;

            return DbPizza.pizzas;
        }


    }
}
