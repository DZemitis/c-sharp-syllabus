using System;

namespace Exercise_7
{
    public class Dog
    {
        public string Name;
        public string Sex;
        public string Father;
        public string Mother;

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public Dog(string name, string sex, string father, string mother):this(name,sex)
        {
            Father = father ?? "unknown";
            Mother = mother ?? "unknown";
        }

        public string fathersName()
        {
            return $"{Name}'s dad is {Father ?? "unknown"}";
        }
        public string SameMother(Dog name)
        {
            return $"{Name} has same mother as {name}";
        }
        public bool HasSameMother(Dog dog, Dog otherDog)
        {
            if (dog.Mother == otherDog.Mother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}