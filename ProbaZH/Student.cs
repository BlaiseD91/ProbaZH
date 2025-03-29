using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaZH
{
    internal class Student: Person, IIdentifiable
    {
        private string neptun;
        private int credits;
        private static int numberOfStudents = 0;

        public string Neptun {
            get { return neptun; }
            set { neptun = value; } 
        }

        public int Credits {
            get { return credits; }
            set { credits = value; }
        }
        public int NumberOfStudents { get { return numberOfStudents; } }

        //public Student(string name, int age, string neptun, int credits)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.neptun = neptun;
        //    this.credits = credits;
        //    numberOfStudents++;
        //}
        public Student():base()
        {
            
        }
        public Student(string name, int age, string neptun, int credits):base(name, age)
        {
            this.neptun = neptun;
            this.credits = credits;
            numberOfStudents++;
        }

        public override string ToString()
        {
            return $"Hallgato neve: {Name}\nHallgató creditjei: {Credits}";
        }
        public override string GetInfo()
        {
            return $"{Name} ({Neptun}), életkor: {Age}, kreditek: {Credits}";
        }

        public string GetNeptunCode()
        {
            return neptun;
        }
    }
}
