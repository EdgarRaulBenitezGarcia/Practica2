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
            int horas = 0, minutos = 0, segundos = 0,opc = 0,salir = 0;
            
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
                       System.Console.WriteLine("Cronometro");
                        for (horas = 0; horas < 24; horas++)
                            for (minutos = 0; minutos < 60; minutos++)
                                for (segundos = 0; segundos < 60; segundos++)
                                {System.Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
                                
                                    
                           
                        Thread.Sleep(1000);
                        System.Console.Clear();}
 


                        break;
                }
            } while (opc != 0);
            


        }
    }
}
