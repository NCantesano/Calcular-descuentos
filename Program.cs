using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

        // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
        // de la cantidad de litros vendidos según la siguiente escala:

        //Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%./  
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        // Hacer un programa que solicite el ingreso del importe total de la venta y la 
        // cantidad de litros vendidos y calcule y emita el importe con el descuento  
        // aplicado..

        float n1,n2,descuento, importefinal;

        Console.WriteLine("importe total de venta: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("litros vendidos: ");
        n2 = float.Parse(Console.ReadLine());

        if ( n2 >= 101 && n2 <= 300)
             descuento = n1 * 0.10F;
        else if (n2 >= 301 && n2 <= 500)
             descuento = n1 * 0.15F;
        else if ( n2 > 500)
             descuento = n1 * 0.25F;
        else
             descuento = 0;
        

        importefinal = n1 - descuento;
        
        Console.WriteLine(" importe final: " + importefinal);
       



        }
    }
}
