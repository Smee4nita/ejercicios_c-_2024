namespace ejercicio_String_4_En_Clase
{
    internal class Program
    {   //Del string 0000001234500000000 conseguir quedarse con el string 12345 y mostrarlo por pantalla.

        static void Main(string[] args)
        {
            string palabra="0000001234500000000";

            Console.WriteLine(palabra.Trim('0')); 
        }
    }
}
