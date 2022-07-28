using la_mia_pizzeria_razor_layout.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_razor_layout.Controllers
{
    [Route("api/pizzas")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(string? search)
        {
            using (PizzaContext cxt = new PizzaContext())
            {
                IQueryable<Pizza> pizzas = cxt.Pizza;
                if (search != null && search != "")
                {
                    pizzas = pizzas.Where(p => p.Name.Contains(search));
                }
                return Ok(pizzas.ToList());
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (PizzaContext cxt = new PizzaContext())
            {
                Pizza p = cxt.Pizza.Where(p => p.Id == id).Include("Ingredient").Include("Category").FirstOrDefault();
                if (p == null)
                {
                    NotFound();
                }
                return Ok(p);
            }
        }
    }
}
