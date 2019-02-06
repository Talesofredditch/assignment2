using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkshayAssignment
{
    public static class TriangleSolver


    {
        public static string Analyze(int side1, int side2, int side3)
        {
            String analyzeTriangle = "Unable to create a triangle with given sides\n";
            if (!(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1))
            {
                if ((side1 == side2) && (side1 == side3))
                {
                    analyzeTriangle = "It is Equilateral Traingle\n";
                }
                else if ((side1 == side2) || (side1 == side3) || (side2 == side3))
                {
                    analyzeTriangle = "It is Isosceles Traingle\n";
                }
                else
                {
                    analyzeTriangle = "It is Scalene Traingle\n";
                }
            }
            return analyzeTriangle;
        }
    }
}
