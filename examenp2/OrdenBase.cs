public abstract class OrdenBase
{
        protected List<Helados> helados =new List<Helados>
        {
            new Helados {Sabor = "Helado de chocolate", Precio= 3.0},
            new Helados {Sabor= "Helado de Menta", Precio= 4.0},  
            new Helados {Sabor = "Helado de Vainilla", Precio= 3.0}
        };
        public abstract double CalculoTotalPrecio();
}