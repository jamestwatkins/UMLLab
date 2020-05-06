using System;
using System.Collections.Generic;

namespace UMLLab
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() { };

            people.Add(new Student("George Thompson", "1422 Morple St.", "Accounting", 2, 12000));
            people.Add(new Student("Rebecca Henderson", "88 Laneley Ln.", "Biology", 4, 34000));
            people.Add(new Student("Jacob Crumbley", "4224 Fredderson Ave.", "Theatre", 1, 22000));
            people.Add(new Staff("Hank Hungrley", "222 Tooley Dr.", "Moorestown University", 55000));
            people.Add(new Staff("Regina Germo", "366 Hut St.", "Hurman College", 45660));

            foreach(Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
