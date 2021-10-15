using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class InputObj
    {
        private readonly ConverterObj _converterObj;

        public InputObj(ConverterObj converterObj)
        {
            _converterObj = converterObj;
        }

        private static void defaultOutput(string output)
        {
            ConsoleColor backup = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(output);
            Console.ForegroundColor = backup;
        }

        private static void errorOutput(string output)
        {
            ConsoleColor backup = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(output);
            Console.ForegroundColor = backup;
        }

        public void ServerForever()
        {
            while (true)
            {
                try
                {
                    double value, result;
                    char choise;
                    string sourceFormat, targetFormat, valid = "cf";

                    defaultOutput("Press C to convert  from Farenheit to Celsius\n"
                        + "Press F to convert from Celsius to Farenheit\n"
                        + "Your choise: "
                        );
                    choise = char.ToLower(Console.ReadKey().KeyChar);
                    defaultOutput("\n");

                    if (!valid.Contains(choise)) throw new Exception($"Unknown temperature format '{choise}");

                    sourceFormat = (choise == 'f' ? "Celsius" : "Farenheit");
                    targetFormat = (choise == 'c' ? "Celsius" : "Farenheit");

                    defaultOutput($"Please enter the temperature in {sourceFormat}: ");
                    value = double.Parse(Console.ReadLine().Trim());

                    if (choise == 'c') { _converterObj.FarenheitValue = value; result = _converterObj.CelsiusValue; }
                    else { _converterObj.CelsiusValue = value; result = _converterObj.FarenheitValue; }

                    defaultOutput($"The temperature in {targetFormat} is {result}\n");

                }
                catch (FormatException e) { errorOutput($"Invalid number format.\n"); }
                catch (OverflowException e) { errorOutput($"Input number too large.\n"); }
                catch (Exception e) { errorOutput($"Error: {e.Message}.\n"); }

                defaultOutput("Would you like to try again? (Y/N): ");
                if (char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    defaultOutput("\nProgram terminated.\n");
                    break;
                }

                Console.Clear();
            }
        }
    }
}

