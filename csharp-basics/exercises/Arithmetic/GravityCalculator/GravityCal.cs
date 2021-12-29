using System;

namespace GravityCalculator
{
    public class GravityCal
    {
        private const double Gravity = -9.81;
        private double _initialVelocity;
        public double FallingTime;
        private double _initialPosition;
        private double _finalPosition;

        public GravityCal()
        {
            _initialVelocity = 0;
            FallingTime = 10;
            _initialPosition = 0;
        }

        public double CalcFinalPosition()
        {
            _finalPosition = 0.5 * Gravity * FallingTime * FallingTime
                             + _initialVelocity * FallingTime + _initialPosition;
            var result = Math.Round(_finalPosition, 1);
            return result;
        }

        public string PrintObjectFall()
        {
            return "The object's position after " + FallingTime + " seconds is " + _finalPosition + "m.";
        }
    }
}