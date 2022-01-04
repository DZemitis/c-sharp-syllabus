using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            return _currentSpeed += 15;
        }

        public int SlowDown()
        {
           return _currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "-- silence ---";
        }
    }
}