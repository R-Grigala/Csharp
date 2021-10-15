using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer = 'Y';
            Console.WriteLine("If you want to quit you should enter ( N ) when this question apears -- Do you want to continue again (Y/N)?");
            while (answer != 'N')
            {
                char operation = '?';
                float number_1, number_2;
                Console.WriteLine("+ -Addition\n- -Subtraction\n* -Multiplication\n/ -Division\n% -Modulus");
                try
                {
                    //operation = Console.ReadLine()[0];
                    operation = Console.ReadKey().KeyChar;
                    Console.Write("\nEnter Number 1 : ");
                    number_1 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter Number 2 : ");
                    number_2 = Convert.ToSingle(Console.ReadLine());
                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine($"{number_1}{operation}{number_2} = {number_1 + number_2}");
                            break;
                        case '-':
                            Console.WriteLine($"{number_1}{operation}{number_2} = {number_1 - number_2}");
                            break;
                        case '*':
                            Console.WriteLine($"{number_1}{operation}{number_2} = {number_1 * number_2}");
                            break;
                        case '/':
                            if (number_2 == 0)
                                Console.WriteLine("Can't deway by 0");
                            else
                                Console.WriteLine($"{number_1} : {number_2} = {number_1 / number_2};\n{number_1} div {number_2} = {(int)number_1 / (int)number_2}");
                            break;
                        case '%':
                            if (number_2 == 0)
                                Console.WriteLine("Can't deway by 0");
                            else
                                Console.WriteLine($"{number_1}{operation}{number_2} = {number_1 % number_2}");
                            break;
                        default:
                            Console.WriteLine("operations can only be :   +   -   *   /   %");
                            break;

                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.Write("\nDo you want to continue again (Y/N)? ");
                    answer = Console.ReadLine().ToUpper()[0];
                }
            }
        }
    }
}
