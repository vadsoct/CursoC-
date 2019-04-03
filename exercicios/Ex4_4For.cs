using System;
using System.Globalization;

namespace C_
{
    class Ex4_4For
    {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numeros : ");
            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                  
            double A, B, M = 0;
            
            for (int i = 1; i <= X ; i++)
            {                     
                System.Console.WriteLine("Entre com o primeiro numero : ");
                A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        
                System.Console.WriteLine("Entre com a segundo numero : ");
                B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    if(B != 0)
                    {
                        M=A/B;
                        System.Console.WriteLine(M.ToString("F1",CultureInfo.InvariantCulture)); 

                    }else{

                        M = 0;
                        System.Console.WriteLine("Divisão Impossivel");
                    }
            }
        }
    }    
}


            
                    

            
                    
            