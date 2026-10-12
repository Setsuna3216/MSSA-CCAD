using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7._4
{
    internal class ParkingSystem
    {
        int bigSpace;
        int midSpace;
        int smlSpace;

        public ParkingSystem(int big, int medium, int small)
        {
            bigSpace = big;
            midSpace = medium;
            smlSpace = small;

        }

        public bool addCar(int carType)
        {
            if (carType == 1 )
            {
                if (bigSpace > 0)
                {
                    bigSpace--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (carType == 2 )
            {
                if (midSpace > 0)
                {
                    midSpace--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (carType == 3 )
            {
                if (smlSpace > 0)
                {
                    smlSpace--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
