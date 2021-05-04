

using Foodie.Dal.Entities;

namespace Foodie.Web.Helpers
{
    public static class EnumToString
    {
        public static string ValueToString(this Category category)
        {
            switch (category)
            {
                case Category.GlutenFree:
                    return "Gluten free";
                case Category.LowCarb:
                    return "Low carb";
                case Category.DairyFree:
                    return "Dairy free";
                default:
                    return category.ToString();
            }
        }

        public static string ValueToString(this Measurement measurement)
        {
            switch (measurement)
            {
                case Measurement.Piece:
                    return "piece";
                case Measurement.Teaspoon:
                    return "tsp";
                case Measurement.Dessertspoon:
                    return "dstspn";
                case Measurement.Tablespoon:
                    return "tbsp";
                case Measurement.FluidOunce:
                    return "ounce";
                case Measurement.Cup:
                    return "cup";
                case Measurement.Pint:
                    return "pint";
                case Measurement.Quart:
                    return "quart";
                case Measurement.Gallon:
                    return "gallon";
                case Measurement.Can:
                    return "can";
                case Measurement.Jar:
                    return "jar";
                case Measurement.Kilogram:
                    return "kg";
                case Measurement.ToTaste:
                    return "to taste";
                case Measurement.Head:
                    return "head";
                default:
                    return string.Empty;
            }
        }
    }
}