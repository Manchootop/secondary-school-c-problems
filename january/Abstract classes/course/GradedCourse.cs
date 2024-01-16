using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class GradedCourse : Course
    {
        private int grade;

        public GradedCourse(string name, int grade) : base(name)
        {
            this.grade = grade;
        }

        public override bool Passed()
        {
           if(this.grade <= 2)
           {
                return false;
           }
           return true;

        }
    }
}
