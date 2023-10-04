using exercise.pizzashopapi.Models;

namespace exercise.pizzashopapi.Data
{
    public static class Seeder
    {
        public static void SeedPizzaShopApi(this WebApplication app)
        {
            using(var db = new DataContext())
            {
                if(!db.Customers.Any())
                {
                    db.Add(new Customer() { Name="Nigel", Address = "South of the Wall" });
                    db.Add(new Customer() { Name = "Dave", Address="North of the Wall"});
                    db.SaveChanges();
                }
                if(!db.Pizzas.Any())
                {
                    db.Add(new Pizza() { Name = "Cheese & Pineapple" });
                    db.Add(new Pizza() { Name = "Vegan Cheese Tastic" });
                    db.SaveChanges();

                }

                //order data
                if(!db.Orders.Any())
                {
                    db.Orders.Add(new Order() { CustomerId = 3, PizzaId = 2, OrderDate = DateTime.UtcNow }); ;
                    db.Orders.Add(new Order() { CustomerId = 4, PizzaId = 1, OrderDate = DateTime.UtcNow });

                    db.SaveChanges();
                }
            }
        }
    }
}
