using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Person
    {
        public string Name { get; set; }

        public Person(String name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }

        //destructor for deallocating the space
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
