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

        }
    }
}
