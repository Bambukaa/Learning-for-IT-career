﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Or_Even
{
    class Odd_Or_Even
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
                Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
