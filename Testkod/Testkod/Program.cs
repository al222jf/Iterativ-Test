using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Testkod
{
    class Program
    {
        static void Main(string[] args)
        {

            string hej = Console.ReadLine();

            Regex regex = new Regex("^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$");

            Match match = regex.Match(hej);

            if (match.Success)
            {
                Console.WriteLine("Matchar");
            }
            else
            {
                Console.WriteLine("Matchar inte");
            }

            
            
            
            
            
            
            ////Poängsättning för ett lag och en gren

            //int quantityOfPoints;
            //int[] arr;
            //double averagePoints;
            //int zero = 0;
            
            //Console.Write("Antal domare/jury: ");
            //quantityOfPoints = int.Parse(Console.ReadLine());
 
            //GetPoints a = new GetPoints(quantityOfPoints);
            //GetPoints a = new GetPoints();
            //arr = a.SavePoints();

            //Average b = new Average();
            
            //averagePoints = b.ProcessAverage(arr);

            

            //Test.TestLessThanOne();
            //Test.TestMoreThanOne();
            //Test.TestPointsZero();
            //Test.TestPointsOne();
            //Test.TestArray();
            //Test.TestIntegrationNegative();
            //Test.TestIntegrationPositiv();            

        }
    }
}
