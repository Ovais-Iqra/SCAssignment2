using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    class Driver_Class : Calculator_Functions
    {
        static public Calculator_Functions calc1;
        static void Main(string[] args)
        {
            try
            {
                calc1 = new Calculator_Functions();
                double val1, val2, result;
                int choice=0;
                Console.Write("\nPress CTRL+C at anytime to Exit the Console\n");
                Console.Write("\nEnter First Number: ");
                val1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter Second Number: ");
                val2 = Convert.ToDouble(Console.ReadLine());
                while (true)
                {                    
                    Console.Write("\nEnter Choice\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\nChoose: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        result = calc1.addFunction(val1, val2);
                        break;
                    }
                    else if (choice == 2)
                    {
                        result = calc1.subFunction(val1, val2);
                        break;
                    }
                    else if (choice == 3)
                    {
                        result = calc1.mulFunction(val1, val2);
                        break;
                    }
                    else if (choice == 4)
                    {
                        result = calc1.divFunction(val1, val2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice! Please select from the given operations!");
                    }
                }
                Console.Write("\n\nResult is: " + result);
                Console.ReadKey();
                Console.Write("\n\nThanks for using the Program!");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError! " + ex.Message);
                Console.ReadKey();
                Main(null);
            }


        }
    }
}
