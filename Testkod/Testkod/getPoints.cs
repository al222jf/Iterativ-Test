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


        public GetPoints()
        {

        }

        public GetPoints(int numberOfPoints)
        {
            GetQuantity = numberOfPoints;

        }

        public int GetQuantity
        {
            get { return _quantityOfPoints; }
            set
            {
                if (value < 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Måste vara minst en dommare!");
                    Console.ResetColor();
                }
                _quantityOfPoints = value;
            }
        }



        public int[] SavePoints(int points)
        {

            int [] pointsArr = new int[_quantityOfPoints];
            if (points > 0)
            {
                for (int i = 0; i < _quantityOfPoints; i++)
                {
                    Console.Write("Poäng {0}: ", i + 1);
                    points = int.Parse(Console.ReadLine());

                    Console.WriteLine("Hej");
                    pointsArr[i] = points;
                    break;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0} är inte större än 0", points);
                Console.ResetColor();
            }
            return pointsArr;
        }
    }
}
