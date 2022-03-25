using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new person to make him say hello
            Person p = new Person();
            p.Greet();

            //Create a new Student, set an age, say hello, and display her age on the screen
            Student s = new Student();
            s.Greet();
            s.ShowAge();
            s.study();

            //Create a new Teacher, set an age, say hello and start the explanation.
            Teacher t = new Teacher();
            t.Greet();
            t.SetAge(23);
            t.Explain();

        }
    }
}
