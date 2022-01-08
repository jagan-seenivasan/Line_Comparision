using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculateXandYLength uc1 = new CalculateXandYLength();
            CalculateXandYLength.LengthOfXandY();
            CheckEqualofLines UC2 = new CheckEqualofLines();
            CheckEqualofLines.CheckLinesOrEqual();
            GreaterOrLessThanInLine UC3 = new GreaterOrLessThanInLine();
            GreaterOrLessThanInLine.CheckLineisGreaterOrLess();

        }
    }
}