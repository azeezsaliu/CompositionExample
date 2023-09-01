using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] value = { 9, 4, 7, 2, 8, 1, 2, 3 };
            string[] values = { "Yola", "Ilyas", "Ibrahi", "Azeez" };

            
            List<Student> students = new List<Student>();
            students.Add(new Student(7, "Yoal", 34));
            students.Add(new Student(2, "Ilyas", 22));
            students.Add(new Student(3, "Ibrahim", 43));
            students.Add(new Student(1, "Azeez", 12));
            

            /*
            Student[] students = new Student[4];
            students[0] = new Student(1, "Yoal", 34);
            students[1] = new Student(2, "Ilyas", 22);
            students[2] = new Student(3, "Ibrahim", 43);
            students[3] = new Student(7, "Azeez", 12);
            */

            Console.WriteLine("Before Sorting...");
            foreach (Student i in students)
            {
                Console.WriteLine(i.name);
            }

            //Array.Sort(students);
            students.Sort(new StudentComparer());

            Console.WriteLine("After Sorting...");

            foreach (Student i in students)
            {
                Console.WriteLine(i.name);
            }



            /*
            Student student = new Student();
            student.Init(1, "John", 23, 12, 4, 2008);
            student.DisplayInfo();
            */

        }
    }
}
