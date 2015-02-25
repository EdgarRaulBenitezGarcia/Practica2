using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, minutos = 0, segundos = 0,opc = 0;
            do
            {
                System.Console.WriteLine("Opciones de Tiempo");
                System.Console.WriteLine("");
                System.Console.WriteLine("[1] Cronometro");
                System.Console.WriteLine("[2] Reloj");
                System.Console.WriteLine("Que deseas ver...");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1: System.Console.Clear();
                        for (horas = 0; horas < 24; horas++)
                            for (minutos = 0; minutos < 60; minutos++)
                                for (segundos = 0; segundos < 60; segundos++)
                                {System.Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
                                System.Console.WriteLine("CTRL + C para salir");
                                Thread.Sleep(1000);
                        System.Console.Clear();}
                        break;
                    case 2: System.Console.Clear();
                        DateTime reloj = DateTime.Now;
                        for (horas = reloj.Hour; horas < 24; horas++)
                            for (minutos = reloj.Minute; minutos < 60; minutos++)
                                for (segundos = reloj.Second; segundos < 60; segundos++){
                                reloj = DateTime.Now;
                                System.Console.WriteLine("la hora es {0}:{1}:{2}",reloj.Hour, reloj.Minute, reloj.Second);
                                 System.Console.WriteLine("CTRL + C para salir");
                                Thread.Sleep(1000);
                        System.Console.Clear();}
                        break;
                }
            } while (opc != 0);
        }
    }
}
