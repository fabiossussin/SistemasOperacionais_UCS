using System;
using System.Threading;

namespace Ucs_SO
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Início da Execução: {DateTime.Now}");
            new Principal.Principal().Start();
            Console.WriteLine($"Final da Execução: {DateTime.Now}");
        }

    }
}
