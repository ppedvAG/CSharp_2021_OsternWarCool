using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung
{
    /// <summary>
    /// Repräsentiert eine Person  
    /// </summary>
    public class Person : Object
    {
        /// <summary>
        /// Der Name der Person
        /// </summary>
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
        public string Anschrift { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gibt das berechnete Alter der Person zurück
        /// </summary>
        /// <returns>Alter der Person</returns>
        public int CalcAge()
        {
            //Quelle: https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday

            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - GebDatum.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (GebDatum.Date > today.AddYears(-age))
                age--;

            return age;
        }

    }
}
