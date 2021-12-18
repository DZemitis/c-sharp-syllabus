namespace Hierarchy
{
    public abstract class Animal
    {
        protected string AnimalName;
        protected string AnimalType;
        protected double AnimalWeight;
        protected int FoodEaten;

        protected Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = foodEaten;
        }

        public abstract string MakeSound();

        public abstract string EatFood(Food type);

        public virtual string DisplayAnimal()
        {
            return $"{AnimalType} {AnimalName} {AnimalWeight} {FoodEaten}";
        }

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName}, {AnimalWeight}, {FoodEaten}";
        }
    }
}