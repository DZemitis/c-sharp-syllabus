using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name)
        {
            if (!_data.ContainsKey(name))
            {
                return null;
            }

            return _data[name];
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            if (_data.ContainsKey(name))
            {
                _data[name] += number;
            }

            _data.Add(name, number);
        }
    }
}