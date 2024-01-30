using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new BooleanCourse("Math", true);
            Course c2 = new BooleanCourse("Geography", true);
            Course c3 = new GradedCourse("Programming", 0);
            Course c4 = new GradedCourse("Algorithms", -3);

            Project p = new Project(c1, c2, c3, c4);

            Console.WriteLine(p.Passed());
        }
    }
}
