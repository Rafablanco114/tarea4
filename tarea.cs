using System;

namespace primera_de_la_practica_real
{
    class Program
    {
        static void Main(string[] args)
        {



            {
                //Declaracion de variables mayusculas
                char letra = 'Z';
                //El contador se encargara de limitar la salida a solo numeros y las 26 letras del ABC
                int cont = 27;
                do
                {
                    //Se imprime en bucle hasta la salida deseada
                    Console.WriteLine(letra);
                    letra--;
                    cont = cont - 1;
                } while (cont != 1);
            }
        }
    }
}