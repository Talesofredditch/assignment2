
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AkshayAssignment;

namespace TestAnalyseMethod
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Unit_Test_Analyze_Scalene_Input_32_45_40()
        {
            String output = TriangleSolver.Analyze(32, 45, 40);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Scalene_Input_534_487_465()
        {
            String output = TriangleSolver.Analyze(534, 487, 465);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Isosceles_Input_45_45_54()
        {
            String output = TriangleSolver.Analyze(45, 45, 54);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Isosceles_Input_465_532_465()
        {
            String output = TriangleSolver.Analyze(465, 532, 465);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Equilateral_Input_60_60_60()
        {
            String output = TriangleSolver.Analyze(60, 60, 60);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Equilateral_Input_250_250_250()
        {
            String output = TriangleSolver.Analyze(250, 250, 250);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Triangle_Not_Formed_Input_35_5_65()
        {
            String output = TriangleSolver.Analyze(35, 5, 65);
            Console.Write(output);
        }
        [Test]
        public void Unit_Test_Analyze_Triangle_Not_Formed_Input_0_0_0()
        {
            String output = TriangleSolver.Analyze(0, 0, 0);
            Console.Write(output);
        }
    }
}