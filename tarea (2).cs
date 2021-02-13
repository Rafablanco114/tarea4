using System;

namespace la_primeraaaaaaaaaaaaaa
{
    class batman
    {
        static void Main(string[] args)
        {
            ///Declaracion de variables
            int x = 0, y = 0, z = 0;
            do
            {
                Console.WriteLine("Hola, Ingrese cualquier numero mayor de 1 para continuar");
                //Parse es el metodo de almacenar en una variable el dato
                x = int.Parse(Console.ReadLine());

                if (x > 1)
                {
                    z = x + x;
                }
            } while (x > 1);
            //Este es el metodo para imprimir el resultado
            Console.WriteLine("Su resultado es:{0}", z);
            Console.ReadKey();

        }
    }

}
