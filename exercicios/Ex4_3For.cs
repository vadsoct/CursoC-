using System;
using System.Globalization;

namespace C_
{
    class Ex4_3For
       {
       public static void Ex1()
        {                     
            System.Console.WriteLine("Digite a quantidade de vezes que sera lido os numero : ");
            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                  
            double A = 0, B = 0, C = 0;
            double M = 0;

            for (int i = 1; i <= X ; i++)
                {       
                    System.Console.WriteLine("Entre com a primeira nota : ");
                    A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        
                    System.Console.WriteLine("Entre com a segunda nota : ");
                    B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        
                    System.Console.WriteLine("Entre com a terceira nota : ");
                    C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                M = (A * 2.0 + B * 3.0 + C * 5.0) / 10;     

                System.Console.WriteLine("Media " + M.ToString("F1",CultureInfo.InvariantCulture));           

            }
            
            
        }
    }    
}


            
                    

            
                    
            