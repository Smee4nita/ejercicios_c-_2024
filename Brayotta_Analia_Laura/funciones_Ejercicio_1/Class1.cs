using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace funciones_Ejercicio_1
{
    //public class Class1
    //{
    //    static string PedirPalabra(string mensaje)
    //    {
    //        string palabra;
    //        Console.Write(mensaje);
    //        palabra=Console.ReadLine();
    //        return palabra;
    //    }

    //    static bool PalabraLarga()
    //    {
    //        string palabra = "";
    //        bool esLarga = false;
    //        PedirPalabra("por favor, ingrese una palabra");
    //        palabra=Console.ReadLine();

    //        if (palabra.Length >8)
    //        {
    //            esLarga = true;
    //        }
    //        else
    //        {
    //            esLarga= false;
    //        }

    //        return esLarga;
    //        if (esLarga == true)
    //        {
    //            Console.WriteLine("La palabra es larga");
    //        }
    //        else
    //        {
    //            Console.WriteLine("La palabra es corta");
    //        }
    //    }
    internal class Program
    {
        static void Main(string[] args)
        {   bool esLarga= false;
            EsPalabraLargaOCorta();
            if (esLarga==true)
            {
                Console.WriteLine("La palabra es Larga");
            }
            else
            {
                Console.WriteLine("La palabra es corta");
            }
        }


        static string PedirPalabra(string mensaje)
        {
            string palabra;
            Console.Write(mensaje);
            palabra=Console.ReadLine();
            return palabra;
        }

        static bool EsPalabraLargaOCorta()
        {
            string palabra = "";
            bool esLarga = false;
            PedirPalabra("por favor, ingrese una palabra");
            palabra=Console.ReadLine();

            if (palabra.Length >8)
            {
                esLarga = true;
            }
            else
            {
                esLarga= false;
            }

            return esLarga;

        }






    }
}





