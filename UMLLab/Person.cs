using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Person
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public Person()
        {

        }

        public Person(string _name, string _adress)
        {
            Name = _name;
            Adress = _adress;

        }

        public override string ToString()
        {
            string output = ($"Name: {Name} Adress: {Adress}");
            return output;
        }
    }
}
