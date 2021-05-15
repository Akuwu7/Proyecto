using System;
using System.Collections.Generic;
using System.Text;

namespace Sotelo_Luana
{
    class Periféricos
    {
        public static void  Seleccionado()
        {
            string Monitor = " FX369";
            string Audifono = " LG 420 PLUS";
            string Mouse = " Ratón veloz 7500";
            string Microfono = " Habla que te habla v2";
            string Webcam = " LG thebeo PRO";
            string Teclado = " Ornata v2";
            string Parlante = " Que ven mis oídos ULTRA PLUS V4";

            int stockMonitor = 40;
            int stockAudifono = 23;
            int stockMouse = 33;
            int stockMicrofono = 18;
            int stockWebcam = 59;
            int stockTeclado = 35;
            int stockParlante = 14;

            Console.WriteLine("Haz escogido Periféricos yei");
            Console.WriteLine("Estos son los Periféricos que tenemos, seleccione el que desee para ver el stock");
            Console.WriteLine("1 - Monitor");
            Console.WriteLine("2 - Audífono");
            Console.WriteLine("3 - Mouse");
            Console.WriteLine("4 - Micrófono");
            Console.WriteLine("5 - Webcam");
            Console.WriteLine("6 - Teclado");
            Console.WriteLine("7 - Parlante");

            string opcion = Console.ReadLine();
            switch (opcion) {
                case "1":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Monitor " + Monitor);
                    Console.WriteLine("Esta es la cantidad en stock " + stockMonitor);
                    break;

                case "2":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Audífono " + Audifono);
                    Console.WriteLine("Esta es la cantidad en stock " + stockAudifono);
                    break;

                case "3":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Mouse " + Mouse);
                    Console.WriteLine("Esta es la cantidad en stock " + stockMouse);
                    break;

                case "4":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Micrófono " + Microfono);
                    Console.WriteLine("Esta es la cantidad en stock " + stockMicrofono);
                    break;

                case "5":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Webcam " + Webcam);
                    Console.WriteLine("Esta es la cantidad en stock " + stockWebcam);
                    break;

                case "6":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Teclado " + Teclado);
                    Console.WriteLine("Esta es la cantidad en stock " + stockTeclado);
                    break;

                case "7":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Parlante " + Parlante);
                    Console.WriteLine("Esta es la cantidad en stock " + stockParlante);
                    break;

                default:
                    Console.WriteLine("Acceso deneGAAdo");
                    break;
            }
         }
    }
}
