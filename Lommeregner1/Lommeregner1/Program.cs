using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int tal1 = 0;
            //int tal2 = 0;
            //Mathstuff stuff1 = new Mathstuff();



            int stop = 1;
            
            while (stop != 0)
            {
                Console.WriteLine("vælg +, -, *, / eller n2");
                string plusMinus = (Console.ReadLine());

                if (plusMinus == "+")
                {
                    Console.WriteLine("Nu skal der pluses yay!");

                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                    double tal1 = Double.Parse(input1);
                    double tal2 = Double.Parse(input2);

                    double result = tal1 + tal2;

                    bool ok1 = Double.TryParse(input1, out tal1);
                    bool ok2 = Double.TryParse(input2, out tal2);

                    Console.WriteLine("resultatet er " + result);
                    string DoesntStopProgram = Console.ReadLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("");
                }

              if (plusMinus == "/")
                {
                    Console.WriteLine("Nu skal der divideres yay!");

                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                    double tal1 = Double.Parse(input1);
                    double tal2 = Double.Parse(input2);

                    double result = tal1 / tal2;

                    bool ok1 = Double.TryParse(input1, out tal1);
                    bool ok2 = Double.TryParse(input2, out tal2);

                    Console.WriteLine("resultatet er " + result);
                    string DoesntStopProgram = Console.ReadLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("");
                }

                if (plusMinus == "*")
                {
                    Console.WriteLine("Nu skal der ganges yay!");

                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                    double tal1 = Double.Parse(input1);
                    double tal2 = Double.Parse(input2);

                    double result = tal1 * tal2;

                    bool ok1 = Double.TryParse(input1, out tal1);
                    bool ok2 = Double.TryParse(input2, out tal2);

                    Console.WriteLine("resultatet er " + result);
                    string DoesntStopProgram = Console.ReadLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("");
                }

                if (plusMinus == "n2")
                {
                    Console.WriteLine("Nu skal det sættes i anden yay!");

                    string input1 = Console.ReadLine();
                    

                    double tal1 = Double.Parse(input1);


                    double result = tal1 * tal1; 

                    bool ok1 = Double.TryParse(input1, out tal1);
                    

                    Console.WriteLine("resultatet er " + result);
                    string DoesntStopProgram = Console.ReadLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("");
                }

                else if (plusMinus == "-")
                {
                    Console.WriteLine("Nu skal der minuses yay!");

                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                    double tal1 = Double.Parse(input1);
                    double tal2 = Double.Parse(input2);

                    double result = tal1 - tal2;

                    bool ok1 = Double.TryParse(input1, out tal1);
                    bool ok2 = Double.TryParse(input2, out tal2);

                    Console.WriteLine("Dit resultat er " + result);
                    string DoesntStopProgram = Console.ReadLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("");
                }
            }

        }
    }
}
