internal class Program
{
    private static void Main(string[] args)
    {
        //2.Realizar la carga del lado de un cuadrado,
        //mostrar por pantalla el perímetro del mismo
        //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
        Cuadrado();
    }

    private static void Cuadrado()
    {
        int ladoDeUnCuadrado = 0;
        int perimetroDelCuadrado = 0;


        Console.WriteLine("Ingrese el lado del cuadrado");
        ladoDeUnCuadrado = int.Parse(Console.ReadLine());

        perimetroDelCuadrado = (ladoDeUnCuadrado * 4);

        Console.WriteLine($"El perimetro del cuadrado es de: {perimetroDelCuadrado}");
    }
}