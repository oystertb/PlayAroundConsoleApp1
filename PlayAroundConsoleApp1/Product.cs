using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAroundConsoleApp1
{
    public class Product
    {
        private String name;
        private int age;

        public Product(String s, int i)
        {
            name = s;
            age = i;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}",name, age);
        }


    }

    
}
