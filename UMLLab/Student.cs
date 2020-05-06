using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLab
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student()
        {

        }

        public Student(string _name, string _adress, string _program, int _year, double _fee) : base(_name, _adress)
        {
            Program = _program;
            Year = _year;
            Fee = _fee;
        }

        public override string ToString()
        {
            string output = ($"Name: {Name} Adress: {Adress} Program: {Program} Year: {Year} Fee: ${Fee}");
            return output;
        }
    }
}
