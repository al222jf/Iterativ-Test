using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class GetPoints
    {
        int _quantityOfPoints;
        
        int[] pointsArr; 

        public GetPoints(int numberOfPoints)
        {
            getQuantity = numberOfPoints;

        }



        public int getQuantity
        {
            get { return _quantityOfPoints; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Måste vara minst en dommare!");
                }
                _quantityOfPoints = value;
            }
        }



        public int[] savePoints()
        {
            int points;
            pointsArr = new int[_quantityOfPoints];
            for (int i = 0; i < _quantityOfPoints; i++)
            {
                while (true)
                {
                    Console.Write("Poäng {0}: ", i + 1);
                    points = int.Parse(Console.ReadLine());

                    if (points > 0)
                    {
                        pointsArr[i] = points;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("{0} är inte större än 0", points);
                        Console.ResetColor();
                    }
                }
                
            }
            return pointsArr;
        }
    }

}
