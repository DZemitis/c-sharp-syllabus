using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
           return _currentSpeed += 10;
        }

        public int SlowDown()
        {
           return _currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}