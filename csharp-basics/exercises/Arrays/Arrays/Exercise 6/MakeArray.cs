using System;
using System.Linq;

namespace Exercise_6
{
    public class MakeArray
    {
        private readonly int _min = 1;
        private readonly int _max = 100;
        private int[] _array;
        private int[] _array2;
        private readonly int _arrayLength = 10;

        public MakeArray()
        {
            _array = new int[_arrayLength];
            _array2 = new int[_arrayLength];
        }

        public int[] RandomArray()
        {
            Random random = new Random();
            return _array = Enumerable.Repeat(0, _arrayLength).Select(i => random.Next(_min, _max)).ToArray();
        }
        
        public int[] ClonedArray(int[] array)
        {
            array.CopyTo(_array2, 0);
            _array2[9] = -7;
            return _array2;
        }

        public string PrintArray(string arrayName)
        {
            var x = $"{arrayName} :";
            foreach (var n in _array)
            {
                x += $" {n}";
            }

            return x;
        }
    }
}