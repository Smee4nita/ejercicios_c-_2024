namespace ejercicio_3
{ 
    //Ingresar 2 números y mostrar la suma de los mismos.

    internal class Program
    {
        static void Main(string[] args)

        {
            string numUnoTexto;
            string numDosTexto;
            int numeroUno;
            int numeroDos;
            int resultado;
            
            Console.WriteLine("Hola, ingrese un número, por favor");
            numUnoTexto = Console.ReadLine();
            numeroUno = int.Parse(numUnoTexto);
            
            Console.WriteLine("Por favor, ingrese otro número");
            numDosTexto =Console.ReadLine();
            numeroDos = int.Parse(numDosTexto);
            resultado = numeroUno + numeroDos;
            
            Console.WriteLine($"EL resultado es = {resultado}");

        }
    }
}
