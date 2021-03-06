﻿using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Modules
{
    class UtcEnroller : IEnroller
    {
        public void Write(string text)
        {
            Console.WriteLine($"{ text } --- { DateTime.UtcNow.ToString() }");
        }
    }
}
