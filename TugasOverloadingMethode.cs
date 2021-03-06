using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LatihanOverloadingMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Numbers number = new Numbers();
            
			Console.WriteLine("Minimum #1: {0}", number.FindMinimum(3,1));
			Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3,2,4));
			Console.WriteLine(); //tambahkan baris kosong
			Console.WriteLine("Maximum #1: {0}", number.FindMaximum(3,1));
			Console.WriteLine("Maximum #2: {0}", number.FindMaximum(3,2,4));
		}
	}
	
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
			if (number1 < number2) return number1; else return number2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
			if (number1 < number2) return number1; else return number2;
        }

        public int FindMaximum(int number1, int number2)
        {
			if (number1 > number2) return number1; else return number2;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
			return 3 + 1;
        }
    }
}