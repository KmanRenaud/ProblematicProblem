using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        static public void Main(string[] args)
        {
            string display = "WELCOME TO THIS WONDERFUL RANDOM ACTIVITY GENERATOR!!!";
            foreach (var i in display)
            {
                Thread.Sleep(75);
                Console.Write(i);   
            }

            Thread.Sleep(2000);
            Console.Clear();


            DoStuff something = new DoStuff();
            something.ActGen();
        }
    }
}
    
