using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class avrage
    {

        public avrage()
        {
            
        }

        public double processAvrage(int[] pointsArray)
        {
            //Läser ut avrage

            double result = 0;

            for (int i = 0; i < pointsArray.Length; i++)
            {
                result += pointsArray[i];
            }
            double avrageArray = result / pointsArray.Length;

            return avrageArray;
        }
    }
}
