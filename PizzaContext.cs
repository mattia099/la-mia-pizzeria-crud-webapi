using la_mia_pizzeria_razor_layout.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_razor_layout
{

    public class PizzaContext :  IdentityDbContext<IdentityUser>

    {
        public PizzaContext()
        {
        }

        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True;Pooling=False");
        }
    }

}

