using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.id.CompareTo(y.id);
        }
    }
}
