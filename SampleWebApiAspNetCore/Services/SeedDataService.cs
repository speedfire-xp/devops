using SampleWebApiAspNetCore.Repositories;
using SampleWebApiAspNetCore.Entities;


namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(FoodDbContext context)
        {
            if (context.FoodItems.Any())
            {
                return;
            }

            var foods = new FoodEntity[]
            {
                new FoodEntity { Name = "Banana", Type = "Fruit", Calories = 105, Created = DateTime.UtcNow },
                new FoodEntity { Name = "Apple", Type = "Fruit", Calories = 95, Created = DateTime.UtcNow },
                new FoodEntity { Name = "Broccoli", Type = "Vegetable", Calories = 50, Created = DateTime.UtcNow },
                new FoodEntity { Name = "Chicken Breast", Type = "Protein", Calories = 165, Created = DateTime.UtcNow }
            };

            context.FoodItems.AddRange(foods);
            
            context.SaveChanges(); 
        }
    }
}