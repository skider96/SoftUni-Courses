using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {

        public Child(string name, int age) : base(name,age)
        {
        }

        public int Age  
        {
            get => Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException();
                }

                this.Age = value;
            }
        }
    }
}
