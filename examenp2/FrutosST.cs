using System;
public class FrutosST: OrdenBase
{
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo total de un helado con topping de Frutos Secos");
            return helados.Sum(x=> x.Precio)* 0.30;
        }

}