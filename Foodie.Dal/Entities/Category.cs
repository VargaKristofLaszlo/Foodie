using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal.Entities
{
    [Flags]
    public enum Category
    {
        Default = 0,
        Soup = 1,
        Salad = 2,
        Breakfast = 4,
        Dinner = 8,
        Dessert = 16,
        GlutenFree = 32,
        LowCarb = 64,
        DairyFree = 128,
        Vegetarian = 256
    }
}
