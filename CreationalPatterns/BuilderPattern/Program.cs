using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mealBuilder = new MealBuilder();

            var vegMeal = mealBuilder.PrepareVegMeal();

            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegMeal.GetCost());

            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());

            Console.ReadKey();
        }
    }
}
