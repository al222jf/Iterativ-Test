using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class RegisterTeam
    {
        private string _teamName;
        private int _teamSize;
        private int[] _teamArray;

        public string TeamName
        {
            get { return _teamName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Lagnamnet får inte vara tomt!");
                }
                _teamName = value;
            }

        }

        public int TeamSize
        {
            get { return _teamSize; }
            set 
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Antal deltagare måste vara minst 1!");
                }
                _teamSize = value;
            }
        }

        public void InsertTeamSize()
        {
            _teamArray = new int[TeamSize];
            Console.WriteLine("Laget har {0} tävlande", _teamArray.Length);
        }

        public void InsertTeamName()
        {
            bool containsNumber = TeamName.Any(c => char.IsDigit(c));
            if(!containsNumber)
            {
                Array.add(_teamArray, TeamName);
                Console.WriteLine(_teamArray[0]);
            }
            throw new ArgumentException("Lagnamnet får inte innehålla nummer!");
            
        }
        public RegisterTeam()
        {

        }
    }
}
