using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzeController : Controller
    {
        public IActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> pizzaList = db.Pizzas.ToList<Pizza>();
                return View(pizzaList);
            }
        }

        [Route("/menu")]
        public IActionResult Details(int id)
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                Pizza current = db.Pizzas.Find(id);

                if (current == null)
                {
                    return NotFound($"La pizza con id {id} non è stato trovato");
                }
                else
                {
                    return View(current);
                }
            }

        }
    }
}

