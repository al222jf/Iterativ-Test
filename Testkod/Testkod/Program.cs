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
            string[] array = new string[18];
            array[0] = "";

            Console.WriteLine(array[0].Length);

            Test.TestLessThanOne();
            Test.TestMoreThanOne();
            Test.TestPointsZero();
            Test.TestPointsOne();
            //Test.TestArray();
            Test.TestIntegrationNegative();
            Test.TestIntegrationPositiv();
            Test.TestPasswordEmpty();
            Test.TestPasswordString();
            Test.TestPasswordFalse();
            Test.TestPasswordTrue();
            Test.TestUserEmpty();
            Test.TestUserString();
            Test.TestUserFalse();
            Test.TestUserTrue();
            Test.TestInsertNameEmpty();
            Test.TestInsertNameString();
            Test.TestInsertSizeEmpty();
            Test.TestInsertSizeInt();
            Test.TestInsertTeamSize();
            Test.TestInsertTeamNameNumber();
            Test.TestInsertTeamNameString();

        }
    }
}
