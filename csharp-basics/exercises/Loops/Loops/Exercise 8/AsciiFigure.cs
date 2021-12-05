using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        private static int _input = int.Parse(Console.ReadLine());
        private static int _boosterNumber = MODIFIER + _input;
        public static int SideLen = (((_input * 3) + _boosterNumber));
        public const int MODIFIER = -4;

        public static void DrawAscii(int sideLen)
        {

            Console.Write(new string('/', sideLen));
            Console.Write(new string('\\', sideLen));
            Console.WriteLine();

            for (int row = 1; row < _input - 1; row++)
            {
                Console.Write(new string('/', sideLen - (row * 4)));
                Console.Write(new string('*', (4 * row) * 2));
                Console.Write(new string('\\', sideLen - (row * 4)));
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', (sideLen * 2)));
        }
    }
}