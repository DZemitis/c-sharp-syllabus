using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sound = new List<ISound>()
            {
                new Firework(),
                new Parrot(),
                new Radio(),
                new Parrot(),
                new Parrot()
            };

            for (int i = 0; i < 10; i++)
            {
                foreach (var thing in sound)
                {
                    thing.PlaySound();
                }
            }
        }
    }
}