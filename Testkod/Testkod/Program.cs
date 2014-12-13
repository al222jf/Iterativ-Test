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
            //Poängsättning för ett lag och en gren

            int quantityOfPoints;
            int[] arr;
            double avragePoints;
            
            Console.Write("Antal domare/jury: ");
            quantityOfPoints = int.Parse(Console.ReadLine());

            Console.WriteLine(quantityOfPoints);

            
            getPoints a = new getPoints(quantityOfPoints);
            arr = a.savePoints();

            avrage b = new avrage();
            avragePoints = b.processAvrage(arr);

            saveToTeam c = new saveToTeam();
            c.save(avragePoints);







         
                

        }
    }
}
