namespace Hierarchy
{
    public class Cat : Feline
    {
        private string _breed;
        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return "Murrrrr...";
        }

        public override string EatFood(Food type)
        {
            FoodEaten += type.Quantity;
            return $"{AnimalType} [{AnimalName}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override string DisplayAnimal()
        {
            return $"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion} {_breed}";
        }
    }
}