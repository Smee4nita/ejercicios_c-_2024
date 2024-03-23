namespace ejercicio_05
{
 //En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
// Área Porcentaje del presupuesto
//Cardiología			40%
//Pediatría			45%  
//Traumatología		15%

//Obtener la cantidad de dinero que recibirá cada área, para cualquier monto presupuestal.

    internal class Program
    {
        static void Main(string[] args)
        {
            double cardiologiaPorcentaje = 0.4;
            double pediatriaPorcentaje = 0.45;
            double traumatologiaPorcentaje = 0.15;
            string presupuestoTexto;
            int presupuesto;
            double presupuestoCardiologia;
            double presupuestoTraumato;
            double presupuestoPediatria;

            
            Console.WriteLine("Hola, buenos días. ¿Cuál es el presupuesto? : ");
            presupuestoTexto = Console.ReadLine();
            presupuesto = int.Parse(presupuestoTexto);
            presupuestoCardiologia = presupuesto*cardiologiaPorcentaje;
            presupuestoPediatria = presupuesto*pediatriaPorcentaje;
            presupuestoTraumato = presupuesto*traumatologiaPorcentaje;
            Console.WriteLine($"El presupuesto para cardiología es: {presupuestoCardiologia}, el presupuesto para pediatría es: {presupuestoPediatria} y el presupuesto para traumatología es: {presupuestoTraumato}");

        }
    }
}
