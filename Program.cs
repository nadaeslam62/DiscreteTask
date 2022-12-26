namespace project_1
{
    internal class Program
    {
        static void Main(string [] args)
        {

            Console.WriteLine("Welcome to project prime numbers");
            Console.WriteLine("Enter your start");
            int n1 = int.Parse(Console.ReadLine());
            //allow the user to input the start range
            Console.WriteLine("Enter your end");
            int n2 = int.Parse(Console.ReadLine());
            //allow the user to input the end range

            for (int i = n1; i <= n2; i++) 
                //loop that allow to check all prime numbers in the range which given by user

            {
                if (i < 2)
                {
                    continue;
                }
                //Neglect negative numbers , number one and zero
                bool prime = true;   
                //assume every number is prime
                for (int j = 2; j <= (i / 2); j++)
                    //loop to apply the prime number rule on all given numbers
                {
                    if (i % j == 0 && i > j)
                    {
                        prime = false;
                        break;
                    }
                    //if the reminder = 0 then make it false 
                }
                  //if we have a reminder then the number is prime
                    if (prime)
                    {
                        Console.WriteLine(" prime number is a {0}", i);
                    }
                    //if the number is prime print it
                
                Console.Write("\n");
                }
     
            {

            }

            

        





        }
    }































}