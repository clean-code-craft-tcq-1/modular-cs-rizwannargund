using System;
using System.Diagnostics;
using System.Drawing;

namespace TeleCommunication.ColorCoder
{
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.Violet);
            Debug.Assert(testPair1.MinorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { MajorColor = Color.Yellow, MinorColor = Color.Green };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Blue };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
