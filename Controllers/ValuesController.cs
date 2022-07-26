using la_mia_pizzeria_razor_layout.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_razor_layout.Controllers
{
    [Route("api/pizzas")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (PizzaContext context = new PizzaContext())
            {
                List<Pizza> pizzas = context.Pizza.ToList<Pizza>();
                return Ok(pizzas);
            }
        }
    }
}
