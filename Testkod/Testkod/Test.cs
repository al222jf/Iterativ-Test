using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class Test
    {
        public Test()
        {

        }

        //Sätter antal domare till noll.
        public static void TestQuantity()
        {
            var quantity = new GetPoints();

            try
            {
                quantity.GetQuantity = 0;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }


        }

        //Skickar poängen som noll.
        public static void TestPoints()
        {
            var points = new GetPoints();

            try
            {
                points.SavePoints(0);
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        //Skickar in en tom array.
        public static void TestArray()
        {
            int[] emptyArray = new int[0];
            var array = new Average();

            array.ProcessAverage(emptyArray);
        }
    }
}
