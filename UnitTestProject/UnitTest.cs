using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Correct_Round_Area()
        {
            double expected=153.86;         
            Round round = new Round(7);
            double area = round.GetArea();   
            Assert.AreEqual(expected, area, 0.01, "Incorrect");
          
        }
        [TestMethod]
        public void Correct_TriangleArea()
        {
            double expected = 13.41;
            Triangle triangle = new Triangle(7, 4, 7);
            double area = triangle.GetArea();
            Assert.AreEqual(expected, area, 0.01, "Incorrect");
        }
        [TestMethod]
        public void Is_Triangle_Squared()
        {
            bool expected = true;
            Triangle triangle = new Triangle(5, 4, 3);
            bool result = triangle.IsSquared();
            Assert.AreEqual(expected, result, "Incorrect");
        }
    }
}
