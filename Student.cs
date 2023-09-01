using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class Student
    {
        public int id;
        public string name;
        public int age;
        private DateOfBirth dateOfBirth = new DateOfBirth();

        public  Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


        public void Init(int id, string name, int age, int day, int month, int year)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.dateOfBirth.Init(day, month, year);
        }

        public void DisplayInfo() 
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nId: {2}\nDateOfBirth: {3}-{4}-{5}", 
                name, age, id, dateOfBirth.Day, dateOfBirth.Month, dateOfBirth.Year); 
        }

        /*
        public int CompareTo(Student other)
        {
            int intValue = id.CompareTo(other.id);
            return intValue;
        }
        */
    }
}
