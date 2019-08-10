

namespace WildFarm.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        void EatFood(double foodQuantity);

        string ProducingSound();
    }
}
