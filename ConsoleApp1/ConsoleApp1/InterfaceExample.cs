using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface InterfaceExample
    {
        void add(int a, int b);
    }
    public interface Interface
    {
        void Add(int b, int a);
    }
    public class Child : InterfaceExample, Interface
    {
        public void add(int a, int b) 
        {
            Console.WriteLine($"The Addition is {a+b}");
        }

        public void Add(int b,int a)
        {
            Console.WriteLine($"The sum is {a+b}");
        }

    }
}
