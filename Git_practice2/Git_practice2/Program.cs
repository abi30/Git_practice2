using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_practice2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("practice with while loop");

            int number = 1;

            while(number<30)
            {
                number++;
                if (number%2==0)
                {
                    continue;
                  
                    //break;
                }
                Console.WriteLine($"hello bangladesh {number}");
                
            }



            Console.ReadKey();
        }
    }
}
