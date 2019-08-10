

namespace MordorCruelPlan
{
    public class GrayWizard
    {
        private int foodPoints;
        private string moods;

        public GrayWizard()
        {
            this.FoodPoints = 0;
            this.Moods = "Sad";
        }

        public int FoodPoints
        {
            get => foodPoints;
            set => foodPoints = value;
        }

        public string Moods
        {
            get => moods;
            set => moods = value;
        }

        public override string ToString()
        {
            return $"{this.FoodPoints}\n{this.Moods}";
        }
    }
}
