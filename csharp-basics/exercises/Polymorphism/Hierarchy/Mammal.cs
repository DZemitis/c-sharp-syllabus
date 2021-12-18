namespace Hierarchy
{
    public abstract class Mammal : Animal

    {
        protected string LivingRegion;

        protected Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override string DisplayAnimal()
        {
            return $"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion}";
        }
    }
}