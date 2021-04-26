using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodie.Dal.Migrations
{
    public partial class Addedsomedatatothedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRecipes",
                table: "UserRecipes");

            migrationBuilder.DropIndex(
                name: "IX_UserRecipes_RecipeId",
                table: "UserRecipes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRecipes");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "CookingTime",
                table: "Recipes",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Recipes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreparationTime",
                table: "Recipes",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Ingredient",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRecipes",
                table: "UserRecipes",
                columns: new[] { "RecipeId", "UserId" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "CookingTime", "Instruction", "Name", "PreparationTime" },
                values: new object[] { 1, 225, new TimeSpan(0, 0, 36, 0, 0), "In a large pot, heat olive oil and sauté the onions for 5 minutes. Add garlic and continue cooking for 1 more minute.;Add all the remaining ingredients, using 3 cups of chicken stock (except the lime juice) to the pot.;Bring to a simmer and allow to cook for 30 minutes, until the chicken is cooked through.;Stir in lime juice and serve with avocado and cilantro.", "Green Chicken Chili Soup", new TimeSpan(0, 0, 15, 0, 0) });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "RecipeId", "Id", "Amount", "Measurement", "Name" },
                values: new object[,]
                {
                    { 1, 1, 2.0, 3, "Olive oil" },
                    { 1, 2, 1.0, 0, "Onion" },
                    { 1, 3, 4.0, 0, "Garlic cloves" },
                    { 1, 4, 2.0, 5, "Chicken stock" },
                    { 1, 5, 1.0, 9, "White beans" },
                    { 1, 6, 1.0, 9, "Salsa verde" },
                    { 1, 7, 1.0, 9, "Green chilis" },
                    { 1, 8, 1.0, 0, "Green bell pepper" },
                    { 1, 9, 1.0, 0, "Jalapeno" },
                    { 1, 10, 0.68000000000000005, 11, "Chicken breast" },
                    { 1, 11, 1.0, 1, "Cumin" },
                    { 1, 12, 1.0, 1, "Chili powder" },
                    { 1, 13, 1.0, 1, "Salt" },
                    { 1, 14, 2.0, 3, "Lime juice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRecipes",
                table: "UserRecipes");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumns: new[] { "RecipeId", "Id" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CookingTime",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PreparationTime",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserRecipes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Ingredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRecipes",
                table: "UserRecipes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRecipes_RecipeId",
                table: "UserRecipes",
                column: "RecipeId");
        }
    }
}
