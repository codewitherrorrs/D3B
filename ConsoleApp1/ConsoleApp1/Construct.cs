using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Construct
    {
        string name;
        //Simple Constructor
        public Construct() 
        {
            Console.WriteLine("These is Simple Constructor");
        }
        //Parameterized Constuctor
        public Construct(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"Name : {name}");
        }
    }
}
