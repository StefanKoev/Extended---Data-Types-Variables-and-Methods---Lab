﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            uint secondNumber = uint.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber}");
        }
    }
}
