using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program initialization
            Console.Beep();
            Console.WriteLine("Welcome to Calc - Codex!\v");
            string re_run = "";
            string op = "";
            int i = 0;
            bool run;
            float a = 0;
            float b = 0;
            do
            {
                bool calculate = true;
                run = true;


                // Initializing the program
                if (i > 0)
                {
                    Console.Clear();
                    Console.WriteLine("This is a new calculation!");
                }


                // Taking User input
                Console.Write("Input_1: ");
                try
                {
                    a = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tWrong format used!");
                    done();
                    calculate = false;
                    re_run = "1";
                }


                if (calculate)
                {
                    Console.Write("Operator: ");
                    op = Console.ReadLine();
                    if (op != "+" && op != "-" && op != "*" && op != "/")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tWrong operator made!!");
                        done();
                        calculate = false;
                        re_run = "1";
                    }

                    if (calculate)
                    {
                        try
                        {
                            Console.Write("Input_2: ");
                            b = Convert.ToSingle(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tWrong format used!!");
                            done();
                            calculate = false;
                        }
                        Console.WriteLine();
                    }


                    // Computations and output
                    if (calculate)
                    {
                        float ans;
                        if (op == "+")
                        {
                            ans = Add(a, b);
                            Console.WriteLine($"{a} {op} {b} = {ans}\v");
                        }
                        else if (op == "-")
                        {
                            ans = Subtract(a, b);
                            Console.WriteLine($"{a} {op} {b} = {ans}\v");
                        }
                        else if (op == "*")
                        {
                            ans = Multiplication(a, b);
                            Console.WriteLine($"{a} {op} {b} = {ans}\v");
                        }
                        else if (op == "/")
                        {
                            if (b == 0)
                            {
                                Console.WriteLine("Division by zero");
                                Console.WriteLine($"{a} {op} {b} = infinity\v");
                            }
                            else
                            {
                                ans = Division(a, b);
                                Console.WriteLine($"{a} {op} {b} = {ans}\v");

                            }


                        }
                        else
                        {
                            Console.WriteLine("Invalid Operator!!\v");
                        }
                    }

                }
                while (run)
                {
                    Console.WriteLine("Re-run Calculator?(input 1 or 2):");
                    Console.WriteLine("1. YES");
                    Console.Write("2. Quit? ");
                    re_run = Console.ReadLine();
                    if (re_run != "1" && re_run != "2")
                    {
                        Console.WriteLine("\vInvalid choice made!\v");
                        continue;
                    }
                    else
                    {
                        run = false;
                    }
                }
                Console.WriteLine();
                i++;

            } while (re_run == "1");
        }


        // Declaration of the Operation functions
        private static float Add(float a, float b) => a + b;
        private static float Subtract(float a, float b) => a - b;
        private static float Division(float a, float b) => a / b;
        private static float Multiplication(float a, float b) => a * b;
        public static void done()
        {
            try
            {
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            catch (FormatException e)
            {
                Console.Clear();
                done();
            }
        }
    }
}