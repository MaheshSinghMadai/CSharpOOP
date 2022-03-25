using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{ 
    
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 9,8,6,5};
            for(int i= 0;i<num.Length; i++)
            {
                Console.WriteLine(num[i] * num[i]);
            }

        }
    }
}
