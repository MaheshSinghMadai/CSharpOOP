using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class Animal
    {
        public string dogName;

        public void setName(string name)
        {
            dogName = name;
        }

        public string getName()
        {
            return dogName;
        }

        public abstract void Eat();
     
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
           Console.WriteLine(dogName + " is eating");
        }
    }
}
