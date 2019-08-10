

namespace MordorCruelPlan.Factory
{
    public class FoodFactory
    {
        public int CheckFood(string foodName)
        {
            switch (foodName.ToLower())
            {
                case "cram": return 2;
                case "lembas": return 3;
                case "apple": return 1;
                case "melon": return 1;
                case "honeycake": return 5;
                case "mushrooms": return -10;
                default: return -1;
            }
        }
    }
}
