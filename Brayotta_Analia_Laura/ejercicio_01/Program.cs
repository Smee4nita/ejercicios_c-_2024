namespace ejercicio_01
{
    //Ingresar el nombre y apellido por consola.

    internal class Program
    {
        static void Main(string[] args)

        {
            string nombre;
            string apellido;
           
            Console.Write("Hola, por favor, ingrese su Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Hola, por favor, ingrese su Apellido: ");
            apellido = Console.ReadLine();
        
            Console.Write($"Bienvenidx, {nombre} {apellido}");

        }
    }
}
