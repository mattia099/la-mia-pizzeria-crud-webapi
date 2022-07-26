using la_mia_pizzeria_razor_layout.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_razor_layout
{
<<<<<<< HEAD
    public class PizzaContext : IdentityDbContext<IdentityUser>
=======
    public class PizzaContext :  IdentityDbContext<IdentityUser>
>>>>>>> a83371cde6a23a39831c4f1022f911fae6f2e0b1
    {
        public PizzaContext()
        {
        }
<<<<<<< HEAD

=======
>>>>>>> a83371cde6a23a39831c4f1022f911fae6f2e0b1
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True;Pooling=False");
        }
    }
<<<<<<< HEAD

}
=======
}
>>>>>>> a83371cde6a23a39831c4f1022f911fae6f2e0b1
