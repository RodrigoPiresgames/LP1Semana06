﻿using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);

        }
    }
}
