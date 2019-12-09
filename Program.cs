/**
 * ######################################################
 * ##    Chapter 2, Programming Exercise #3            ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: December 9 2019               ##
 * ##    Purpose: Width & numeric format specifiers    ##
 * ######################################################
 */
using System;
using static System.Console;

namespace exam_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int examScore1 = 100,
                examScore2 = 98,
                examScore3 = 92,
                examScore4 = 87,
                examScore5 = 74,
                examTotal = 0;
            const int NUMBER_OF_SCORES = 5;
            double examAverage;
            WriteLine("{0, 8}", "Scores");

            // it's painful not to use an array and foreach()
            WriteLine("{0, 8}", examScore1);
            examTotal += examScore1;
            WriteLine("{0, 8}", examScore2);
            examTotal += examScore2;
            WriteLine("{0, 8}", examScore3);
            examTotal += examScore3;
            WriteLine("{0, 8}", examScore4);
            examTotal += examScore4;
            WriteLine("{0, 8}", examScore5);
            examTotal += examScore5;
            WriteLine("\n{0, 8}", "Average");
            examAverage = (double)examTotal / NUMBER_OF_SCORES;
            WriteLine("{0, 8:N2}", examAverage);
        }
    }
}
