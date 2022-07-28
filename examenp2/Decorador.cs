using System;
public class Decorador: OrdenBase
{
    protected OrdenBase toppings;
    public Decorador (OrdenBase toppings)
    {
        this.toppings=toppings;
    }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("calculo del precio total desde la clase decorador");
        return toppings.CalculoTotalPrecio();
    }
}