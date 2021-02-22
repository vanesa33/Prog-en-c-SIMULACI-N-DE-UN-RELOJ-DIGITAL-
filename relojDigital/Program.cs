using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SIMULACIÓN_DE_UN_RELOJ_DIGITAL
{
    class Program
    {
        static void Main(string[] args)
        {
            byte H, M, S;
            Console.SetCursorPosition(15, 2);
            Console.Write("SIMULACIÓN DE UN RELOJ DIGITAL");
            for (H = 0; H <= 24; H++)
            {
                for (M = 0; M <= 59; M++)
                {
                    for (S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.Write("{0} : {1} : {2}", H, M, S);
                    }
                }
            }
            Console.SetCursorPosition(25, 15);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}