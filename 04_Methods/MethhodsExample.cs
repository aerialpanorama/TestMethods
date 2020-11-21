using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethhodsExample
    {//input
     //what we do
     //output 

        //access modifier   return type method signature (name and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }
        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }
        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }
        private int FindRemainder (int a, int numtwo)
        {
            int remainder = a % numtwo;
            return remainder;
         }
        [TestMethod]
        public void MethodTests()

        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);
         }
    }
}
