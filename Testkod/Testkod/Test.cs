﻿using System;
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
                TrueOrFalse("TestLessThanOne misslyckades", false);
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
                TrueOrFalse("Godkänt! Antal domare är mer än 1", true);
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
                TrueOrFalse("TestPointsZero misslyckades", false);
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
                TrueOrFalse("Godkänt! poängen är mer än 1", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, true);
            }
        }

        //Skickar tomt användarnamn
        public static void TestUserEmpty()
        {
            var user = new Login();

            try
            {
                user.User = "";
                TrueOrFalse("TestUserEmpty misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar sträng till get, set metoden
        public static void TestUserString()
        {
            var user = new Login();

            try
            {
                user.User = "stefan";
                TrueOrFalse("TestUserString lyckades", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar fel användarnamn
        public static void TestUserFalse()
        {
            var user = new Login();
            user.User = "fel";

            try
            {
                user.UserValidate();
                TrueOrFalse("TestUserFalse misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar rätt användarnamn
        public static void TestUserTrue()
        {
            var user = new Login();
            user.User = "stefan";

            try
            {
                user.UserValidate();
                TrueOrFalse("Rätt användarnamn!", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar ett tomt lösenord
        public static void TestPasswordEmpty()
        {
            var password = new Login();

            try
            {
               password.Password = "";
               TrueOrFalse("TestPasswordEmpty misslyckades!", false);
            }
            catch(ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }            
        }
        
        //Skickar med sträng till get,set metoden
        public static void TestPasswordString()
        {
            var password = new Login();

            try
            {
                password.Password = "rules";
                TrueOrFalse("TestPasswordString lyckades", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar fel lösenord
        public static void TestPasswordFalse()
        {
            var password = new Login();
            password.Password = "fel";
           
            try
            {
                password.PasswordValidate();
                TrueOrFalse("TestpasswordFalse misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar rätt lösenord
        public static void TestPasswordTrue()
        {
            var password = new Login();
            password.Password = "rules";

            try
            {
                password.PasswordValidate();
                TrueOrFalse("Rätt Lösenord", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar in en tom string till get, set metoden TeamName
        public static void TestInsertNameEmpty()
        {
            var register = new RegisterTeams();

            try
            {
                register.TeamName = "";
                TrueOrFalse("TestInsertNameEmpty misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar in en sträng till get, set metoden TeamName
        public static void TestInsertNameString()
        {
            var register = new RegisterTeams();
            
            try
            {
                register.TeamName = "blågul";
                TrueOrFalse("TestInsertNameString Lyckades", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar in en 0 till get, set metoden TeamSize
        public static void TestInsertSizeEmpty()
        {
            var register = new RegisterTeams();

            try
            {
                register.TeamSize = 0;
                TrueOrFalse("TestInsertSizeEmpty misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Skickar in en 5 till get, set metoden TeamSize
        public static void TestInsertSizeInt()
        {
            var register = new RegisterTeams();

            try
            {
                register.TeamSize = 5;
                TrueOrFalse("TestInsertSizrInt lyckades", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Sätter storleken på laget till godkänt värde.
        public static void TestInsertTeamSize()
        {
            var register = new RegisterTeams();
            register.TeamSize = 5;
            try
            {
                register.InsertTeamSize();
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        //Sätter TeamName till string med siffror
        public static void TestInsertTeamNameNumber()
        {
            var register = new RegisterTeams();
            register.TeamName = "gul3lå";
            try
            {
                register.InsertTeamName();
                TrueOrFalse("TestInsertTeamNameNumber misslyckades!", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
            
        }

        //Sätter TeamName till godkänd string
        public static void TestInsertTeamNameString()
        {
            var register = new RegisterTeams();
            register.TeamName = "gulblå";
            register.TeamSize = 5;
            register.TeamArray = new string[register.TeamSize];
            try
            {
                register.InsertTeamName();
                TrueOrFalse("TestInsertNameString lyckades!", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        public static void TestInsertCompetitorsEmpty()
        {
            var register = new RegisterTeams();
            register.TeamArray = new string[4];

            for (var i = 0; i < register.TeamArray.Length; i++)
            {
                if (i == 2)
                {
                    register.TeamArray[i] = "";
                }
                else
                {
                    register.TeamArray[i] = "blågul";
                }
               
            }

            try
            {
                register.InsertCompetitors();
                TrueOrFalse("TestInsertCompetitorsEmpty misslyckades", false);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
            }
        }

        public static void TestInsertCompetitorsFull()
        {
            var register = new RegisterTeams();
            register.TeamArray = new string[4];

            for (var i = 0; i < register.TeamArray.Length; i++)
            {
                register.TeamArray[i] = "blågul";
            }

            try
            {
                register.InsertCompetitors();
                TrueOrFalse("TestInsertCompetitorsFull lyckades", true);
            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
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
                TrueOrFalse("TestIntegrationNegative misslyckades", false);

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
                TrueOrFalse("Godkänt! poängen är mer än 1", true);

            }
            catch (ArgumentException err)
            {
                TrueOrFalse(err.Message, false);
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
