using System;

namespace Deliverable2
    {
    class Program
        {
        static void Main(string[] args)
            {
            string input;
            string inputCheck = null;
            int count = -1;
            
            while (true)
                {
                if (count == -1)
                    {
                    Console.WriteLine("What would you like to say?");
                    count++;
                    }
                else
                    {
                    Console.WriteLine("Would you like to say something else?");
                    }
                input = Console.ReadLine();
                if (!input.ToLower().Equals(inputCheck))
                    {
                    if (input.ToLower().Equals("hello"))
                        {
                        Console.WriteLine("Hi good to see you");
                        }
                    if (input.ToLower().Equals("bye"))
                        {
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                        }
                    if (input.ToLower().Equals("sup"))
                        {
                        Console.WriteLine("I am good");
                        }
                    if (input.ToLower().Equals("hello there"))
                        {
                        Console.WriteLine("General Kenobi");
                        }
                    }
                else
                    {
                    Console.WriteLine("“I’m sorry but you have already said that");
                    }
                inputCheck = input.ToLower();
                }
                
            }
        }
    }
    
