using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        private static object statr;

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to project perfect number");
            Console.WriteLine("Enter your start");
            int start = int.Parse(Console.ReadLine());
            //allow the user to input the start range
            Console.WriteLine("Enter your end");
            int end = int.Parse(Console.ReadLine());
            //allow the user to input the end range
            for (int i = start; i <= end; i++)
                //loop that allow to check all numbers in the range which given by user
            {
                if (i == 0)
                {
                    continue;
                }
                //Neglect number zero
                int sum = 0;
                for (int j = 1; j <= (i / 2); j++)
                    //loop that apply the perfect number rule on all given numbers
                {
                    
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                    //if reminder = 0 then add the factor (j) to the sum

                    if (sum > i)

                    {
                        break;
                    }
                    //if the sum of the factories is grater the number neglect it and back to loop
                }
                    if (sum == i)
                    {
                        Console.WriteLine(i + " is perfect number");
                    }
                    //if sum of the factories is equal to the number then print it
                    
                 
                  
                
            }







        }

    }
}
    

