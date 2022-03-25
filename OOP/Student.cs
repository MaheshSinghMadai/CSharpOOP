using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student : Person
    {
        public void study()
        {
            Console.WriteLine("I'm studying");
        }
        
        public void ShowAge()
        {
            int age = 22;
            Console.WriteLine("My age is " + age);
        }
    }
}
