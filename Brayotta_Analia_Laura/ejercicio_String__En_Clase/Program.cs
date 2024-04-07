namespace ejercicio_String__En_Clase
{
    internal class Program
    {   //Pedir el ingreso de una palabra y mostrarla con todos sus caracteres separados por un guión.
       // ej: Montaña -> M-o-n-t-a-ñ-a.

        static void Main(string[] args)
        {
            string palabra;
            Console.Write("Por favor, ingrese una palabra: ");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[i]);
                if( i < palabra.Length - 1)
                {
                    Console.Write(" - ");
                }
            }
        }
    }
}
