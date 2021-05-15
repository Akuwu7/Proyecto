using System;
using System.Collections.Generic;
using System.Text;

namespace Sotelo_Luana
{
    class Almacenamiento
    {
        public static void Seleccionado2()
        {
            string Memoria_USB = " Thewardo";
            string Disco_Duro_Externo = " Patito Duro";

            int stockMemoria_USB = 12;
            int stockDisco_Duro_Externo = 4;

            Console.WriteLine("Haz escogido Almacenamiento yei");
            Console.WriteLine("Estos son los Almacenamientos que tenemos, seleccione el que desee para ver el stock");
            Console.WriteLine("1 - Memoria_USB");
            Console.WriteLine("2 - Disco_Duro_Externo");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Memoria_USB " + Memoria_USB);
                    Console.WriteLine("Esta es la cantidad en stock " + stockMemoria_USB);
                    break;

                case "2":
                    Console.WriteLine("Este el nombre de nuestro producto y cuantos hay en stock");
                    Console.WriteLine("Disco_Duro_Externo " + Disco_Duro_Externo);
                    Console.WriteLine("Esta es la cantidad en stock " + stockDisco_Duro_Externo);
                    break;
               
                default:
                    Console.WriteLine("Acceso deneGAAdo");
                    break;
            }
        }
    }
}

    

