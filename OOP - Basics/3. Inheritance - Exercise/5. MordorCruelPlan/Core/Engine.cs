using System;
using MordorCruelPlan.Factory;

namespace MordorCruelPlan.Core
{
    public class Engine
    {
        private FoodFactory foods;
        private MoodFactory moods;
        private GrayWizard gandalf;

        public Engine()
        {
            this.foods = new FoodFactory();
            this.moods = new MoodFactory();
            this.gandalf = new GrayWizard();
        }

        public void Run()
        {
            string[] inputFood = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string foodName in inputFood)
            {
                int currentPoint = foods.CheckFood(foodName);
                gandalf.FoodPoints += currentPoint;
            }

            gandalf.Moods = moods.CheckMood(gandalf.FoodPoints);
            print();
        }

        private void print()
        {
            Console.WriteLine($"{gandalf.FoodPoints}");
            Console.WriteLine($"{gandalf.Moods}");
        }
    }
}
