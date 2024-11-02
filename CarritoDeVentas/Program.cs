internal class Program
{
    private static void Main(string[] args)
    {
        //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
        //Mostrar lo que debe abonar el comprador.
        Carrito();
    }

    private static void Carrito()
    {
        string Articulo = "Papas Fritas";
        int PrecioArticulo = 0;
        int CantidadArticulo = 0;
        int CantidadAbonarComprador = 0;




        Console.WriteLine($"Por favor ingrese el precio de: {Articulo} ");
        PrecioArticulo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Ingrese la cantidad de {Articulo} que tomara");
        CantidadArticulo = int.Parse(Console.ReadLine());

        CantidadAbonarComprador = (PrecioArticulo * CantidadArticulo);

        Console.WriteLine($"Usted tiene que abonar una cantidad de: {(CantidadAbonarComprador)} pesos");

    }
}