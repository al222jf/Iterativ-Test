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

        

        public double ProcessAverage(GetPoints gp)
        {

            double result;
            double averageArray = 0;
            //Läser ut avrage
            if (gp.PointsArray.Length > 0)
            {
                    result = 0;

                    for (int i = 0; i < gp.PointsArray.Length; i++)
                    {
                        if (gp.PointsArray[i] > 0)
                        {
                            result += gp.PointsArray[i];
                        }
                        else
                        {
                            throw new ArgumentException("Poängen är mindre än ett!");
                        }
                        
                    }
                    averageArray = result / gp.PointsArray.Length;

                    return averageArray;
            }
            else
            {
                throw new ArgumentException("Det finns inga poäng");
            }

            
        }
    }
}
