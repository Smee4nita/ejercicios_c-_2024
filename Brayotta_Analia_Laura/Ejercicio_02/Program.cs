namespace Ejercicio_02
{
    internal class Program
    {
        //Ingresar el nombre, apellido y edad por consola.
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;
            int edadNumerica;

            Console.Write("Ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido:");

            apellido = Console.ReadLine();

            Console.Write("Ingrese su edad: ");

            edadTexto = Console.ReadLine();

            edadNumerica = int.Parse(edadTexto);


            Console.WriteLine($"Bienvenidx {nombre} {apellido}, usted tiene: {edadNumerica} años.");
        }
    }
}