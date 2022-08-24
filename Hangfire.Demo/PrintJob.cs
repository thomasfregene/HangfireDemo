using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Demo
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            Console.WriteLine($"Hangfire recurring job!");
        }
    }
}
