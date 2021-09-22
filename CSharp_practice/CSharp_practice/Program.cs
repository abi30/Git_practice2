using CSharp_practice.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person();

            p1.firstName = "Abdulla";
            p1.lastName = "Rakib";

            p1.Introduce();

            int ans = Calculator.Add(3,4);
            Console.WriteLine($"you have got in math {ans}");


            Console.ReadKey();
        }
    }


    public class Person
    {
        public string firstName;
        public string lastName;

         public void Introduce()
        {
            Console.WriteLine($"My name is {firstName} {lastName}! ");
        }




    }
}
