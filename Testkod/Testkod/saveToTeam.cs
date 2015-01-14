using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class SaveToTeam
    {
        List<double> teamSave = new List<double>();
        public SaveToTeam()
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
