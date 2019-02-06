using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkshayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSelection = string.Empty;
            string analyzedTriangle = string.Empty;
            do
            {
                Console.Write("1. Enter triangle dimensions\n");
                Console.Write("2. Exit\n");
                menuSelection = Console.ReadLine();
                if (!menuSelection.Equals("1") && !menuSelection.Equals("2"))
                {
                    Console.Write("Incorrect Input, please enter correct menu option\n");
                }
                else if (menuSelection.Equals("1"))
                {
                    int firstSide = 0, secondSide = 0, thirdSide = 0;
                    bool isValid = false;
                    //take three integer input from user
                    do
                    {
                        isValid = false;
                        Console.Write("Enter the First side: ");
                        isValid = int.TryParse(Console.ReadLine(), out firstSide);
                        if (!isValid || firstSide <= 0)
                        {
                            Console.Write("Invalid value for First Side\n");
                        }
                    } while (!isValid || firstSide <= 0);
                    do
                    {
                        isValid = false;
                        Console.Write("Enter the Second side: ");
                        isValid = int.TryParse(Console.ReadLine(), out secondSide);
                        if (!isValid || secondSide <= 0)
                        {
                            Console.Write("Invalid value for Second Side\n");
                        }
                    } while (!isValid || secondSide <= 0);
                    do
                    {
                        isValid = false;
                        Console.Write("Enter the Third side: ");
                        isValid = int.TryParse(Console.ReadLine(), out thirdSide);
                        if (!isValid || thirdSide <= 0)
                        {
                            Console.Write("Invalid value for Third Side\n");
                        }
                    } while (!isValid || thirdSide <= 0);
                    analyzedTriangle = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);
                    Console.WriteLine(analyzedTriangle);
                }
            } while (menuSelection != "2");
        }
    }
}
