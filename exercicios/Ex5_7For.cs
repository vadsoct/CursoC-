using System;
using System.Globalization;

namespace C_
{
    class Ex4_7For
    {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numeros : ");

            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);        
            double Y = 0, Z = 0 ;                  
                        
            for (int i = 1; i <= X ; i++)
            {   
                Y = Math.Pow(i,2);
                Z = Math.Pow(i,3);

                System.Console.WriteLine(i +" "+ Y +" "+ Z);
                
            }           
        }
    }    
}


            
                    

            
                    
            