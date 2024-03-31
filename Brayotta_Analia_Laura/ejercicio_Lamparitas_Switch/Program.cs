namespace ejercicio_Lamparitas_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marcaDeLamparita;
            int cantidadDeLamparitas;
            double precioLamparita;
            double totalSinDescuento;
            double descuento;
            double porcentajeDescuento;
            double ingesosBrutos;
            double totalAPagar;
            precioLamparita= 150;


            Console.WriteLine("Hola, buenos días, por favor indique cuántas lamparitas quiere comprar:  ");
            cantidadDeLamparitas = int.Parse(Console.ReadLine());
            Console.WriteLine("por favor indique la marca");
            marcaDeLamparita = Console.ReadLine();

            switch (cantidadDeLamparitas)
            {
                case >= 6:
                    {
                        porcentajeDescuento=0.50;
                        break;

                    }
                case 5:

                    {
                        if (marcaDeLamparita=="argentinaluz")
                        {
                            porcentajeDescuento = 0.40;
                        }
                        else
                        {
                            porcentajeDescuento=0.30;

                        }
                        break;
                    }

                case 4:

                    {
                        if (marcaDeLamparita=="argentinaluz" || marcaDeLamparita == "felipelamparas")
                        {
                            porcentajeDescuento=0.25;

                        }
                        else
                        {
                            porcentajeDescuento=0.20;
                        }
                    }
                    break;

                case 3:
                    {
                        if (marcaDeLamparita=="argentinaluz")
                        {
                            porcentajeDescuento=0.15;
                        }
                        else
                        {
                            if (marcaDeLamparita=="felipelampara")
                            {
                                porcentajeDescuento=0.10;
                            }
                            else
                            {
                                porcentajeDescuento=0.05;
                            }
                        }
                    }
                    break;

                default:
                    {
                        porcentajeDescuento=0;
                    }
                    break;

            }

            Console.WriteLine($"La marca que usted compra es:{marcaDeLamparita}");
            Console.WriteLine($"La cantidad de lamparitas que compra es: {cantidadDeLamparitas}");
            totalSinDescuento=precioLamparita*cantidadDeLamparitas;
            Console.WriteLine($"El total a pagar es: {totalSinDescuento}");
            descuento=porcentajeDescuento*totalSinDescuento;
            if (descuento > 0)
            {
                Console.WriteLine($"Felicitaciones por su compra tiene un descuento de $ {descuento}");
            }
            totalAPagar=totalSinDescuento-descuento;
            if (totalAPagar > 950)
            {
                ingesosBrutos=totalAPagar*0.10;
                totalAPagar= totalAPagar+ingesosBrutos;
                Console.WriteLine($"Como su compra supera los $950, tiene que pagar ingresos brutos que son :$ {ingesosBrutos} más");
            }
            Console.WriteLine($"El total a pagar es de:$ {totalAPagar} ");


        }
    }
}
