using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class BooleanCourse : Course
    {
        private bool grade;
        public BooleanCourse(string name, bool grade) : base(name)
        {
            this.grade = grade;
        }

        //тук вече методът има тяло
        public override bool Passed()
        {
            return this.grade;
        }
    }
}
