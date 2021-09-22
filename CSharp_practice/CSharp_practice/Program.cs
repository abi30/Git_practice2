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
        {  // Class 
            Person p1 = new Person();

            p1.firstName = "Abdulla";
            p1.lastName = "Rakib";
            p1.Introduce();
            //ststic method 
            int ans = Calculator.Add(3, 4);
            Console.WriteLine($"you have got in math {ans}");

            // array in C#
            string[] cars = { "BMW", "Volkwagen", "Ford", "Land rober", "mercedes" };
            cars[3] = "toyota";
            Console.WriteLine(cars[3]);
            // String in Csharp

            string fName = "abdullah ";
            string lName = "mahabub";

            string fullName = string.Concat(fName,lName);
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.IndexOf('u'));
            Console.WriteLine(fullName[3]);

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
