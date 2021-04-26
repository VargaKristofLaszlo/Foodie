using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodie.Dal.Migrations
{
    public partial class Addedmoredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "CookingTime", "Instruction", "Name", "PreparationTime" },
                values: new object[] { 2, 33, new TimeSpan(0, 0, 25, 0, 0), "Sauté onions and peppers in olive oil over medium heat. Sauté until onions are just tender. Add garlic and cook for 2 more minutes. Add tomatoes, curry paste, chicken stock and chickpeas and bring to rapid simmer. Stir until paste is dissolved. Add coconut milk, fish sauce and lime juice, bring back to a simmer and allow to cook for 10 minutes.;Add chicken and cook for 10 minutes at a simmer until chicken is cooked through. Season with salt and add kale/spinach. Cook for 3 more minutes and serve as is or over cauliflower rice.;You may need to adjust the seasonings just a bit. Use less curry paste if you don't like it with a little “kick”.", "Coconut Curry Soup with Chicken, Chickpeas and Hearty Greens", new TimeSpan(0, 0, 10, 0, 0) });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "RecipeId", "Id", "Amount", "Measurement", "Name" },
                values: new object[,]
                {
                    { 2, 1, 1.0, 3, "Olive oil" },
                    { 2, 2, 1.0, 0, "onion" },
                    { 2, 3, 2.0, 0, "Red bell pepper" },
                    { 2, 4, 4.0, 0, "Garlic cloves" },
                    { 2, 5, 1.0, 9, "Diced Tomatoe" },
                    { 2, 6, 1.0, 9, "Chickpea" },
                    { 2, 7, 4.0, 5, "Chicken stock" },
                    { 2, 8, 2.0, 9, "Full fat coconut milk" },
                    { 2, 9, 2.0, 3, "Red curry paste" },
                    { 2, 10, 2.0, 1, "Fish sauce" },
                    { 2, 11, null, 12, "Lemon juice" },
                    { 2, 12, 0.68000000000000005, 11, "Chicken breasts" },
                    { 2, 13, 2.0, 5, "Kale" },
                    { 2, 14, null, 12, "Salt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
