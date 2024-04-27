namespace String_Ejercicio_5_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  lectura = "miley cYrus";

            string[] palabras = lectura.Split(',');

            string[] vectorNombre= palabras[0].ToLower().ToCharArray();

            string[] vectorApellido= palabras[1].ToLower().ToCharArray();

            vectorApellido= [0] = char.ToUpper(vectorApellido[0]);
            vectorNombre = [0] = char.ToUpper(vectorNombre[0]);
            
            string nombre = "";
            string apellido = string.Empty;

            foreach(char letra in vectorApellido)
            {
                nombre += letra;
            }

            foreach(char letra in vectorNombre)
            { 
                nombre += letra; 
            }

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}")

        }
    }
}
