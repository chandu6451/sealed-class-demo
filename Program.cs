﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    public sealed class MyClass
    { }

    public class Calculate : MyClass
    { }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
