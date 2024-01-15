using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Project
    {
        private Course c1, c2, c3, c4;

        public Project(Course c1, Course c2, Course c3, Course c4)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;
        }
        
        public bool Passed()
        {
            return (c1.Passed() && c2.Passed() && c3.Passed() && c4.Passed()) || (!c1.Passed() && c2.Passed() && c3.Passed() && c4.Passed()) || (c1.Passed() && !c2.Passed() && c3.Passed() && c4.Passed()) || (c1.Passed() && c2.Passed() && !c3.Passed() && c4.Passed()) || (c1.Passed() && c2.Passed() && c3.Passed() && !c4.Passed());
        }
    }
}
