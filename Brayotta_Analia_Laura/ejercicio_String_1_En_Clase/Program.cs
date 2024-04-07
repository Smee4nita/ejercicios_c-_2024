namespace ejercicio_String_1_En_Clase
{
    internal class Program
    {   //1. Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
        // ej: zapallo -> zap
        static void Main(string[] args)
        {
            string palabra;
            do
            {
                Console.WriteLine("Por favor, ingrese una palabra con más de 5 caraácteres: ");
                palabra= Console.ReadLine();

                if (palabra.Length<5)
                {
                    Console.WriteLine("La pablabra tiene menos de 5 letras, escriba otra palabra");
                }

            }
            while (palabra.Length<5);

            for (int i = 0; i< 3; i++)
            {
                Console.Write(palabra[i]);
            }
            
        }
    }
}
