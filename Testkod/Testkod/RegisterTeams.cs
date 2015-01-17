using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class RegisterTeams
    {
        private string _teamName;
        private int _teamSize;
        private List<string> _teamList;
        private string[] _teamArray;

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
        public string[] TeamArray 
        {
            get { return _teamArray; }
            set { _teamArray = value; }
        }

        public int TeamSize
        {
            get { return _teamSize; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Antal deltagare måste vara minst 1!");
                }
                _teamSize = value;
            }
        }

        public void InsertTeamSize()
        {
            _teamArray = new string[TeamSize];
            Console.WriteLine("Laget har {0} tävlande", _teamArray.Length);
        }

        public void InsertTeamName()
        {
            bool containsNumber = TeamName.Any(c => char.IsDigit(c));
            if (!containsNumber)
            {
                _teamArray[0] = TeamName;
                Console.WriteLine("{0} har lagts till i listan", TeamName);
            }
            else
            {
                throw new ArgumentException("Lagnamnet får inte innehålla nummer!");
            }
        }

        public void InsertCompetitors()
        {

        }
        public RegisterTeams()
        {
            
        }
    }
}
