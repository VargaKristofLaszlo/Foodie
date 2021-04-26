using Foodie.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal.EntityConfiguration
{
    public class RecipeEntityConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {


            builder.HasData(
                new Recipe
                {
                    Id = 1,
                    Category = Category.Soup | Category.GlutenFree | Category.DairyFree | Category.LowCarb,
                    PreparationTime = new TimeSpan(0, 15, 0),
                    CookingTime = new TimeSpan(0, 36, 0),
                    Name = "Green Chicken Chili Soup",
                    Instruction = new List<string>
                    {
                        "In a large pot, heat olive oil and sauté the onions for 5 minutes. Add garlic and continue cooking for 1 more minute.",
                        "Add all the remaining ingredients, using 3 cups of chicken stock (except the lime juice) to the pot.",
                        "Bring to a simmer and allow to cook for 30 minutes, until the chicken is cooked through.",
                        "Stir in lime juice and serve with avocado and cilantro."
                    }
                });

            builder.OwnsMany(r => r.Ingredients).HasData(
            new
            {
                Id = 1,
                RecipeId = 1,
                Name = "Olive oil",
                Measurement = Measurement.Tablespoon,
                Amount = 2.0
            },
            new
            {
                Id = 2,
                RecipeId = 1,
                Name = "Onion",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 3,
                RecipeId = 1,
                Name = "Garlic cloves",
                Measurement = Measurement.Piece,
                Amount = 4.0
            },
            new
            {
                Id = 4,
                RecipeId = 1,
                Name = "Chicken stock",
                Measurement = Measurement.Cup,
                Amount = 2.0
            },
            new
            {
                Id = 5,
                RecipeId = 1,
                Name = "White beans",
                Measurement = Measurement.Can,
                Amount = 1.0
            },
            new
            {
                Id = 6,
                RecipeId = 1,
                Name = "Salsa verde",
                Measurement = Measurement.Can,
                Amount = 1.0
            },
            new
            {
                Id = 7,
                RecipeId = 1,
                Name = "Green chilis",
                Measurement = Measurement.Can,
                Amount = 1.0
            },
            new
            {
                Id = 8,
                RecipeId = 1,
                Name = "Green bell pepper",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 9,
                RecipeId = 1,
                Name = "Jalapeno",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 10,
                RecipeId = 1,
                Name = "Chicken breast",
                Measurement = Measurement.Kilogram,
                Amount = 0.68
            },
            new
            {
                Id = 11,
                RecipeId = 1,
                Name = "Cumin",
                Measurement = Measurement.Teaspoon,
                Amount = 1.0
            },
            new
            {
                Id = 12,
                RecipeId = 1,
                Name = "Chili powder",
                Measurement = Measurement.Teaspoon,
                Amount = 1.0
            },
            new
            {
                Id = 13,
                RecipeId = 1,
                Name = "Salt",
                Measurement = Measurement.Teaspoon,
                Amount = 1.0
            },
            new
            {
                Id = 14,
                RecipeId = 1,
                Name = "Lime juice",
                Measurement = Measurement.Tablespoon,
                Amount = 2.0
            });


            builder.HasData(
                new Recipe
                {
                    Id = 2,
                    Category = Category.Soup | Category.GlutenFree,
                    PreparationTime = new TimeSpan(0, 10, 0),
                    CookingTime = new TimeSpan(0, 25, 0),
                    Name = "Coconut Curry Soup with Chicken, Chickpeas and Hearty Greens",
                    Instruction = new List<string>
                    {
                        "Sauté onions and peppers in olive oil over medium heat. Sauté until onions are just tender. Add garlic and cook for 2 more minutes. Add tomatoes, curry paste, chicken stock and chickpeas and bring to rapid simmer. Stir until paste is dissolved. Add coconut milk, fish sauce and lime juice, bring back to a simmer and allow to cook for 10 minutes.",
                        "Add chicken and cook for 10 minutes at a simmer until chicken is cooked through. Season with salt and add kale/spinach. Cook for 3 more minutes and serve as is or over cauliflower rice.",
                        "You may need to adjust the seasonings just a bit. Use less curry paste if you don't like it with a little “kick”."
                    }
                });

            builder.OwnsMany(r => r.Ingredients).HasData(
        new
        {
            Id = 1,
            RecipeId = 2,
            Name = "Olive oil",
            Measurement = Measurement.Tablespoon,
            Amount = 1.0
        },
        new
        {
            Id = 2,
            RecipeId = 2,
            Name = "onion",
            Measurement = Measurement.Piece,
            Amount = 1.0
        },
        new
        {
            Id = 3,
            RecipeId = 2,
            Name = "Red bell pepper",
            Measurement = Measurement.Piece,
            Amount = 2.0
        },
        new
        {
            Id = 4,
            RecipeId = 2,
            Name = "Garlic cloves",
            Measurement = Measurement.Piece,
            Amount = 4.0
        },
        new
        {
            Id = 5,
            RecipeId = 2,
            Name = "Diced Tomatoe",
            Measurement = Measurement.Can,
            Amount = 1.0
        },
        new
        {
            Id = 6,
            RecipeId = 2,
            Name = "Chickpea",
            Measurement = Measurement.Can,
            Amount = 1.0
        },
        new
        {
            Id = 7,
            RecipeId = 2,
            Name = "Chicken stock",
            Measurement = Measurement.Cup,
            Amount = 4.0
        },
        new
        {
            Id = 8,
            RecipeId = 2,
            Name = "Full fat coconut milk",
            Measurement = Measurement.Can,
            Amount = 2.0
        },
        new
        {
            Id = 9,
            RecipeId = 2,
            Name = "Red curry paste",
            Measurement = Measurement.Tablespoon,
            Amount = 2.0
        },
        new
        {
            Id = 10,
            RecipeId = 2,
            Name = "Fish sauce",
            Measurement = Measurement.Teaspoon,
            Amount = 2.0
        },
        new
        {
            Id = 11,
            RecipeId = 2,
            Name = "Lemon juice",
            Measurement = Measurement.ToTaste
        },
        new
        {
            Id = 12,
            RecipeId = 2,
            Name = "Chicken breasts",
            Measurement = Measurement.Kilogram,
            Amount = 0.68
        },
        new
        {
            Id = 13,
            RecipeId = 2,
            Name = "Kale",
            Measurement = Measurement.Cup,
            Amount = 2.0
        },
        new
        {
            Id = 14,
            RecipeId = 2,
            Name = "Salt",
            Measurement = Measurement.ToTaste
        });


            builder.HasData(
                new Recipe
                {
                    Id = 3,
                    Name = "Black Bean Soup",
                    Category = Category.Soup | Category.GlutenFree,
                    PreparationTime = new TimeSpan(0, 10, 0),
                    CookingTime = new TimeSpan(0, 25, 0),
                    Instruction = new List<string>
                    {
                        "Heat oil in a large pot set over medium-high heat. Add the onion and cook, stirring often until beginning to soften, about 4 minutes.",
                        "Add the garlic and bell peppers and cook, stirring often, until the garlic is fragrant and bell peppers begin to soften, about 2-3 more minutes longer.",
                        "Add the chicken stock, black beans, cumin, garlic powder, oregano, chili powder, salt and pepper. Turn the heat to high and bring to a boil. Once boiling, reduce the heat back down to medium-low and simmer for 10-15 minutes.",
                        "Using an immersion blender or stand blender, blend 1/3 of the soup. This step creates a thick, creamy texture to the soup.",
                        "Add the sausage to the soup and cook until the sausage is heated through.",
                        "Serve the soup topped with cilantro, sour cream and extra onion, if desired."
                    }
                });


            builder.OwnsMany(r => r.Ingredients).HasData(
        new
        {
            Id = 1,
            RecipeId = 3,
            Name = "Extra virgin olive oil",
            Measurement = Measurement.Tablespoon,
            Amount = 2.0
        },
        new
        {
            Id = 2,
            RecipeId = 3,
            Name = "Red onion",
            Measurement = Measurement.Piece,
            Amount = 1.0
        },
        new
        {
            Id = 3,
            RecipeId = 3,
            Name = "Garlic cloves",
            Measurement = Measurement.Piece,
            Amount = 4.0
        },
        new
        {
            Id = 4,
            RecipeId = 3,
            Name = "Red bell peppers",
            Measurement = Measurement.Piece,
            Amount = 1.0
        },
        new
        {
            Id = 5,
            RecipeId = 3,
            Name = "Green bell pepper",
            Measurement = Measurement.Piece,
            Amount = 1.0
        },
        new
        {
            Id = 6,
            RecipeId = 3,
            Name = "Chicken stock",
            Measurement = Measurement.Cup,
            Amount = 4.0
        },
        new
        {
            Id = 7,
            RecipeId = 3,
            Name = "Black bean",
            Measurement = Measurement.Can,
            Amount = 3.0
        },
        new
        {
            Id = 8,
            RecipeId = 3,
            Name = "Ground cumin",
            Measurement = Measurement.Teaspoon,
            Amount = 2.0
        },
        new
        {
            Id = 9,
            RecipeId = 3,
            Name = "Garlic powder",
            Measurement = Measurement.Teaspoon,
            Amount = 2.0
        },
        new
        {
            Id = 10,
            RecipeId = 3,
            Name = "Dried oregano",
            Measurement = Measurement.Teaspoon,
            Amount = 2.0
        },
        new
        {
            Id = 11,
            RecipeId = 3,
            Name = "Chili powder",
            Measurement = Measurement.Tablespoon,
            Amount = 1.0
        },
        new
        {
            Id = 12,
            RecipeId = 3,
            Name = "Kosher salt",
            Measurement = Measurement.Teaspoon,
            Amount = 1.0
        },
        new
        {
            Id = 13,
            RecipeId = 3,
            Name = "Freshly ground pepper",
            Measurement = Measurement.Teaspoon,
            Amount = 0.5
        },
        new
        {
            Id = 14,
            RecipeId = 3,
            Name = "Smoked sausage",
            Measurement = Measurement.Kilogram,
            Amount = 0.45
        },
        new
        {
            Id = 15,
            RecipeId = 3,
            Name = "Cilantro",
            Measurement = Measurement.ToTaste
        },
        new
        {
            Id = 16,
            RecipeId = 3,
            Name = "Sour cream",
            Measurement = Measurement.ToTaste
        });


            builder.HasData(
                new Recipe
                {
                    Id = 4,
                    Category = Category.Salad | Category.Vegetarian,
                    PreparationTime = new TimeSpan(1, 5, 0),
                    CookingTime = new TimeSpan(1, 35, 0),
                    Name = "Five Onion Tart with Arugula Salad",
                    Instruction = new List<string>
                    {
                        "Pulse the butter, shortening flour and salt together in the base of a food processor (alternatively you can cut the butter and shortening into the flour by hand with a fork or pastry cutter) until butter and shortening are pea sized. Add the ice water one tablespoon at a time pulsing or mixing until dough just starts to come together. Do not over mix. Using your hands form a ball with the dough, wrap it in saran wrap and chill in the refrigerator for 30 minutes.",
                        "On a lightly floured surface roll out dough into a circle ¼-inch thick. Carefully press the dough into a tart pan, cutting away excess dough. Puncture dough with a fork a dozen times and chill for 30 minutes longer.",
                        "Preheat oven to 400°F. Cover the pie with a piece of foil and bake for 20 minutes. Remove the foil and continue to bake for another 10 minutes, or until crust is just set.",
                        "In a large saucepan with a tight fitting lid set over medium heat, melt 4 tablespoons butter and 2 tablespoons oil. Reduce heat to medium-low and add onions, leeks, scallions and shallots. Cover with a lid and cook for 10 minutes. Remove cover and continue to cook, stirring often, until onions turn a golden brown color. This process should take about 30 minutes. Remove from heat and allow to cool, about 20 minutes.",
                        "In a large bowl whisk together eggs, crème fraîche, salt, nutmeg, pepper and chives. Add the onion mixture to the egg mixture and stir until onions are evenly distributed. Pour into the tart crust and bake for 25-35 minutes, until eggs are set and the crust is golden brown.",
                        "Just before serving toss the arugula with desired amount of olive oil, salt and pepper. Add the salad to the top of the tart and serve."
                    }
                });



            builder.OwnsMany(r => r.Ingredients).HasData(
               new
               {
                   Id = 1,
                   RecipeId = 4,
                   Name = "Unsalted butter",
                   Measurement = Measurement.Cup,
                   Amount = 0.5
               },
               new
               {
                   Id = 2,
                   RecipeId = 4,
                   Name = "Vegetable shortening",
                   Measurement = Measurement.Cup,
                   Amount = 0.5
               },
               new
               {
                   Id = 3,
                   RecipeId = 4,
                   Name = "All purpose flour",
                   Measurement = Measurement.Cup,
                   Amount = 2.0
               },
               new
               {
                   Id = 4,
                   RecipeId = 4,
                   Name = "Sea salt",
                   Measurement = Measurement.Teaspoon,
                   Amount = 0.5
               },
               new
               {
                   Id = 5,
                   RecipeId = 4,
                   Name = "Ice water",
                   Measurement = Measurement.Tablespoon,
                   Amount = 5.0
               },
               new
               {
                   Id = 6,
                   RecipeId = 4,
                   Name = "Butter",
                   Measurement = Measurement.Tablespoon,
                   Amount = 4.0
               },
               new
               {
                   Id = 7,
                   RecipeId = 4,
                   Name = "Olive oil",
                   Measurement = Measurement.Tablespoon,
                   Amount = 2.0
               },
               new
               {
                   Id = 8,
                   RecipeId = 4,
                   Name = "Yellow onion",
                   Measurement = Measurement.Piece,
                   Amount = 1.0
               },
               new
               {
                   Id = 9,
                   RecipeId = 4,
                   Name = "Leeks",
                   Measurement = Measurement.Piece,
                   Amount = 2.0
               },
               new
               {
                   Id = 10,
                   RecipeId = 4,
                   Name = "Green onion",
                   Measurement = Measurement.Piece,
                   Amount = 4.0
               },
               new
               {
                   Id = 11,
                   RecipeId = 4,
                   Name = "Shallots",
                   Measurement = Measurement.Piece,
                   Amount = 2.0
               },
               new
               {
                   Id = 12,
                   RecipeId = 4,
                   Name = "Eggs",
                   Measurement = Measurement.Piece,
                   Amount = 4.0
               },
               new
               {
                   Id = 13,
                   RecipeId = 4,
                   Name = "Crème fraîche",
                   Measurement = Measurement.Cup,
                   Amount = 0.33
               },
               new
               {
                   Id = 14,
                   RecipeId = 4,
                   Name = "Salt",
                   Measurement = Measurement.ToTaste
               },
               new
               {
                   Id = 15,
                   RecipeId = 4,
                   Name = "Nutmeg",
                   Measurement = Measurement.Teaspoon,
                   Amount = 0.25
               },
               new
               {
                   Id = 16,
                   RecipeId = 4,
                   Name = "Pepper",
                   Measurement = Measurement.ToTaste
               },
               new
               {
                   Id = 17,
                   RecipeId = 4,
                   Name = "Chives",
                   Measurement = Measurement.Cup,
                   Amount = 0.5
               },
               new
               {
                   Id = 18,
                   RecipeId = 4,
                   Name = "Arugula",
                   Measurement = Measurement.Cup,
                   Amount = 4.0
               });

            builder.HasData(
              new Recipe
              {
                  Id = 5,
                  Category = Category.Salad | Category.GlutenFree | Category.Vegetarian | Category.LowCarb,
                  PreparationTime = new TimeSpan(0, 10, 0),
                  CookingTime = new TimeSpan(0, 5, 0),
                  Name = "Simple Italian Salad",
                  Instruction = new List<string>
                    {
                        "To make the dressing place all the ingredients in a jar with a tight fitting lid. Shake vigorously until all ingredients are combined. Store in refrigerator for a week. Shake before each use.",
                        "To make the salad, place all ingredients in a large salad bowl. Drizzle with Italian dressing and toss to combine."
                    }
              });


            builder.OwnsMany(r => r.Ingredients).HasData(
             new
             {
                 Id = 1,
                 RecipeId = 5,
                 Name = "Leafy romaine lettuce",
                 Measurement = Measurement.Head,
                 Amount = 1.0
             },
             new
             {
                 Id = 2,
                 RecipeId = 5,
                 Name = "Red onion",
                 Measurement = Measurement.Piece,
                 Amount = 0.5
             },
             new
             {
                 Id = 3,
                 RecipeId = 5,
                 Name = "Parmesan cheese",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 4,
                 RecipeId = 5,
                 Name = "Peperoncini",
                 Measurement = Measurement.Cup,
                 Amount = 1.0
             },
             new
             {
                 Id = 5,
                 RecipeId = 5,
                 Name = "Black olives",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 6,
                 RecipeId = 5,
                 Name = "Cherry tomatoes",
                 Measurement = Measurement.Pint,
                 Amount = 1.0
             },
             new
             {
                 Id = 7,
                 RecipeId = 5,
                 Name = "Pepper",
                 Measurement = Measurement.ToTaste
             },
             new
             {
                 Id = 8,
                 RecipeId = 5,
                 Name = "Croutons",
                 Measurement = Measurement.ToTaste
             },
             new
             {
                 Id = 9,
                 RecipeId = 5,
                 Name = "Garlic powder",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 10,
                 RecipeId = 5,
                 Name = "Dried oregano",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 11,
                 RecipeId = 5,
                 Name = "Dried basil",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 12,
                 RecipeId = 5,
                 Name = "Sea salt",
                 Measurement = Measurement.Teaspoon,
                 Amount = 0.5
             },
             new
             {
                 Id = 13,
                 RecipeId = 5,
                 Name = "Extra virgin olive oil",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 14,
                 RecipeId = 5,
                 Name = "Red wine vinegar",
                 Measurement = Measurement.Tablespoon,
                 Amount = 2.0
             });


            builder.HasData(
           new Recipe
           {
               Id = 6,
               Category = Category.Breakfast,
               PreparationTime = new TimeSpan(0, 20, 0),
               CookingTime = new TimeSpan(0, 30, 0),
               Name = "Eggs Benedict",
               Instruction = new List<string>
                    {
                        "Preheat oven to 375°F.",
                        "Butter each half of the English muffins with ½ tablespoon butter. Arrange muffins on a large baking sheet and place them on the center rack. Bake until golden and crispy, about 10 minutes.",
                        "While muffins are toasting, heat the hollandaise sauce and poached eggs according to respective recipe instructions.",
                        "Arrange the toasted English muffins on a large platter. Top each half with ham or Canadian bacon. Top with a poached egg. Drizzle hollandaise sauce over the entire platter and top with fresh herbs. Serve immediately."
                    }
           });


            builder.OwnsMany(r => r.Ingredients).HasData(
             new
             {
                 Id = 1,
                 RecipeId = 6,
                 Name = "Poached eggs",
                 Measurement = Measurement.Piece,
                 Amount = 12.0
             },
             new
             {
                 Id = 2,
                 RecipeId = 6,
                 Name = "Hollandaise sauce",
                 Measurement = Measurement.ToTaste
             },
             new
             {
                 Id = 3,
                 RecipeId = 6,
                 Name = "English muffins",
                 Measurement = Measurement.Piece,
                 Amount = 6.0
             },
             new
             {
                 Id = 4,
                 RecipeId = 6,
                 Name = "Salted butter",
                 Measurement = Measurement.Tablespoon,
                 Amount = 3.0
             },
             new
             {
                 Id = 5,
                 RecipeId = 6,
                 Name = "Ham",
                 Measurement = Measurement.ToTaste
             },
             new
             {
                 Id = 6,
                 RecipeId = 6,
                 Name = "Fresh herbs",
                 Measurement = Measurement.Cup,
                 Amount = 0.25
             });



            builder.HasData(
             new Recipe
             {
                 Id = 7,
                 Category = Category.Breakfast | Category.DairyFree | Category.GlutenFree |
                               Category.LowCarb | Category.Vegetarian,
                 PreparationTime = new TimeSpan(0, 5, 0),
                 CookingTime = new TimeSpan(0, 10, 0),
                 Name = "Poached Eggs",
                 Instruction = new List<string>
                 {
                        "Fill a large pot with 4-5 inches of water. Bring to a low boil.",
                        "Working with one egg at a time, crack the egg into a mesh strainer over your sink. Shake the strainer to get rid of any egg whites that are already separated. Transfer egg to a small bowl.",
                        "Carefully lower the egg into the simmering water by tipping to bowl sideways as close to the edge of the water as you can get, allowing the egg to slip out of the bowl.",
                        "Cook egg for 3 minutes. Remove using a slotted spoon and transfer to a bowl of cold water or serve immediately."
                 }
             });


            builder.OwnsMany(r => r.Ingredients).HasData(
              new
              {
                  Id = 1,
                  RecipeId = 7,
                  Name = "Egg",
                  Measurement = Measurement.Piece,
                  Amount = 1.0
              });


            builder.HasData(
             new Recipe
             {
                 Id = 8,
                 Category = Category.Dinner,
                 PreparationTime = new TimeSpan(0, 20, 0),
                 CookingTime = new TimeSpan(0, 25, 0),
                 Name = "Chicken Parmesan",
                 Instruction = new List<string>
                 {
                        "Preheat oven to 400° F.",
                        "Grab three shallow bowls, or rimmed plates, large enough to fit the size of your chicken breast. In one bowl beat the eggs until smooth. In the second bowl, place the flour and in the third bowl, mix together the Panko, bread crumbs and the parmesan cheese until fully combined.",
                        "In a small bowl mix together the garlic powder, sea salt salt, pepper and Italian seasoning. Season chicken filets on both sides with the seasoning. Dredge each filleted breast in the flour and gently shake off excess, then dip in the egg and let the excess drip off, then dredge on both sides in the bread crumbs, gently pressing to coat completely.",
                        "Heat 1/4 of the oil in a 12” skillet over medium-high heat until smoking. Add 3 chicken breast fillets and cook until golden brown, about 2 minutes per side. Transfer to a baking sheet. Add remaining oil and heat until smoking. Repeat the process with remaining chicken and transfer to the baking sheet.",
                        "Top each breast with 3-4 tablespoons of tomato sauce and 2 slices each of the mozzarella. Bake in the oven until the chicken is cooked through (chicken is done when the thickest part of the chicken reads 165°F with an instant read thermometer.) and the cheese is melted, about 10-14 minutes. Remove from the oven and garnish with basil, extra parmesan and red pepper flakes if desired."
                 }
             });

            builder.OwnsMany(r => r.Ingredients).HasData(
             new
             {
                 Id = 1,
                 RecipeId = 8,
                 Name = "Egg",
                 Measurement = Measurement.Piece,
                 Amount = 3.0
             },
             new
             {
                 Id = 2,
                 RecipeId = 8,
                 Name = "All purpose flour",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 3,
                 RecipeId = 8,
                 Name = "Panko breadcrumbs",
                 Measurement = Measurement.Cup,
                 Amount = 0.75
             },
             new
             {
                 Id = 4,
                 RecipeId = 8,
                 Name = "Bread crumbs",
                 Measurement = Measurement.Cup,
                 Amount = 0.33
             },
             new
             {
                 Id = 5,
                 RecipeId = 8,
                 Name = "Parmesan cheese",
                 Measurement = Measurement.Cup,
                 Amount = 0.75
             },
             new
             {
                 Id = 6,
                 RecipeId = 8,
                 Name = "Garlic powder",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 7,
                 RecipeId = 8,
                 Name = "Sea salt",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.5
             },
             new
             {
                 Id = 8,
                 RecipeId = 8,
                 Name = "Pepper",
                 Measurement = Measurement.Teaspoon,
                 Amount = 0.5
             },
             new
             {
                 Id = 9,
                 RecipeId = 8,
                 Name = "Italian seasoning",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 10,
                 RecipeId = 8,
                 Name = "Chicken breast",
                 Measurement = Measurement.Piece,
                 Amount = 3.0
             },
             new
             {
                 Id = 11,
                 RecipeId = 8,
                 Name = "Extra virgin olive oil",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 12,
                 RecipeId = 8,
                 Name = "Marinara sauce",
                 Measurement = Measurement.Jar,
                 Amount = 1.0
             },
             new
             {
                 Id = 13,
                 RecipeId = 8,
                 Name = "Mozzarella cheese",
                 Measurement = Measurement.FluidOunce,
                 Amount = 8.0
             },
             new
             {
                 Id = 14,
                 RecipeId = 8,
                 Name = "Basil",
                 Measurement = Measurement.Tablespoon,
                 Amount = 2.0
             },
             new
             {
                 Id = 15,
                 RecipeId = 8,
                 Name = "Red pepper flakes",
                 Measurement = Measurement.ToTaste
             });


            builder.HasData(
            new Recipe
            {
                Id = 9,
                Category = Category.Vegetarian | Category.Dinner,
                PreparationTime = new TimeSpan(0, 20, 0),
                CookingTime = new TimeSpan(0, 20, 0),
                Name = "Pasta Primavera",
                Instruction = new List<string>
                {
                        "Fill a large pot with 4 quarts of water and add 2 teaspoons of salt. Bring to a boil over high heat. Add the pasta and cook according to package instructions, about 8-12 minutes, drain.",
                        "While the water is heating up, heat 1 tablespoon olive oil in a large skillet, set over medium high heat. Add the shallots and carrots stirring until softened, about 5 minutes. Remove from the pan onto a plate. Add remaining olive oil to the pan, swirl to coat and add the zucchini and squash in a single layer. Cook for 2-3 minutes on each side, until golden brown. Remove the zucchini onto the plate with the carrots and shallots.",
                        "Add the butter to the pan. When it begins to bubble, about 2 minutes, add the cheese, milk, dried basil, garlic powder, pepper and the remaining 1/4 teaspoon of salt. Whisk until combined and smooth. Note: if you are using pre-grated parmesan the sauce might not get completely smooth and will result in a more grainy sauce, but will still taste lovely.",
                        "Add in the sun dried tomatoes and cherry tomatoes and toss until warmed through.",
                        "Drain the pasta, then immediately add it to the sauce and toss to coat. Add a splash more milk if the sauce is too thick or a sprinkle of extra parm if the sauce is too thin. Serve with fresh basil or flat leaf parsley and crushed red pepper flakes if desired."
                }
            });


            builder.OwnsMany(r => r.Ingredients).HasData(
            new
            {
                Id = 1,
                RecipeId = 9,
                Name = "Sea salt",
                Measurement = Measurement.Teaspoon,
                Amount = 2.25
            },
            new
            {
                Id = 2,
                RecipeId = 9,
                Name = "Pasta of your choice",
                Measurement = Measurement.FluidOunce,
                Amount = 12.0
            },
            new
            {
                Id = 3,
                RecipeId = 9,
                Name = "Extra virgin olive oil",
                Measurement = Measurement.Tablespoon,
                Amount = 2.0
            },
            new
            {
                Id = 4,
                RecipeId = 9,
                Name = "shallot",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 5,
                RecipeId = 9,
                Name = "Carrot",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 6,
                RecipeId = 9,
                Name = "Zucchini",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 7,
                RecipeId = 9,
                Name = "Yellow summer squash",
                Measurement = Measurement.Piece,
                Amount = 1.0
            },
            new
            {
                Id = 8,
                RecipeId = 9,
                Name = "Unsalted butter",
                Measurement = Measurement.Tablespoon,
                Amount = 6.0
            },
            new
            {
                Id = 9,
                RecipeId = 9,
                Name = "Parmesan cheese",
                Measurement = Measurement.Cup,
                Amount = 0.75
            },
            new
            {
                Id = 10,
                RecipeId = 9,
                Name = "Whole milk",
                Measurement = Measurement.Cup,
                Amount = 0.5
            },
            new
            {
                Id = 11,
                RecipeId = 9,
                Name = "Dried basil",
                Measurement = Measurement.Teaspoon,
                Amount = 1.0
            },
            new
            {
                Id = 12,
                RecipeId = 9,
                Name = "Garlic powder",
                Measurement = Measurement.Teaspoon,
                Amount = 0.5
            },
            new
            {
                Id = 13,
                RecipeId = 9,
                Name = "Sun dried tomatoes",
                Measurement = Measurement.Cup,
                Amount = 0.33
            },
            new
            {
                Id = 14,
                RecipeId = 9,
                Name = "Cherry tomatoes,",
                Measurement = Measurement.Cup,
                Amount = 1.5
            });


            builder.HasData(
           new Recipe
           {
               Id = 10,
               Category = Category.GlutenFree | Category.Vegetarian | Category.Dessert,
               PreparationTime = new TimeSpan(0, 25, 0),
               CookingTime = new TimeSpan(0, 45, 0),
               Name = "Sour Cream Coffee Cake",
               Instruction = new List<string>
               {
                        "Preheat oven to 350°F.",
                        "Begin by making the crumb topping. Combine the flour sugar, coconut, pecans and salt in a bowl. Using a cheese grater grate butter into the dry mix.** toss with a fork until butter and dry ingredients are evenly mixed. The crumble will appear to be dry, this method ensures an even middle ribbon of goodness and topping. Store the crumble in the refrigerator while preparing your batter.",
                        "For the cake batter sift flour, baking powder, baking soda and salt into a medium sized bowl and set aside. In a stand mixer, or by hand, whisk the softened butter until light and fluffy. Add the sugar slowly, followed by the eggs one at a time fully incorporating with each addition.",
                        "Add ⅓ of the sifted dry ingredients and ⅓ cup of the sour cream to the bowl of the stand mixer. Beat until they’re fully incorporated, then add the remaining sour cream and dry ingredients. Beat on high for about three minutes.",
                        "In a well-greased or parchment lined 9x9 baking dish add half of the batter followed by half of the crumble. Add the remaining batter and crumb topping. Bake for 45 min to an hour in a preheated. Check for doneness with a toothpick, which should come out clean. Cool on a wire rack for 30 minutes before serving."
               }
           });


            builder.OwnsMany(r => r.Ingredients).HasData(
          new
          {
              Id = 1,
              RecipeId = 10,
              Name = "White flour",
              Measurement = Measurement.Cup,
              Amount = 2.0
          },
          new
          {
              Id = 2,
              RecipeId = 10,
              Name = "Baking powder",
              Measurement = Measurement.Teaspoon,
              Amount = 1.5
          },
          new
          {
              Id = 3,
              RecipeId = 10,
              Name = "Baking soda",
              Measurement = Measurement.Teaspoon,
              Amount = 1.5
          },
          new
          {
              Id = 4,
              RecipeId = 10,
              Name = "Salt",
              Measurement = Measurement.Teaspoon,
              Amount = 0.5
          },
          new
          {
              Id = 5,
              RecipeId = 10,
              Name = "Unsalted butter",
              Measurement = Measurement.Cup,
              Amount = 1.0
          },
          new
          {
              Id = 6,
              RecipeId = 10,
              Name = "Egg",
              Measurement = Measurement.Piece,
              Amount = 2.0
          },
          new
          {
              Id = 7,
              RecipeId = 10,
              Name = "White sugar",
              Measurement = Measurement.Cup,
              Amount = 1.0
          },
          new
          {
              Id = 8,
              RecipeId = 10,
              Name = "Sour cream",
              Measurement = Measurement.Cup,
              Amount = 1.0
          },
          new
          {
              Id = 9,
              RecipeId = 10,
              Name = "All purpose flour",
              Measurement = Measurement.Cup,
              Amount = 0.25
          },
          new
          {
              Id = 10,
              RecipeId = 10,
              Name = "Brown sugar",
              Measurement = Measurement.Cup,
              Amount = 1.0
          },
          new
          {
              Id = 11,
              RecipeId = 10,
              Name = "Flaked coconut",
              Measurement = Measurement.Cup,
              Amount = 0.5
          },
          new
          {
              Id = 12,
              RecipeId = 10,
              Name = "Toasted walnuts",
              Measurement = Measurement.Cup,
              Amount = 1.0
          },
          new
          {
              Id = 13,
              RecipeId = 10,
              Name = "Salt",
              Measurement = Measurement.Teaspoon,
              Amount = 0.5
          },
          new
          {
              Id = 14,
              RecipeId = 10,
              Name = "Very cold unsalted butter",
              Measurement = Measurement.Cup,
              Amount = 0.5
          });


            builder.HasData(
          new Recipe
          {
              Id = 11,
              Category = Category.Dessert | Category.Vegetarian,
              PreparationTime = new TimeSpan(0, 5, 0),
              CookingTime = new TimeSpan(0, 10, 0),
              Name = "Adult Hot Chocolate",
              Instruction = new List<string>
              {
                        "In a small sauce pan heat milk, sugar, salt and vanilla over medium-low heat until sugar and salt are completely dissolved. Make sure the milk does not come to a boil. Add the chocolate in pieces, whisking until completely incorporated. Remove from heat.",
                        "Once removed from heat, stir in bourbon, frangelico and Irish cream. Serve immediately with marshmallows."
              }
          });


            builder.OwnsMany(r => r.Ingredients).HasData(
         new
         {
             Id = 1,
             RecipeId = 11,
             Name = "Whole milk",
             Measurement = Measurement.Cup,
             Amount = 4.0
         },
         new
         {
             Id = 2,
             RecipeId = 11,
             Name = "Sugar",
             Measurement = Measurement.Tablespoon,
             Amount = 2.0
         },
         new
         {
             Id = 3,
             RecipeId = 11,
             Name = "Vanilla bean ",
             Measurement = Measurement.Tablespoon,
             Amount = 0.5
         },
         new
         {
             Id = 4,
             RecipeId = 11,
             Name = "Dark chocolate",
             Measurement = Measurement.FluidOunce,
             Amount = 6.0
         },
         new
         {
             Id = 5,
             RecipeId = 11,
             Name = "Sea salt",
             Measurement = Measurement.Teaspoon,
             Amount = 1.0
         },
         new
         {
             Id = 6,
             RecipeId = 11,
             Name = "Bourbon",
             Measurement = Measurement.FluidOunce,
             Amount = 4.0
         },
         new
         {
             Id = 7,
             RecipeId = 11,
             Name = "Frangelico",
             Measurement = Measurement.FluidOunce,
             Amount = 2.0
         },
         new
         {
             Id = 8,
             RecipeId = 11,
             Name = "Irish cream",
             Measurement = Measurement.FluidOunce,
             Amount = 2.0
         },
         new
         {
             Id = 9,
             RecipeId = 11,
             Name = "Marshmallows",
             Measurement = Measurement.ToTaste
         });


            builder.HasData(
        new Recipe
        {
            Id = 12,
            Category = Category.Dessert | Category.Vegetarian,
            PreparationTime = new TimeSpan(0, 30, 0),
            CookingTime = new TimeSpan(0, 12, 0),
            Name = "Crinkle Cookies with Peppermint Cream",
            Instruction = new List<string>
            {
                        "Adjust oven rack to middle position and heat oven to 325° F. Line 2 baking sheets with parchment paper. We recommend using a kitchen scale for this recipe and weighing out the ingredients.",
                        "Whisk flour, cocoa, baking powder, baking soda, and salt together in bowl.",
                        "Whisk brown sugar; eggs; and vanilla together in large bowl. Combine chocolate and butter in bowl and microwave at 50 percent power, stirring occasionally, until melted, 2 to 3 minutes.",
                        "Whisk chocolate mixture into egg mixture until combined. Fold in flour mixture until no dry streaks remain. Let dough sit at room temperature for 10 minutes. Do not refrigerate.",
                        "Place granulated sugar and confectioners’ sugar in separate shallow dishes. Working with 1 rounded tablespoon of dough at a time, from the scoop, drop dough balls directly into granulated sugar and roll to coat. Transfer dough balls to confectioners’ sugar and roll to give each a heavy even coat. Evenly space dough balls on prepared sheets.",
                        "Bake cookies, 1 sheet at a time, until puffed and cracked and edges have begun to set but centers are still soft (cookies will look raw between cracks and seem underdone), about 12 minutes, rotating sheet halfway through baking. Let cool completely on sheet.",
                        "Using a stand mixer fitted with the paddle blade attachment, beat the butter until smooth and fluffy.",
                        "Add the powdered sugar a little bit at a time, with mixer running continuously.",
                        "Add in the cream and peppermint extract. Whip until completely smooth.",
                        "Place the unwrapped candy canes in a zip-lock bag. Using a rolling pin, crush the candy into small pieces. Pour the crushed candy onto a plate.",
                        "Once cookies have cooled completely, spread 2 tbsp frosting on the underside of one cookie and top with another. Roll edges into the crushed candy cane. Repeat for remaining cookies.",
            }
        });


            builder.OwnsMany(r => r.Ingredients).HasData(
             new
             {
                 Id = 1,
                 RecipeId = 12,
                 Name = "All-purpose flour",
                 Measurement = Measurement.FluidOunce,
                 Amount = 1.0
             },
             new
             {
                 Id = 2,
                 RecipeId = 12,
                 Name = "Unsweetened cocoa powder",
                 Measurement = Measurement.FluidOunce,
                 Amount = 0.5
             },
             new
             {
                 Id = 3,
                 RecipeId = 12,
                 Name = "Baking powder",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 4,
                 RecipeId = 12,
                 Name = "Baking soda",
                 Measurement = Measurement.Teaspoon,
                 Amount = 0.25
             },
             new
             {
                 Id = 5,
                 RecipeId = 12,
                 Name = "Salt",
                 Measurement = Measurement.Teaspoon,
                 Amount = 0.25
             },
             new
             {
                 Id = 6,
                 RecipeId = 12,
                 Name = "Brown sugar",
                 Measurement = Measurement.Teaspoon,
                 Amount = 10.25
             },
             new
             {
                 Id = 7,
                 RecipeId = 12,
                 Name = "Egg",
                 Measurement = Measurement.Piece,
                 Amount = 3.0
             },
             new
             {
                 Id = 8,
                 RecipeId = 12,
                 Name = "Vanilla extract",
                 Measurement = Measurement.Teaspoon,
                 Amount = 1.0
             },
             new
             {
                 Id = 9,
                 RecipeId = 12,
                 Name = "Unsweetened chocolate",
                 Measurement = Measurement.FluidOunce,
                 Amount = 4.0
             },
             new
             {
                 Id = 10,
                 RecipeId = 12,
                 Name = "Unsalted butter",
                 Measurement = Measurement.Tablespoon,
                 Amount = 4.0
             },
             new
             {
                 Id = 11,
                 RecipeId = 12,
                 Name = "Granulated sugar",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 12,
                 RecipeId = 12,
                 Name = "Confectioners' sugar",
                 Measurement = Measurement.Cup,
                 Amount = 0.5
             },
             new
             {
                 Id = 13,
                 RecipeId = 12,
                 Name = "Salted butter",
                 Measurement = Measurement.Cup,                            
                 Amount = 0.75,
             },
             new
             {
                 Id = 14,
                 RecipeId = 12,
                 Name = "Powdered sugar",
                 Measurement = Measurement.Cup,
                 Amount = 3.0,
             },
             new
             {
                 Id = 15,
                 RecipeId = 12,
                 Name = "Heavy cream",
                 Measurement = Measurement.Tablespoon,
                 Amount = 3.0,
             },
             new
             {
                 Id = 16,
                 RecipeId = 12,
                 Name = "Peppermint extract",
                 Measurement = Measurement.Teaspoon,
                 Amount = 2.0,
             },
             new
             {
                 Id = 17,
                 RecipeId = 12,
                 Name = "Peppermint candy canes",
                 Measurement = Measurement.Piece,
                 Amount = 8.0,
             });
        }
    }
}
