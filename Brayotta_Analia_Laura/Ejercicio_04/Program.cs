namespace Ejercicio_04
{
    //Ingresar 5 números enteros, calcular y mostrar el promedio.

    internal class Program
    {
        static void Main(string[] args)
         
        {
            string numUnoTexto;
            string numDosTexto;
            string numTresTexto;
            string numCuatroTexto;
            string numCincoTexto;
            int numUno;
            int numDos;
            int numTres;
            int numCuatro;
            int numCinco;
            float promedio;

            Console.WriteLine("Hola, Escriba un número");
            numUnoTexto = Console.ReadLine();
            numUno = int.Parse(numUnoTexto);

            Console.WriteLine("Hola, Escriba otro número");
            numDosTexto = Console.ReadLine();
            numDos = int.Parse(numDosTexto);

            Console.WriteLine("Hola, Escriba otro número");
            numTresTexto = Console.ReadLine();
            numTres = int.Parse(numTresTexto);

            Console.WriteLine("Hola, Escriba otro número");
            numCuatroTexto = Console.ReadLine();
            numCuatro = int.Parse(numCuatroTexto);

            Console.WriteLine("Hola, Escriba otro número");
            numCincoTexto = Console.ReadLine();
            numCinco = int.Parse(numCincoTexto);

            promedio = (numUno + numDos + numTres + numCuatro + numCinco)/5;

            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
