namespace funciones_explicacion
{ // copiando las explicaciones tambien tira error, viendo videos dicen que no se escriben los metodos afuera del internal class program
  //intentando entender porque no sale copiando los ejemplos tampoco sale :(


    internal class Program
    {
        static void Main(string[] args)

        {
            Saludar();

        }
        static void Saludar()
        {
            string nombre;
            Console.WriteLine("ingrese su nombre");
            nombre= Console.ReadLine();
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
