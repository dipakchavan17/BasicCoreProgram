﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core programs");
            BasicPrograms basicPrograms = new BasicPrograms();
            basicPrograms.Factorization(24);

            Console.ReadLine();
        }
    }
}
