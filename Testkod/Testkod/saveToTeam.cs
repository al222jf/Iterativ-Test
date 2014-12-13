using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class saveToTeam
    {
        List<double> teamSave = new List<double>();
        public saveToTeam()
        {

        }

        public void save(double avragePoints)
        {
            teamSave.Add(avragePoints);

            //Skriver ut listan
            foreach (var saves in teamSave)
            {
                Console.WriteLine(saves);
            }
        }
    }
}
