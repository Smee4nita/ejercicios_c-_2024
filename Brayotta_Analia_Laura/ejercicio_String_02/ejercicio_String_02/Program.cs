namespace ejercicio_String_02
{
    internal class Program
    {
        static void Main(string[] args)
        {   //2. Pedir el ingreso de una palabra y mostrarla con todos sus caracteres separados por un guión.
            // ej: Montaña -> M-o-n-t-a-ñ-a.

            string palabra;
            Console.WriteLine("hola, por favor ingrese una palabra");
            palabra = Console.ReadLine();
            int largo;
            largo=palabra.Length;
            foreach (char letra in palabra)
            {
                Console.Write($"{letra}-");
            }
        }
    }
}
