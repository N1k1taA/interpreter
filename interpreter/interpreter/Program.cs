﻿using System;

namespace interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new FileReader();
            a.ReadFile();
        }
    }
}
