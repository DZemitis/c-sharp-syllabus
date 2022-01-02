using System;

namespace DragRace
{
    public class Nissan : ICar, IBoostable
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
            return "Brum.. Brum..";
        }
        
        public int UseNitrousOxideEngine()
        {
           return _currentSpeed += 25;
        }
    }
}