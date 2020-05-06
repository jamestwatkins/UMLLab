using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff()
        {

        }

        public Staff(string _name, string _adress, string _school, double _pay) : base(_name, _adress)
        {
            School = _school;
            Pay = _pay;
        }

        public override string ToString()
        {
            string output = ($"Name: {Name} Adress: {Adress} School: {School} Pay: ${Pay}");
            return output;
        }
    }
}
