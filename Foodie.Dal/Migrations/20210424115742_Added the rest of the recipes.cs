using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodie.Dal.Migrations
{
    public partial class Addedtherestoftherecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "CookingTime", "Instruction", "Name", "PreparationTime" },
                values: new object[,]
                {
                    { 3, 33, new TimeSpan(0, 0, 25, 0, 0), "Heat oil in a large pot set over medium-high heat. Add the onion and cook, stirring often until beginning to soften, about 4 minutes.;Add the garlic and bell peppers and cook, stirring often, until the garlic is fragrant and bell peppers begin to soften, about 2-3 more minutes longer.;Add the chicken stock, black beans, cumin, garlic powder, oregano, chili powder, salt and pepper. Turn the heat to high and bring to a boil. Once boiling, reduce the heat back down to medium-low and simmer for 10-15 minutes.;Using an immersion blender or stand blender, blend 1/3 of the soup. This step creates a thick, creamy texture to the soup.;Add the sausage to the soup and cook until the sausage is heated through.;Serve the soup topped with cilantro, sour cream and extra onion, if desired.", "Black Bean Soup", new TimeSpan(0, 0, 10, 0, 0) },
                    { 4, 258, new TimeSpan(0, 1, 35, 0, 0), "Pulse the butter, shortening flour and salt together in the base of a food processor (alternatively you can cut the butter and shortening into the flour by hand with a fork or pastry cutter) until butter and shortening are pea sized. Add the ice water one tablespoon at a time pulsing or mixing until dough just starts to come together. Do not over mix. Using your hands form a ball with the dough, wrap it in saran wrap and chill in the refrigerator for 30 minutes.;On a lightly floured surface roll out dough into a circle ¼-inch thick. Carefully press the dough into a tart pan, cutting away excess dough. Puncture dough with a fork a dozen times and chill for 30 minutes longer.;Preheat oven to 400°F. Cover the pie with a piece of foil and bake for 20 minutes. Remove the foil and continue to bake for another 10 minutes, or until crust is just set.;In a large saucepan with a tight fitting lid set over medium heat, melt 4 tablespoons butter and 2 tablespoons oil. Reduce heat to medium-low and add onions, leeks, scallions and shallots. Cover with a lid and cook for 10 minutes. Remove cover and continue to cook, stirring often, until onions turn a golden brown color. This process should take about 30 minutes. Remove from heat and allow to cool, about 20 minutes.;In a large bowl whisk together eggs, crème fraîche, salt, nutmeg, pepper and chives. Add the onion mixture to the egg mixture and stir until onions are evenly distributed. Pour into the tart crust and bake for 25-35 minutes, until eggs are set and the crust is golden brown.;Just before serving toss the arugula with desired amount of olive oil, salt and pepper. Add the salad to the top of the tart and serve.", "Five Onion Tart with Arugula Salad", new TimeSpan(0, 1, 5, 0, 0) },
                    { 5, 354, new TimeSpan(0, 0, 5, 0, 0), "To make the dressing place all the ingredients in a jar with a tight fitting lid. Shake vigorously until all ingredients are combined. Store in refrigerator for a week. Shake before each use.;To make the salad, place all ingredients in a large salad bowl. Drizzle with Italian dressing and toss to combine.", "Simple Italian Salad", new TimeSpan(0, 0, 10, 0, 0) },
                    { 6, 4, new TimeSpan(0, 0, 30, 0, 0), "Preheat oven to 375°F.;Butter each half of the English muffins with ½ tablespoon butter. Arrange muffins on a large baking sheet and place them on the center rack. Bake until golden and crispy, about 10 minutes.;While muffins are toasting, heat the hollandaise sauce and poached eggs according to respective recipe instructions.;Arrange the toasted English muffins on a large platter. Top each half with ham or Canadian bacon. Top with a poached egg. Drizzle hollandaise sauce over the entire platter and top with fresh herbs. Serve immediately.", "Eggs Benedict", new TimeSpan(0, 0, 20, 0, 0) },
                    { 7, 484, new TimeSpan(0, 0, 10, 0, 0), "Fill a large pot with 4-5 inches of water. Bring to a low boil.;Working with one egg at a time, crack the egg into a mesh strainer over your sink. Shake the strainer to get rid of any egg whites that are already separated. Transfer egg to a small bowl.;Carefully lower the egg into the simmering water by tipping to bowl sideways as close to the edge of the water as you can get, allowing the egg to slip out of the bowl.;Cook egg for 3 minutes. Remove using a slotted spoon and transfer to a bowl of cold water or serve immediately.", "Poached Eggs", new TimeSpan(0, 0, 5, 0, 0) },
                    { 8, 8, new TimeSpan(0, 0, 25, 0, 0), "Preheat oven to 400° F.;Grab three shallow bowls, or rimmed plates, large enough to fit the size of your chicken breast. In one bowl beat the eggs until smooth. In the second bowl, place the flour and in the third bowl, mix together the Panko, bread crumbs and the parmesan cheese until fully combined.;In a small bowl mix together the garlic powder, sea salt salt, pepper and Italian seasoning. Season chicken filets on both sides with the seasoning. Dredge each filleted breast in the flour and gently shake off excess, then dip in the egg and let the excess drip off, then dredge on both sides in the bread crumbs, gently pressing to coat completely.;Heat 1/4 of the oil in a 12” skillet over medium-high heat until smoking. Add 3 chicken breast fillets and cook until golden brown, about 2 minutes per side. Transfer to a baking sheet. Add remaining oil and heat until smoking. Repeat the process with remaining chicken and transfer to the baking sheet.;Top each breast with 3-4 tablespoons of tomato sauce and 2 slices each of the mozzarella. Bake in the oven until the chicken is cooked through (chicken is done when the thickest part of the chicken reads 165°F with an instant read thermometer.) and the cheese is melted, about 10-14 minutes. Remove from the oven and garnish with basil, extra parmesan and red pepper flakes if desired.", "Chicken Parmesan", new TimeSpan(0, 0, 20, 0, 0) },
                    { 9, 264, new TimeSpan(0, 0, 20, 0, 0), "Fill a large pot with 4 quarts of water and add 2 teaspoons of salt. Bring to a boil over high heat. Add the pasta and cook according to package instructions, about 8-12 minutes, drain.;While the water is heating up, heat 1 tablespoon olive oil in a large skillet, set over medium high heat. Add the shallots and carrots stirring until softened, about 5 minutes. Remove from the pan onto a plate. Add remaining olive oil to the pan, swirl to coat and add the zucchini and squash in a single layer. Cook for 2-3 minutes on each side, until golden brown. Remove the zucchini onto the plate with the carrots and shallots.;Add the butter to the pan. When it begins to bubble, about 2 minutes, add the cheese, milk, dried basil, garlic powder, pepper and the remaining 1/4 teaspoon of salt. Whisk until combined and smooth. Note: if you are using pre-grated parmesan the sauce might not get completely smooth and will result in a more grainy sauce, but will still taste lovely.;Add in the sun dried tomatoes and cherry tomatoes and toss until warmed through.;Drain the pasta, then immediately add it to the sauce and toss to coat. Add a splash more milk if the sauce is too thick or a sprinkle of extra parm if the sauce is too thin. Serve with fresh basil or flat leaf parsley and crushed red pepper flakes if desired.", "Pasta Primavera", new TimeSpan(0, 0, 20, 0, 0) },
                    { 10, 304, new TimeSpan(0, 0, 45, 0, 0), "Preheat oven to 350°F.;Begin by making the crumb topping. Combine the flour sugar, coconut, pecans and salt in a bowl. Using a cheese grater grate butter into the dry mix.** toss with a fork until butter and dry ingredients are evenly mixed. The crumble will appear to be dry, this method ensures an even middle ribbon of goodness and topping. Store the crumble in the refrigerator while preparing your batter.;For the cake batter sift flour, baking powder, baking soda and salt into a medium sized bowl and set aside. In a stand mixer, or by hand, whisk the softened butter until light and fluffy. Add the sugar slowly, followed by the eggs one at a time fully incorporating with each addition.;Add ⅓ of the sifted dry ingredients and ⅓ cup of the sour cream to the bowl of the stand mixer. Beat until they’re fully incorporated, then add the remaining sour cream and dry ingredients. Beat on high for about three minutes.;In a well-greased or parchment lined 9x9 baking dish add half of the batter followed by half of the crumble. Add the remaining batter and crumb topping. Bake for 45 min to an hour in a preheated. Check for doneness with a toothpick, which should come out clean. Cool on a wire rack for 30 minutes before serving.", "Sour Cream Coffee Cake", new TimeSpan(0, 0, 25, 0, 0) },
                    { 11, 272, new TimeSpan(0, 0, 10, 0, 0), "In a small sauce pan heat milk, sugar, salt and vanilla over medium-low heat until sugar and salt are completely dissolved. Make sure the milk does not come to a boil. Add the chocolate in pieces, whisking until completely incorporated. Remove from heat.;Once removed from heat, stir in bourbon, frangelico and Irish cream. Serve immediately with marshmallows.", "Adult Hot Chocolate", new TimeSpan(0, 0, 5, 0, 0) },
                    { 12, 272, new TimeSpan(0, 0, 12, 0, 0), "Adjust oven rack to middle position and heat oven to 325° F. Line 2 baking sheets with parchment paper. We recommend using a kitchen scale for this recipe and weighing out the ingredients.;Whisk flour, cocoa, baking powder, baking soda, and salt together in bowl.;Whisk brown sugar; eggs; and vanilla together in large bowl. Combine chocolate and butter in bowl and microwave at 50 percent power, stirring occasionally, until melted, 2 to 3 minutes.;Whisk chocolate mixture into egg mixture until combined. Fold in flour mixture until no dry streaks remain. Let dough sit at room temperature for 10 minutes. Do not refrigerate.;Place granulated sugar and confectioners’ sugar in separate shallow dishes. Working with 1 rounded tablespoon of dough at a time, from the scoop, drop dough balls directly into granulated sugar and roll to coat. Transfer dough balls to confectioners’ sugar and roll to give each a heavy even coat. Evenly space dough balls on prepared sheets.;Bake cookies, 1 sheet at a time, until puffed and cracked and edges have begun to set but centers are still soft (cookies will look raw between cracks and seem underdone), about 12 minutes, rotating sheet halfway through baking. Let cool completely on sheet.;Using a stand mixer fitted with the paddle blade attachment, beat the butter until smooth and fluffy.;Add the powdered sugar a little bit at a time, with mixer running continuously.;Add in the cream and peppermint extract. Whip until completely smooth.;Place the unwrapped candy canes in a zip-lock bag. Using a rolling pin, crush the candy into small pieces. Pour the crushed candy onto a plate.;Once cookies have cooled completely, spread 2 tbsp frosting on the underside of one cookie and top with another. Roll edges into the crushed candy cane. Repeat for remaining cookies.", "Crinkle Cookies with Peppermint Cream", new TimeSpan(0, 0, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "RecipeId", "Id", "Amount", "Measurement", "Name" },
                values: new object[,]
                {
                    { 3, 1, 2.0, 3, "Extra virgin olive oil" },
                    { 10, 7, 1.0, 5, "White sugar" },
                    { 10, 6, 2.0, 0, "Egg" },
                    { 10, 5, 1.0, 5, "Unsalted butter" },
                    { 10, 4, 0.5, 1, "Salt" },
                    { 10, 3, 1.5, 1, "Baking soda" },
                    { 10, 2, 1.5, 1, "Baking powder" },
                    { 10, 1, 2.0, 5, "White flour" },
                    { 9, 14, 1.5, 5, "Cherry tomatoes," },
                    { 9, 13, 0.33000000000000002, 5, "Sun dried tomatoes" },
                    { 9, 12, 0.5, 1, "Garlic powder" },
                    { 9, 11, 1.0, 1, "Dried basil" },
                    { 9, 10, 0.5, 5, "Whole milk" },
                    { 9, 9, 0.75, 5, "Parmesan cheese" },
                    { 9, 8, 6.0, 3, "Unsalted butter" },
                    { 9, 7, 1.0, 0, "Yellow summer squash" },
                    { 9, 6, 1.0, 0, "Zucchini" },
                    { 9, 5, 1.0, 0, "Carrot" },
                    { 9, 4, 1.0, 0, "shallot" },
                    { 9, 3, 2.0, 3, "Extra virgin olive oil" },
                    { 9, 2, 12.0, 4, "Pasta of your choice" },
                    { 9, 1, 2.25, 1, "Sea salt" },
                    { 8, 15, null, 12, "Red pepper flakes" },
                    { 8, 14, 2.0, 3, "Basil" },
                    { 8, 13, 8.0, 4, "Mozzarella cheese" },
                    { 8, 12, 1.0, 10, "Marinara sauce" },
                    { 8, 11, 0.5, 5, "Extra virgin olive oil" },
                    { 8, 10, 3.0, 0, "Chicken breast" },
                    { 10, 8, 1.0, 5, "Sour cream" },
                    { 8, 9, 1.0, 1, "Italian seasoning" },
                    { 10, 9, 0.25, 5, "All purpose flour" },
                    { 10, 11, 0.5, 5, "Flaked coconut" },
                    { 12, 15, 3.0, 3, "Heavy cream" },
                    { 12, 14, 3.0, 5, "Powdered sugar" },
                    { 12, 13, 0.75, 5, "Salted butter" },
                    { 12, 12, 0.5, 5, "Confectioners' sugar" },
                    { 12, 11, 0.5, 5, "Granulated sugar" },
                    { 12, 10, 4.0, 3, "Unsalted butter" },
                    { 12, 9, 4.0, 4, "Unsweetened chocolate" },
                    { 12, 8, 1.0, 1, "Vanilla extract" },
                    { 12, 7, 3.0, 0, "Egg" },
                    { 12, 6, 10.25, 1, "Brown sugar" },
                    { 12, 5, 0.25, 1, "Salt" },
                    { 12, 4, 0.25, 1, "Baking soda" },
                    { 12, 3, 1.0, 1, "Baking powder" },
                    { 12, 2, 0.5, 4, "Unsweetened cocoa powder" },
                    { 12, 1, 1.0, 4, "All-purpose flour" },
                    { 11, 9, null, 12, "Marshmallows" },
                    { 11, 8, 2.0, 4, "Irish cream" },
                    { 11, 7, 2.0, 4, "Frangelico" },
                    { 11, 6, 4.0, 4, "Bourbon" },
                    { 11, 5, 1.0, 1, "Sea salt" },
                    { 11, 4, 6.0, 4, "Dark chocolate" },
                    { 11, 3, 0.5, 3, "Vanilla bean " },
                    { 11, 2, 2.0, 3, "Sugar" },
                    { 11, 1, 4.0, 5, "Whole milk" },
                    { 10, 14, 0.5, 5, "Very cold unsalted butter" },
                    { 10, 13, 0.5, 1, "Salt" },
                    { 10, 12, 1.0, 5, "Toasted walnuts" },
                    { 10, 10, 1.0, 5, "Brown sugar" },
                    { 8, 8, 0.5, 1, "Pepper" },
                    { 8, 7, 1.5, 1, "Sea salt" },
                    { 8, 6, 1.0, 1, "Garlic powder" },
                    { 4, 12, 4.0, 0, "Eggs" },
                    { 4, 11, 2.0, 0, "Shallots" },
                    { 4, 10, 4.0, 0, "Green onion" },
                    { 4, 9, 2.0, 0, "Leeks" },
                    { 4, 8, 1.0, 0, "Yellow onion" },
                    { 4, 7, 2.0, 3, "Olive oil" },
                    { 4, 6, 4.0, 3, "Butter" },
                    { 4, 5, 5.0, 3, "Ice water" },
                    { 4, 4, 0.5, 1, "Sea salt" },
                    { 4, 3, 2.0, 5, "All purpose flour" },
                    { 4, 2, 0.5, 5, "Vegetable shortening" },
                    { 4, 1, 0.5, 5, "Unsalted butter" },
                    { 3, 16, null, 12, "Sour cream" },
                    { 3, 15, null, 12, "Cilantro" },
                    { 3, 14, 0.45000000000000001, 11, "Smoked sausage" },
                    { 3, 13, 0.5, 1, "Freshly ground pepper" },
                    { 3, 12, 1.0, 1, "Kosher salt" },
                    { 3, 11, 1.0, 3, "Chili powder" },
                    { 3, 10, 2.0, 1, "Dried oregano" },
                    { 3, 9, 2.0, 1, "Garlic powder" },
                    { 3, 8, 2.0, 1, "Ground cumin" },
                    { 3, 7, 3.0, 9, "Black bean" },
                    { 3, 6, 4.0, 5, "Chicken stock" },
                    { 3, 5, 1.0, 0, "Green bell pepper" },
                    { 3, 4, 1.0, 0, "Red bell peppers" },
                    { 3, 3, 4.0, 0, "Garlic cloves" },
                    { 3, 2, 1.0, 0, "Red onion" },
                    { 4, 13, 0.33000000000000002, 5, "Crème fraîche" },
                    { 4, 14, null, 12, "Salt" },
                    { 4, 15, 0.25, 1, "Nutmeg" },
                    { 4, 16, null, 12, "Pepper" },
                    { 8, 5, 0.75, 5, "Parmesan cheese" },
                    { 8, 4, 0.33000000000000002, 5, "Bread crumbs" },
                    { 8, 3, 0.75, 5, "Panko breadcrumbs" },
                    { 8, 2, 0.5, 5, "All purpose flour" },
                    { 8, 1, 3.0, 0, "Egg" },
                    { 7, 1, 1.0, 0, "Egg" },
                    { 6, 6, 0.25, 5, "Fresh herbs" },
                    { 6, 5, null, 12, "Ham" },
                    { 6, 4, 3.0, 3, "Salted butter" },
                    { 6, 3, 6.0, 0, "English muffins" },
                    { 6, 2, null, 12, "Hollandaise sauce" },
                    { 6, 1, 12.0, 0, "Poached eggs" },
                    { 5, 14, 2.0, 3, "Red wine vinegar" },
                    { 12, 16, 2.0, 1, "Peppermint extract" },
                    { 5, 13, 0.5, 5, "Extra virgin olive oil" },
                    { 5, 11, 1.0, 1, "Dried basil" },
                    { 5, 10, 1.0, 1, "Dried oregano" },
                    { 5, 9, 1.0, 1, "Garlic powder" },
                    { 5, 8, null, 12, "Croutons" },
                    { 5, 7, null, 12, "Pepper" },
                    { 5, 6, 1.0, 6, "Cherry tomatoes" },
                    { 5, 5, 0.5, 5, "Black olives" },
                    { 5, 4, 1.0, 5, "Peperoncini" },
                    { 5, 3, 0.5, 5, "Parmesan cheese" },
                    { 5, 2, 0.5, 0, "Red onion" },
                    { 5, 1, 1.0, 13, "Leafy romaine lettuce" },
                    { 4, 18, 4.0, 5, "Arugula" },
                    { 4, 17, 0.5, 5, "Chives" },
                    { 5, 12, 0.5, 1, "Sea salt" },
                    { 12, 17, 8.0, 0, "Peppermint candy canes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
