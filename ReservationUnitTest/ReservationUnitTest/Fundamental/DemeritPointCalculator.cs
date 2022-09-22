using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationUnitTest.Fundamental
{
    public class DemeritPointCalculator
    {
        private const int SpeedLimit = 65;
        private const int MaxSpeed = 300;
        public int demeritPoints;

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed)
                throw new ArgumentOutOfRangeException();

            if (speed <= SpeedLimit) return 0;

            const int kmPerDemeritPoint = 5;
             demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
