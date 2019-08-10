

namespace MordorCruelPlan.Factory
{
    public class MoodFactory
    {
        public string CheckMood(int mood)
        {
            if (mood < -5)
                return "Angry";
            else if (mood >= -5 && mood <= 0)
                return "Sad";
            else if (mood > 0 && mood < 16)
                return "Happy";
            

            return "JavaScript";
        }
    }
}
