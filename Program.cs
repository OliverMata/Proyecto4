using System;

namespace Proyecto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
            String letra=""; int  num = 0;
            Console.WriteLine("Introduzca una letra para poder ver el abecedario de forma descendente");
            letra=Console.ReadLine();
            for ( num = 90; num >= 65; num--)
            {
                Console.WriteLine("Letra: "+ Convert.ToString((char)num));
            }
            Console.ReadKey();
        }
    }
}
