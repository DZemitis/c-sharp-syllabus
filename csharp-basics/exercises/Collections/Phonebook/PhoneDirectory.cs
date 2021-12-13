using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;
        private int _dataCount;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
            _dataCount = 0;
        }

        private string Find(string name)
        {
            for (var i = 0; i < _dataCount; i++)
            {
                if (_data.ContainsKey(name))
                {
                    return name;
                }
            }

            return "No number";
        }


        public string GetNumber(string name)
        {
            var position = Find(name);
            if (position == "No number")
            {
                return "No number";
            }
            else
            {
                string value = _data[name];
                return value;
            }
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
            else
            {
                _data.Add(name, number);
                _dataCount++;
            }
        }
    }
}