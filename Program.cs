using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingresar el tipo de producto (ej. medicina, alimentos, otros):");
        string tipoProducto = Console.ReadLine().ToLower();

        Console.WriteLine("Ingresar el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());

     
        double tasaImpuesto = 0.0;

        if (tipoProducto == "Medicina")
        {
            tasaImpuesto = 0.0; 
        }
        else if (tipoProducto == "Alimentos")
        {
            tasaImpuesto = 0.05; 
        }
        else
        {
            tasaImpuesto = 0.1; 
        }

        double impuesto = precio * tasaImpuesto;

        Console.WriteLine("El impuesto a pagar es: $" + impuesto);
    }
}
