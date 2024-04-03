namespace ejercicio_String_01
{
    internal class Program
    {
        static void Main(string[] args)
        {    //1. Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
             // ej: zapallo -> zap


            bool menosCinco;
            string palabra;
            menosCinco = false;

            do
            {
                
                Console.WriteLine("Hola, por favor ingrese una palabra que contenga al menos 5 letras");
                palabra = Console.ReadLine();
                int largo = palabra.Length;
                if (largo<5)
                {                   
                    Console.WriteLine("la palabra ingresada no tiene al menos 5 letras");
                    menosCinco=true;
                }
                else
                {
                    Console.WriteLine($" Las tres primeras letras son:  {palabra[0]}{palabra[1]}{palabra[2]}");
                    
                }
            
            }while (menosCinco==true);

        }
    }
}
