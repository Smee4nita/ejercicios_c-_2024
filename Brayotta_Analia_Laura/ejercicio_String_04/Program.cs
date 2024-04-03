namespace ejercicio_String_04
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Del string 0000001234500000000 conseguir quedarse con el string 12345 y mostrarlo por pantalla.
            string unnumero;
            unnumero="0000001234500000000";
            Console.WriteLine($" el número sin ceros es: {unnumero[6]}{unnumero[7]}{unnumero[8]}{unnumero[9]}{unnumero[10]}");
        }
    }
}
