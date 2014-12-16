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
 
            GetPoints a = new GetPoints(quantityOfPoints);
            arr = a.savePoints();

            Avrage b = new Avrage();
            avragePoints = b.processAvrage(arr);

            SaveToTeam c = new SaveToTeam();
            c.save(avragePoints);

        }
    }
}
