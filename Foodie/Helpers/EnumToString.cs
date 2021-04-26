

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
    }
}