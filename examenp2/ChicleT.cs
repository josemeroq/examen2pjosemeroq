using System;
public class ChicleT: OrdenBase
{
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo total de un helado con topping de Chicle");
            return helados.Sum(x=> x.Precio)* 0.80;
        }
}