using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_razor_layout.Models.Repositories
{
    public class DbPizzaRepository
    {
        private readonly PizzaContext _context;
        public DbPizzaRepository()
        {
            this._context = new PizzaContext();
        }
      


        public Pizza GetById(int id)
        {
            
            Pizza pizzaFound = _context.Pizza.Where(p => p.Id == id).Include(p =>
            p.Category).Include(p => p.Ingredients).FirstOrDefault();
            return pizzaFound;
            
        }

        public List<Pizza> GetList()
        {
            return _context.Pizza.ToList();
        }

        
    }
}

