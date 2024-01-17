using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public abstract class Course //деклариране на абстрактен клас (абстрактният клас не се инстанцира)
    {
        //абстрактни операции, свойства и методи

        private string name;
        public Course(string name)
        {
            this.name = name;
        }

        public abstract bool Passed(); //по подразбиране са virtual, няма тяло, имплементацията се прави в наследниците



    }
}
