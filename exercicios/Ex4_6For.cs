using System;
using System.Globalization;

namespace C_
{
    class Ex4_6For
    {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numeros : ");
            int X = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                          
                        
            for (int i = 1; i <= X ; i++)
            {   
                if (X % i == 0) 
                {
                 System.Console.WriteLine(i);
                }
                
            }           
        }
    }    
}


            
                    

            
                    
            