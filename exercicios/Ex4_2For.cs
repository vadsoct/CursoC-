using System;
using System.Globalization;

namespace C_
{
    class Ex4_2For
       {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numero : ");
            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                  
            double In = 0;
            double Out = 0;

            for (int i = 1; i <= X ; i++)
                {       
                    System.Console.WriteLine("Verificar: ");
                    double N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    if (N >= 10 && N <=20 )
                    {
                        In++;
                                                                     
                    }else{

                        Out++;
                        
                    }
                

            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine(In + " in");
            System.Console.WriteLine(Out + " out");
        }
    }    
}


            
                    

            
                    
            