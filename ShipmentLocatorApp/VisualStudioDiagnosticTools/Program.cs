using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace VisualStudioDiagnosticTools
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i <= 100; i++)
            {
                if (i % 5 != 0)
                {
                    WriteLine("Karma, ");
                }
                else
                {
                    WriteLine("karma chameleon");
                    WriteLine("You come and go, you come and go");
                    Thread.Sleep(1000);
                }

                
            }

        }
    }


}
