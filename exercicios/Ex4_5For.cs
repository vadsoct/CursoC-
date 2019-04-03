using System;
using System.Globalization;

namespace C_
{
    class Ex4_5For
    {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numeros : ");
            int X = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                          
            double Z = 1;

            if (X == 0) X = 1;

            for (int i = X; i >= 1 ; i--)
            {   
                Z = Z * i;
                System.Console.WriteLine(Z);
            }           
        }
    }    
}


            
                    

            
                    
            