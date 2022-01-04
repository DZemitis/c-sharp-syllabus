using System;

namespace DragRace
{
    public class VW : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            return _currentSpeed += 8;
        }

        public int SlowDown()
        {
           return _currentSpeed -= 8;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Puk.. Puk..";
        }
    }
}