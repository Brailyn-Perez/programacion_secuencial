internal class Program
{
    private static void Main(string[] args)
    {
        CalcularPromedio();
            
    }


    private static void CalcularPromedio()
    {

        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int cantidadDeNotas = 3;
        int promedio =0;
        
        Console.WriteLine("Ingrese la nota 1");
        nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 2");
        nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 3");
        nota3 = int.Parse(Console.ReadLine());

        promedio = (nota1+nota2+nota3) / cantidadDeNotas;
        if (promedio>=7)
        {
            Console.WriteLine("Promocionado");
            return;
        }
        else if(promedio>=4) 
        {
            Console.WriteLine("Regular");
            return;
        }
        else
        {
            Console.WriteLine("Reprobado");
            return;
        }
    }
}