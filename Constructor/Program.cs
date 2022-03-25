/**Create a C# program that prompts the user for three names of people 
 * and stores them in an array of Person-type objects. 
 * To do this, first create a Person class that has a Name property of type string,
 * a constructor that receives the name as a parameter,
 * a destructor that assigns the name to empty and overwrites the ToString () method.
End the program by reading the people and executing the ToString () method on screen.**/

using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //determine total number of persons
            int peopleNumber = 3;

            Person[] p = new Person[peopleNumber];

            //Take people name 
            for(int i = 0; i < peopleNumber; i++)
            {
                p[i] = new Person(Console.ReadLine());
            }

            //display name
            for(int i=0; i < peopleNumber; i++)
            {
                Console.WriteLine(p[i].ToString());
            }

        }
    }
}
