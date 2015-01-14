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
        public static void TestLessThanOne()
        {
            var quantity = new GetPoints();

            try
            {
                quantity.GetQuantity = 0;
                string fail = "TestLessThanOne lyckades inte";
                TrueOrFalse(fail, false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Sätter antal domare till två.
        public static void TestMoreThanOne()
        {
            var quantity = new GetPoints();

            try
            {
                quantity.GetQuantity = 2;
                string success = "Godkänt! Antal domare är mer än 1";
                TrueOrFalse(success, true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, true);
            }
        }

        //Skickar poängen som noll.
        public static void TestPointsZero()
        {
            var points = new GetPoints();

            try
            {
                points.SavePoints(0);
                string fail = "TestPointsZero lyckades inte";
                TrueOrFalse(fail, false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar poängen som ett.
        public static void TestPointsOne()
        {
            var points = new GetPoints();

            try
            {
                points.SavePoints(1);
                string success = "Godkänt! poängen är mer än 1";
                TrueOrFalse(success, true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, true);
            }
        }

        ////Skickar in en tom array.
        //public static void TestArray()
        //{
        //    int[] emptyArray = new int[0];
        //    var array = new GetPoints();

        //    try
        //    {
        //        array.SaveToArray()
        //    }
        //    catch (ArgumentException err)
        //    {
        //        Console.WriteLine(err.Message);
        //    }
        //}

        public static void TestIntegrationNegative()
        {
            GetPoints a = new GetPoints();
            Average b = new Average();
            a.PointsArray = new int[] {0};

            try
            {
                b.ProcessAverage(a);
                string fail = "TestIntegrationNegative lyckades inte";
                TrueOrFalse(fail, false);

            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
            
        }

        public static void TestIntegrationPositiv()
        {
            GetPoints a = new GetPoints();
            Average b = new Average();
            a.PointsArray = new int[] {1};

            try
            {
                b.ProcessAverage(a);
                string success = "Godkänt! poängen är mer än 1";
                TrueOrFalse(success, true);

            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public static void TrueOrFalse(string message, bool typeOfMessage)
        {
            if (typeOfMessage == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
            Console.ResetColor();
        }

    }
}
