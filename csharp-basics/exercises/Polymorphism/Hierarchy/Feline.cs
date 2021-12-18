using System;

namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        protected Feline(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }
    }
}