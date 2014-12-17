using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //SaveToTeam c = new SaveToTeam();
            //c.save(averagePoints);

            Test.TestQuantity();
            Test.TestPoints();
            Test.TestArray();
            

        }
    }
}
