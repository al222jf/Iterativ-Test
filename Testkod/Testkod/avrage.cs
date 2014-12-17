using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class Average
    {

        public Average()
        {
            
        }

        public double ProcessAverage(int[] pointsArray)
        {
            double result;
            double averageArray = 0;
            //Läser ut avrage
            if (pointsArray.Length > 0)
            {
                result = 0;

                for (int i = 0; i < pointsArray.Length; i++)
                {
                    result += pointsArray[i];
                }
                averageArray = result / pointsArray.Length;

                return averageArray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Det finns inga poäng");
                Console.ResetColor();
                return averageArray;
            }

            
        }
    }
}
