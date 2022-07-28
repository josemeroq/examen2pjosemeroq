using System;
public class ChocolateT: OrdenBase
{
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo total del helado con topping Chocolate ");
            return helados.Sum(x=> x.Precio)* 0.50;
        }
}