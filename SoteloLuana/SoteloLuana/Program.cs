using System;

namespace Sotelo_Luana
{
    public class Program

    {
            public static void Main()
        {
            Console.WriteLine("Hola, este es el explorador de componentes de computadora. ¿Qué desea ver?");
            Console.WriteLine("1 - Periféricos");
            Console.WriteLine("2 - Almacenamiento");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Periféricos.Seleccionado();
                    break;

                case "2":
                    Almacenamiento.Seleccionado2();
                    break;
                    
            }
        }
    }
}

