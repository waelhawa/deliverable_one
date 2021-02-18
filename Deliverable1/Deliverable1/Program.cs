using System;

namespace Deliverable1
    {
    class Program
        {
        static void Main(string[] args)
            {
            string input;
            decimal value;
            int conversion;
            int unit;
            int result;
            int repeat;
            int flag = 0;
            while (flag == 0)
                {
                value = -1;
                conversion = -1;
                unit = -1;
                result = -1;
                repeat = 0;
                
                while (conversion == -1)
                    {
                    Console.WriteLine("1- Imperial to MilHip\n2- Milhip to Imperial");
                    Console.Write("Please input convertion type: ");
                    input = Console.ReadLine();
                    conversion = Select(input);
                    if (!(conversion == 1 || conversion == 2))
                        {
                        Console.WriteLine("Please choose 1 or 2");
                        conversion = -1;
                        }
                    }

                while (unit == -1)
                    {
                    if (conversion == 1)
                        {
                        Console.WriteLine("Convert from: \n1- Inch\n2- Foot");
                        }
                    else
                        {
                        Console.WriteLine("Convert from: \n1- Fidget Spinner\n2- Memes");
                        }
                    Console.Write("Please choose unit: ");
                    input = Console.ReadLine();
                    unit = Select(input);
                    if (!(unit == 1 || unit == 2))
                        {
                        Console.WriteLine("Please choose 1 or 2");
                        unit = -1;
                        }
                    }

                while (result == -1)
                    {
                    if (conversion == 1)
                        {
                        Console.WriteLine("Convert to: \n1- Fidget Spinner\n2- Memes");
                        }
                    else
                        {
                        Console.WriteLine("Convert to: \n1- Inch\n2- Foot");
                        }
                    Console.Write("Please choose unit: ");
                    input = Console.ReadLine();
                    result = Select(input);
                    if (!(result == 1 || result == 2))
                        {
                        Console.WriteLine("Please choose 1 or 2");
                        result = -1;
                        }
                    }

                while (value == -1)
                    {
                    Console.Write("Please input a measurement: ");
                    input = Console.ReadLine();
                    value = Check(input);
                    }

                Convert(value, conversion, unit, result);

                while (repeat == 0)
                    {
                    Console.WriteLine("Would you like to do another convertion? (YES or NO)");
                    input = Console.ReadLine();
                    if (input.ToLower().Equals("no") || input.ToLower().Equals("n"))
                        {
                        flag = -1;
                        repeat = -1;
                        Console.WriteLine("Thank you, Good Bye.");
                        }
                    else if (input.ToLower().Equals("yes") || input.ToLower().Equals("y"))
                        {
                        flag = 0;
                        repeat = -1;
                        }
                    else
                        {
                        Console.WriteLine("Please type YES or NO for your answer.");
                        flag = 0;
                        repeat = 0;
                        }

                    }


                }
            }

        static decimal Check(string input)
            {
            decimal value;
            if (decimal.TryParse(input, out _))
                {
                value = decimal.Parse(input);
                }
            else
                {
                Console.WriteLine("Input has wrong format. Please use numeric values only.");
                value = -1;
                }
            return value;
            }

        static int Select(string input)
            {
            int selection;
            if (int.TryParse(input, out _))
                {
                selection = int.Parse(input);
                }
            else
                {
                Console.WriteLine("Input has wrong format. Please use numeric values only.");
                selection = -1;
                }

            return selection;
            }

        static void Convert (decimal val, int convertion, int unit, int result)
            {
            string from = null;
            string to = null;
            decimal value = val;
            if (convertion == 1)
                {
                if (unit == 1)
                    {
                    from = "Inches";
                    if (result == 1)
                        {
                        value *= ((decimal)(3.5));
                        to = "Fidget Spinners";
                        }
                    if (result == 2)
                        {
                        value *= ((decimal)(5.0 / 12.0));
                        to = "Memes";
                        }
                    }
                if (unit == 2)
                    {
                    from = "Feet";
                    if (result == 1)
                        {
                        value *= ((decimal)(12.0 * 3.5));
                        to = "Fidget Spinners";
                        }
                    if (result == 2)
                        {
                        value *= ((decimal)(5.0));
                        to = "Memes";
                        }
                    }
                }
            if (convertion == 2)
                {
                if (unit == 1)
                    {
                    from = "Fidget Spinners";
                    if (result == 1)
                        {
                        value *= ((decimal)(1.0 / 3.5));
                        }
                    if (result == 2)
                        {
                        value *= ((decimal)(12.0 / 3.5));
                        }
                    }
                if (unit == 2)
                    {
                    from = "Memes";
                    if (result == 1)
                        {
                        value *= ((decimal)(12.0 / 5.0));
                        to = "Inches";
                        }
                    if (result == 2)
                        {
                        value *= ((decimal)(1.0 / 5.0));
                        to = "Feet";
                        }
                    }
                }
            value = Math.Round(value, 3);
            Console.WriteLine(val + " " + from + " is equals to " + value + " " + to);

            }
      
        }
    }
