namespace ejercicio_String_3_En_Clase
{   //3. Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial (* , & , etc).
    //ej: Manzana -> M* nz* n*.

    internal class Program
    {
        static void Main(string[] args)
        {
            //string palabra;

            //Console.Write("Por favor, ingrese una palbara: ");
            //palabra = Console.ReadLine();

            //char[] letras = palabra.ToCharArray();

            //for (int i = 0; i< letras.Length; i++)
            //{
            //    if (letras[i]=='a')
            //    {
            //        letras[i] = '@';
            //    }

            //}

            //foreach (char unaLetra in letras)
            //{
            //    Console.Write(unaLetra);
            //}

            string palabra;
            
            Console.Write("Por favor, escriba una palabra: ");
            palabra= Console.ReadLine();

            char[] letras= palabra.ToCharArray();

            for (int i = 0; i< letras.Length; i++)
            {
                if (letras[i]=='a')
                {
                    letras[i] = '@';
                }

            }

            foreach (char unaLetra in letras)
            {
                Console.Write(unaLetra);
            }

            string otraPalabra = "";

            foreach (char unaLetra in letras)
            {
                otraPalabra+= unaLetra;

            }
            Console.Write(otraPalabra);
        }
    }
}
